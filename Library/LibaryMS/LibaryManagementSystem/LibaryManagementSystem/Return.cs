using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibaryManagementSystem
{
    public partial class frmReturn : Form
    {
        string dbpath = "Data Source=DESKTOP-SFMP7H4\\SQLEXPRESS;Initial Catalog=LibMS;Integrated Security=True";

        public frmReturn()
        {
            InitializeComponent();
            txtReturnDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void frmReturn_Load(object sender, EventArgs e)
        {
            // Optional: Initialize controls
        }

        private void LoadLoanInfo(string copyID, string membID)
        {
            using (SqlConnection conn = new SqlConnection(dbpath))
            {
                conn.Open();
                string query = @"SELECT LoanID, CopyID, MembID, LoanDate, DueDate, Returned 
                                 FROM Loan 
                                 WHERE CopyID = @CopyID AND MembID = @MembID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CopyID", copyID);
                    cmd.Parameters.AddWithValue("@MembID", membID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvLoanInfo.DataSource = dt;

                    dgvLoanInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    // Convert Returned column to checkbox if not already
                    if (dgvLoanInfo.Columns.Contains("Returned") &&
                        !(dgvLoanInfo.Columns["Returned"] is DataGridViewCheckBoxColumn))
                    {
                        int colIndex = dgvLoanInfo.Columns["Returned"].Index;
                        DataGridViewCheckBoxColumn chkCol = new DataGridViewCheckBoxColumn
                        {
                            Name = "Returned",
                            HeaderText = "Returned",
                            DataPropertyName = "Returned",
                            TrueValue = true,
                            FalseValue = false
                        };
                        dgvLoanInfo.Columns.RemoveAt(colIndex);
                        dgvLoanInfo.Columns.Insert(colIndex, chkCol);
                    }
                }
            }
        }

        private void btnCL_Click(object sender, EventArgs e)
        {
            string copyID = txtCopyID.Text.Trim();
            string membID = txtMembID.Text.Trim();

            if (string.IsNullOrEmpty(copyID) || string.IsNullOrEmpty(membID))
            {
                MessageBox.Show("⚠️ Please enter both CopyID and MemberID.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(dbpath))
            {
                conn.Open();

                // 1. Check loan info (unreturned only)
                string loanQuery = @"SELECT * FROM Loan WHERE CopyID = @CopyID AND MembID = @MembID AND Returned = 0";

                using (SqlCommand cmd = new SqlCommand(loanQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@CopyID", copyID);
                    cmd.Parameters.AddWithValue("@MembID", membID);

                    DataTable dt = new DataTable();
                    new SqlDataAdapter(cmd).Fill(dt);
                    dgvLoanInfo.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("❌ No active loan found for this member and copy.", "Loan Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // 2. Check reservations
                string titleQuery = "SELECT TitleID FROM Copies WHERE CopyID = @CopyID";
                string titleID = null;

                using (SqlCommand titleCmd = new SqlCommand(titleQuery, conn))
                {
                    titleCmd.Parameters.AddWithValue("@CopyID", copyID);
                    object result = titleCmd.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("⚠️ Title ID not found for this Copy ID.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    titleID = result.ToString();
                }

                string reserveQuery = @"SELECT TOP 1 MembID FROM Reservation 
                                        WHERE TitleID = @TitleID ORDER BY ReserveDate ASC";

                using (SqlCommand cmd2 = new SqlCommand(reserveQuery, conn))
                {
                    cmd2.Parameters.AddWithValue("@TitleID", titleID);
                    using (SqlDataReader reader = cmd2.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string reservedMembID = reader["MembID"].ToString();
                            MessageBox.Show($"⚠️ Book is reserved by Member ID: {reservedMembID}. Please keep it aside for the member.",
                                "Reservation Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("✅ No reservation. Book is ready to return.", "Return Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btnRB_Click(object sender, EventArgs e)
        {
            string copyID = txtCopyID.Text.Trim();
            string membID = txtMembID.Text.Trim();

            if (string.IsNullOrEmpty(copyID) || string.IsNullOrEmpty(membID))
            {
                MessageBox.Show("⚠️ Please enter both CopyID and MemberID.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(dbpath))
            {
                conn.Open();

                // Update Loan table
                string updateLoan = @"UPDATE Loan SET Returned = 1 
                                      WHERE CopyID = @CopyID AND MembID = @MembID AND Returned = 0";

                using (SqlCommand cmd = new SqlCommand(updateLoan, conn))
                {
                    cmd.Parameters.AddWithValue("@CopyID", copyID);
                    cmd.Parameters.AddWithValue("@MembID", membID);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("✅ Book returned successfully.", "Return Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Update Copies table
                        using (SqlCommand updateCopy = new SqlCommand("UPDATE Copies SET LoanedOut = 0 WHERE CopyID = @CopyID", conn))
                        {
                            updateCopy.Parameters.AddWithValue("@CopyID", copyID);
                            updateCopy.ExecuteNonQuery();
                        }

                        // Get TitleID
                        string titleQuery = "SELECT TitleID FROM Copies WHERE CopyID = @CopyID";
                        string titleID = null;

                        using (SqlCommand getTitleCmd = new SqlCommand(titleQuery, conn))
                        {
                            getTitleCmd.Parameters.AddWithValue("@CopyID", copyID);
                            object result = getTitleCmd.ExecuteScalar();
                            if (result != null) titleID = result.ToString();
                        }

                        // Check for reservation
                        if (!string.IsNullOrEmpty(titleID))
                        {
                            string reserveQuery = @"SELECT TOP 1 MembID, ReservationID 
                                                    FROM Reservation 
                                                    WHERE TitleID = @TitleID 
                                                    ORDER BY ReserveDate ASC";

                            using (SqlCommand reserveCmd = new SqlCommand(reserveQuery, conn))
                            {
                                reserveCmd.Parameters.AddWithValue("@TitleID", titleID);
                                using (SqlDataReader reader = reserveCmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        string reservedMembID = reader["MembID"].ToString();
                                        int reservationID = Convert.ToInt32(reader["ReservationID"]);
                                        reader.Close();

                                        MessageBox.Show($"⚠️ Notify Member ID: {reservedMembID} - Their reserved book is now available.",
                                            "Reservation Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        using (SqlCommand deleteCmd = new SqlCommand("DELETE FROM Reservation WHERE ReservationID = @ReservationID", conn))
                                        {
                                            deleteCmd.Parameters.AddWithValue("@ReservationID", reservationID);
                                            deleteCmd.ExecuteNonQuery();
                                        }
                                    }
                                    else
                                    {
                                        reader.Close();
                                        MessageBox.Show("✅ No reservations found for this title.", "Reservation Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("❌ Return failed. Book may not be loaned.", "Return Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Refresh DataGridView
                    LoadLoanInfo(copyID, membID);
                }
            }
        }
    }
}

