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
    public partial class frmLoan : Form
    {
        public frmLoan()
        {
            InitializeComponent();
            this.Load += Loan_Load;
            btnReset.Click += btnReset_Click;  // ✅ Attach Reset button event
        }

        string dbpath = "Data Source=DESKTOP-SFMP7H4\\SQLEXPRESS;Initial Catalog=LibMS;Integrated Security=True";

        private void Loan_Load(object sender, EventArgs e)
        {
            GenerateLoanID(); // Auto-generate LoanID on form load
            btnBorrow.Enabled = false;
        }

        private void GenerateLoanID()
        {
            using (SqlConnection conn = new SqlConnection(dbpath))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT MAX(LoanID) FROM Loan", conn);
                object result = cmd.ExecuteScalar();

                string newID = "L001";

                if (result != DBNull.Value && result != null)
                {
                    string lastID = result.ToString(); // e.g., "L005"
                    if (lastID.StartsWith("L") && int.TryParse(lastID.Substring(1), out int num))
                    {
                        num += 1;
                        newID = "L" + num.ToString("D3");
                    }
                }

                txtLID.Text = newID;
            }
        }

        private void LoadLoans()
        {
            using (SqlConnection conn = new SqlConnection(dbpath))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT L.LoanID, C.CopyID, B.TitleID, L.LoanDate, L.DueDate " +
                    "FROM Loan L " +
                    "JOIN Copies C ON L.CopyID = C.CopyID " +
                    "JOIN BookInfo B ON C.TitleID = B.TitleID " +
                    "WHERE L.MembID = @MembID AND L.Returned = 0", conn);
                da.SelectCommand.Parameters.AddWithValue("@MembID", txtMembID.Text);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLoans.DataSource = dt;

                dgvLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvLoans.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(dbpath))
            {
                conn.Open();

                SqlCommand cmdMemb = new SqlCommand("SELECT MembType FROM Borrower WHERE MembID = @MembID", conn);
                cmdMemb.Parameters.AddWithValue("@MembID", txtMembID.Text);
                object membType = cmdMemb.ExecuteScalar();

                if (membType == null)
                {
                    MessageBox.Show("❌ Member not found.");
                    return;
                }

                string memberType = membType.ToString();
                txtMembType.Text = memberType;

                if (memberType == "Visitor" || memberType == "Registered Visitor")
                {
                    MessageBox.Show("❌ Visitors are not allowed to borrow books.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnBorrow.Enabled = false;
                    return;
                }

                SqlCommand cmdBorrowed = new SqlCommand("SELECT COUNT(*) FROM Loan WHERE MembID = @MembID AND Returned = 0", conn);
                cmdBorrowed.Parameters.AddWithValue("@MembID", txtMembID.Text);
                int borrowedCount = (int)cmdBorrowed.ExecuteScalar();

                if (borrowedCount >= 5)
                {
                    MessageBox.Show("❌ Borrowing limit exceeded! Return books first.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnBorrow.Enabled = false;
                    return;
                }

                SqlCommand cmdBook = new SqlCommand("SELECT Status FROM Copies WHERE CopyID = @CopyID", conn);
                cmdBook.Parameters.AddWithValue("@CopyID", txtCopyID.Text);
                object bookStatus = cmdBook.ExecuteScalar();

                if (bookStatus == null)
                {
                    txtBS.Text = "Not found";
                    MessageBox.Show("❌ Copy not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnBorrow.Enabled = false;
                    return;
                }

                txtBS.Text = bookStatus.ToString();

                if (txtBS.Text == "Reference")
                {
                    MessageBox.Show("❌ This book is for reference only. Not borrowable.", "Reference Only", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnBorrow.Enabled = false;
                    return;
                }

                SqlCommand checkAlreadyLoaned = new SqlCommand("SELECT COUNT(*) FROM Loan WHERE CopyID = @CopyID AND Returned = 0", conn);
                checkAlreadyLoaned.Parameters.AddWithValue("@CopyID", txtCopyID.Text);
                int alreadyLoaned = (int)checkAlreadyLoaned.ExecuteScalar();

                if (alreadyLoaned > 0)
                {
                    MessageBox.Show("❌ This book is already borrowed by another user and not yet returned.", "Already Loaned", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnBorrow.Enabled = false;
                    return;
                }

                int remaining = 5 - borrowedCount;
                MessageBox.Show($"✅ Eligible to borrow ({remaining} books remaining).", "Borrow Allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBorrow.Enabled = true;

                LoadLoans();
                GenerateLoanID();
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (txtMembType.Text == "Visitor" || txtMembType.Text == "Registered Visitor")
            {
                MessageBox.Show("❌ Visitors are not allowed to borrow books.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(dbpath))
            {
                conn.Open();

                SqlCommand checkLoanID = new SqlCommand("SELECT COUNT(*) FROM Loan WHERE LoanID = @LoanID", conn);
                checkLoanID.Parameters.AddWithValue("@LoanID", txtLID.Text);
                int existing = (int)checkLoanID.ExecuteScalar();

                if (existing > 0)
                {
                    MessageBox.Show("❌ Loan ID already exists. Please click Check to refresh.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlCommand checkAlreadyLoaned = new SqlCommand("SELECT COUNT(*) FROM Loan WHERE CopyID = @CopyID AND Returned = 0", conn);
                checkAlreadyLoaned.Parameters.AddWithValue("@CopyID", txtCopyID.Text);
                int alreadyLoaned = (int)checkAlreadyLoaned.ExecuteScalar();

                if (alreadyLoaned > 0)
                {
                    MessageBox.Show("❌ This copy is already on loan.", "Duplicate Loan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlCommand cmdInsert = new SqlCommand("INSERT INTO Loan (LoanID, MembID, CopyID, LoanDate, DueDate, Returned) " +
                                                      "VALUES (@LoanID, @MembID, @CopyID, @LoanDate, @DueDate, 0)", conn);
                cmdInsert.Parameters.AddWithValue("@LoanID", txtLID.Text);
                cmdInsert.Parameters.AddWithValue("@MembID", txtMembID.Text);
                cmdInsert.Parameters.AddWithValue("@CopyID", txtCopyID.Text);
                cmdInsert.Parameters.AddWithValue("@LoanDate", DateTime.Now);
                cmdInsert.Parameters.AddWithValue("@DueDate", DateTime.Now.AddDays(14));
                cmdInsert.ExecuteNonQuery();

                SqlCommand updateLoanedOut = new SqlCommand("UPDATE Copies SET LoanedOut = 1 WHERE CopyID = @CopyID", conn);
                updateLoanedOut.Parameters.AddWithValue("@CopyID", txtCopyID.Text);
                updateLoanedOut.ExecuteNonQuery();

                MessageBox.Show("✅ Loan confirmed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadLoans();
                GenerateLoanID();
            }
        }

        // ✅ Reset button functionality
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMembID.Clear();
            txtMembType.Clear();
            txtCopyID.Clear();
            txtBS.Clear();
            dgvLoans.DataSource = null;
            btnBorrow.Enabled = false;
            GenerateLoanID();
        }
    }
}

