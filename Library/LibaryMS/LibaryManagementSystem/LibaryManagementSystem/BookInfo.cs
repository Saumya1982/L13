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
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();
        }

        string classification;

        private void clearall()
        {
            txtTitleID.Clear();
            txtBookName.Clear();
            txtAuthor.Clear();
            txtPublisher.Clear();
            rbtnBorrow.Checked = false;
            rbtnRefer.Checked = false;
        }

        private string dbpath = "Data Source=DESKTOP-SFMP7H4\\SQLEXPRESS;Initial Catalog=LibMS;Integrated Security=True";

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rbtnBorrow.Checked)
                classification = "Borrow";
            else if (rbtnRefer.Checked)
                classification = "Reference";
            else
                classification = "";

            using (SqlConnection connect = new SqlConnection(dbpath))
            {
                connect.Open();

                // Insert into BookInfo
                SqlCommand add = new SqlCommand("INSERT INTO BookInfo VALUES(@TitleID, @BookName, @Author, @Publisher, @Classifi)", connect);
                add.Parameters.AddWithValue("@TitleID", txtTitleID.Text);
                add.Parameters.AddWithValue("@BookName", txtBookName.Text);
                add.Parameters.AddWithValue("@Author", txtAuthor.Text);
                add.Parameters.AddWithValue("@Publisher", txtPublisher.Text);
                add.Parameters.AddWithValue("@Classifi", classification);
                add.ExecuteNonQuery();

                // Insert into BookCopy
                SqlCommand copies = new SqlCommand("INSERT INTO BookCopy VALUES(@TitleID, 0)", connect);
                copies.Parameters.AddWithValue("@TitleID", txtTitleID.Text);
                copies.ExecuteNonQuery();

                MessageBox.Show("Book Added Successfully.");
                clearall();
                LoadLastTitleID(); // Refresh txtLTID
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (rbtnBorrow.Checked)
                classification = "Borrow";
            else if (rbtnRefer.Checked)
                classification = "Reference";
            else
                classification = "";

            using (SqlConnection connect = new SqlConnection(dbpath))
            {
                connect.Open();
                SqlCommand update = new SqlCommand("UPDATE BookInfo SET BookName=@BookName, Author=@Author, Publisher=@Publisher, Classifi=@Classifi WHERE TitleID=@TitleID", connect);
                update.Parameters.AddWithValue("@BookName", txtBookName.Text);
                update.Parameters.AddWithValue("@Author", txtAuthor.Text);
                update.Parameters.AddWithValue("@Publisher", txtPublisher.Text);
                update.Parameters.AddWithValue("@Classifi", classification);
                update.Parameters.AddWithValue("@TitleID", txtTitleID.Text);
                update.ExecuteNonQuery();

                MessageBox.Show("Book Updated Successfully.");
                clearall();
                LoadLastTitleID(); // Refresh txtLTID
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitleID.Text))
            {
                MessageBox.Show("Please enter TitleID");
                txtTitleID.Focus();
                return;
            }

            using (SqlConnection connect = new SqlConnection(dbpath))
            {
                try
                {
                    connect.Open();

                    // Delete from BookCopy
                    SqlCommand deleteCopies = new SqlCommand("DELETE FROM BookCopy WHERE TitleID = @TitleID", connect);
                    deleteCopies.Parameters.AddWithValue("@TitleID", txtTitleID.Text);
                    deleteCopies.ExecuteNonQuery();

                    // Delete from BookInfo
                    SqlCommand deleteBook = new SqlCommand("DELETE FROM BookInfo WHERE TitleID = @TitleID", connect);
                    deleteBook.Parameters.AddWithValue("@TitleID", txtTitleID.Text);
                    int rowsAffected = deleteBook.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book removed successfully.");
                        clearall();
                        LoadLastTitleID(); // Refresh txtLTID
                    }
                    else
                    {
                        MessageBox.Show("No book found with the given TitleID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            LoadLastTitleID();
        }

        private void LoadLastTitleID()
        {
            using (SqlConnection connect = new SqlConnection(dbpath))
            {
                try
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 TitleID FROM BookInfo ORDER BY TitleID DESC", connect);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        txtLTID.Text = result.ToString();
                    else
                        txtLTID.Text = "None";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading last TitleID: " + ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitleID.Text))
            {
                MessageBox.Show("Please enter a Title ID to search.");
                txtTitleID.Focus();
                return;
            }

            using (SqlConnection connect = new SqlConnection(dbpath))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM BookInfo WHERE TitleID = @TitleID", connect);
                cmd.Parameters.AddWithValue("@TitleID", txtTitleID.Text.Trim());

                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtBookName.Text = reader["BookName"].ToString();
                    txtAuthor.Text = reader["Author"].ToString();
                    txtPublisher.Text = reader["Publisher"].ToString();
                    string classifi = reader["Classifi"].ToString();

                    rbtnBorrow.Checked = (classifi == "Borrow");
                    rbtnRefer.Checked = (classifi == "Reference");
                }
                else
                {
                    MessageBox.Show("Book not found.");
                    clearall();
                }

                connect.Close();
            }
        }
    }
}
