using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibaryManagementSystem
{
    public partial class frmCopies : Form
    { // Connection string - adjust as needed
        string dbpath = "Data Source=DESKTOP-SFMP7H4\\SQLEXPRESS;Initial Catalog=LibMS;Integrated Security=True";

        public frmCopies()
        {
            InitializeComponent();

            // Wire up events explicitly (if not done via designer)
            this.Load += Copies_Load;
            btnSearch.Click += btnSearch_Click;
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btndelete.Click += btndelete_Click;
        }

        private void Copies_Load(object sender, EventArgs e)
        {
            clearall();
        }

        private void clearall()
        {
            txtTitleID.Clear();
            txtCopyID.Clear();
            txtEQ.Clear();
            txtEC.Clear();
            rbtnBorrow.Checked = false;
            rbtnRefer.Checked = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitleID.Text))
            {
                MessageBox.Show("Please enter TitleID");
                txtTitleID.Focus();
                return;
            }

            try
            {
                using (SqlConnection connect = new SqlConnection(dbpath))
                {
                    connect.Open();

                    // Get Existing Quantity (SUM qty) from BookCopy for TitleID
                    SqlCommand cmdQty = new SqlCommand(
                        "SELECT ISNULL(SUM(qty), 0) FROM BookCopy WHERE TitleID = @TitleID", connect);
                    cmdQty.Parameters.AddWithValue("@TitleID", txtTitleID.Text.Trim());
                    object qtyResult = cmdQty.ExecuteScalar();
                    int existingQuantity = Convert.ToInt32(qtyResult);
                    txtEQ.Text = existingQuantity.ToString();

                    // Get Existing Copies count from Copies table
                    SqlCommand cmdCopies = new SqlCommand(
                        "SELECT COUNT(*) FROM Copies WHERE TitleID = @TitleID", connect);
                    cmdCopies.Parameters.AddWithValue("@TitleID", txtTitleID.Text.Trim());
                    object copiesResult = cmdCopies.ExecuteScalar();
                    int existingCopies = Convert.ToInt32(copiesResult);
                    txtEC.Text = existingCopies.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during Search: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string status = rbtnBorrow.Checked ? "Borrow" : rbtnRefer.Checked ? "Reference" : "";

            if (string.IsNullOrEmpty(status) || string.IsNullOrWhiteSpace(txtCopyID.Text) || string.IsNullOrWhiteSpace(txtTitleID.Text))
            {
                MessageBox.Show("Please fill all fields and select a book type.");
                return;
            }

            try
            {
                using (SqlConnection connect = new SqlConnection(dbpath))
                {
                    connect.Open();

                    // Check TitleID exists
                    SqlCommand checkTitleCmd = new SqlCommand("SELECT COUNT(*) FROM BookInfo WHERE TitleID = @TitleID", connect);
                    checkTitleCmd.Parameters.AddWithValue("@TitleID", txtTitleID.Text.Trim());
                    int titleExists = (int)checkTitleCmd.ExecuteScalar();
                    if (titleExists == 0)
                    {
                        MessageBox.Show("TitleID does not exist in BookInfo.");
                        return;
                    }

                    // Count existing copies
                    SqlCommand countCmd = new SqlCommand("SELECT COUNT(*) FROM Copies WHERE TitleID = @TitleID", connect);
                    countCmd.Parameters.AddWithValue("@TitleID", txtTitleID.Text.Trim());
                    int currentCount = (int)countCmd.ExecuteScalar();

                    if (currentCount >= 10)
                    {
                        MessageBox.Show("Cannot add more than 10 copies for this TitleID.");
                        return;
                    }

                    // Insert new copy
                    SqlCommand add = new SqlCommand("INSERT INTO Copies (TitleID, CopyID, Status, Borrowable, Referenced, LoanedOut, Reserved) VALUES (@TitleID, @CopyID, @Status, @Borrowable, @Referenced, 0, 0)", connect);
                    add.Parameters.AddWithValue("@TitleID", txtTitleID.Text.Trim());
                    add.Parameters.AddWithValue("@CopyID", txtCopyID.Text.Trim());
                    add.Parameters.AddWithValue("@Status", status);
                    add.Parameters.AddWithValue("@Borrowable", rbtnBorrow.Checked ? 1 : 0);
                    add.Parameters.AddWithValue("@Referenced", rbtnRefer.Checked ? 1 : 0);
                    add.ExecuteNonQuery();

                    UpdateCopyStatus(connect);

                    MessageBox.Show("Book Copy Added and Status Updated Successfully.");
                    clearall();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during Add: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCopyID.Text))
            {
                MessageBox.Show("Enter CopyID to edit.");
                return;
            }

            string status = rbtnBorrow.Checked ? "Borrow" : rbtnRefer.Checked ? "Reference" : "";

            try
            {
                using (SqlConnection connect = new SqlConnection(dbpath))
                {
                    connect.Open();

                    SqlCommand update = new SqlCommand("UPDATE Copies SET Status = @Status, Borrowable = @Borrowable, Referenced = @Referenced WHERE CopyID = @CopyID", connect);
                    update.Parameters.AddWithValue("@Status", status);
                    update.Parameters.AddWithValue("@Borrowable", rbtnBorrow.Checked ? 1 : 0);
                    update.Parameters.AddWithValue("@Referenced", rbtnRefer.Checked ? 1 : 0);
                    update.Parameters.AddWithValue("@CopyID", txtCopyID.Text.Trim());

                    int rows = update.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Book Copy Updated.");
                        clearall();
                    }
                    else
                    {
                        MessageBox.Show("CopyID not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during Update: " + ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCopyID.Text))
            {
                MessageBox.Show("Please Enter CopyID");
                txtCopyID.Focus();
                return;
            }

            try
            {
                using (SqlConnection connect = new SqlConnection(dbpath))
                {
                    connect.Open();
                    SqlCommand delete = new SqlCommand("DELETE FROM Copies WHERE CopyID = @CopyID", connect);
                    delete.Parameters.AddWithValue("@CopyID", txtCopyID.Text.Trim());

                    int rows = delete.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        UpdateCopyStatus(connect);
                        MessageBox.Show("Book Copy Deleted.");
                        clearall();
                    }
                    else
                    {
                        MessageBox.Show("CopyID not found or cannot delete.");
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Cannot delete this copy. It may be referenced in Loan or Reservation.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during Delete: " + ex.Message);
            }
        }

        private void UpdateCopyStatus(SqlConnection connection)
        {
            // Set LoanedOut = 1 for Copies currently loaned out
            SqlCommand updateLoanedOut = new SqlCommand(@"
                UPDATE Copies
                SET LoanedOut = 1
                WHERE CopyID IN (SELECT CopyID FROM Loan WHERE Returned = 0);", connection);
            updateLoanedOut.ExecuteNonQuery();

            // Reset LoanedOut = 0 for Copies not loaned
            SqlCommand resetLoanedOut = new SqlCommand(@"
                UPDATE Copies
                SET LoanedOut = 0
                WHERE CopyID NOT IN (SELECT CopyID FROM Loan WHERE Returned = 0);", connection);
            resetLoanedOut.ExecuteNonQuery();

            // Set Reserved = 1 for Copies currently reserved with Pending status
            SqlCommand updateReserved = new SqlCommand(@"
                UPDATE Copies
                SET Reserved = 1
                WHERE CopyID IN (SELECT CopyID FROM Reservation WHERE Status = 'Pending');", connection);
            updateReserved.ExecuteNonQuery();

            // Reset Reserved = 0 for Copies not reserved
            SqlCommand resetReserved = new SqlCommand(@"
                UPDATE Copies
                SET Reserved = 0
                WHERE CopyID NOT IN (SELECT CopyID FROM Reservation WHERE Status = 'Pending');", connection);
            resetReserved.ExecuteNonQuery();
        }
    }
}