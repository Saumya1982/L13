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
        private void clearall()
        {
            txtTitleID.Clear();
            txtBookName.Clear();
            txtAuthor.Clear();
            txtPublisher.Clear();
            rbtnBorrow.Checked = false;
            rbtnRefer.Checked = false;

        }

        string classification;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string dbpath;
            dbpath = "Data Source=DESKTOP-SFMP7H4\\SQLEXPRESS;Initial Catalog=LibMS;Integrated Security=True";
            if (rbtnBorrow.Checked == true)
            {
                classification = "Borrow";
            }
            if (rbtnRefer.Checked == true)
            {
                classification = "Reference";
            }
            SqlConnection connect=new SqlConnection(dbpath);
            connect.Open();
            SqlCommand add = new SqlCommand("insert into BookInfo values('"+txtTitleID.Text+"','"+txtBookName.Text+"','"+txtAuthor.Text+"','"+txtPublisher.Text+"','"+classification+"')",connect);
            add.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Book Added Successfuly.");
           

            connect.Open();
            SqlCommand copies = new SqlCommand("insert into BookCopy values('" + txtTitleID.Text + "'," + 0 + ")", connect);
            copies.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Book Stock Updated.");
            clearall();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string dbpath;
            dbpath = "Data Source=DESKTOP-SFMP7H4\\SQLEXPRESS;Initial Catalog=LibMS;Integrated Security=True";
            if (rbtnBorrow.Checked == true)
            {
                classification = "Borrow";
            }
            if (rbtnRefer.Checked == true)
            {
                classification = "Reference";
            }
            SqlConnection connect = new SqlConnection(dbpath);
            connect.Open();
            SqlCommand update = new SqlCommand("Update BookInfo set BookName='" + txtBookName.Text + "',Author='"+txtAuthor.Text+ "',Publisher='"+txtPublisher.Text+ "',Classifi='"+classification+"' where TitleID='" + txtTitleID.Text+"'", connect);
            update.ExecuteNonQuery();
            connect.Close() ;
            MessageBox.Show("Book Updated Successfuly.");
            clearall();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitleID.Text))
            {
                MessageBox.Show("Please enter TitleID");
                txtTitleID.Focus();
                return;
            }

            string dbpath = "Data Source=DESKTOP-SFMP7H4\\SQLEXPRESS;Initial Catalog=LibMS;Integrated Security=True";
            using (SqlConnection connect = new SqlConnection(dbpath))
            {
                try
                {
                    connect.Open();

                    // Step 1: Delete from BookCopy first (dependent table)
                    SqlCommand deleteCopies = new SqlCommand("DELETE FROM BookCopy WHERE TitleID = @TitleID", connect);
                    deleteCopies.Parameters.AddWithValue("@TitleID", txtTitleID.Text);
                    deleteCopies.ExecuteNonQuery();

                    // Step 2: Delete from BookInfo
                    SqlCommand deleteBook = new SqlCommand("DELETE FROM BookInfo WHERE TitleID = @TitleID", connect);
                    deleteBook.Parameters.AddWithValue("@TitleID", txtTitleID.Text);
                    int rowsAffected = deleteBook.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book removed successfully.");
                        txtTitleID.Clear();
                        txtBookName.Clear();
                        txtAuthor.Clear();
                        txtPublisher.Clear();
                        rbtnBorrow.Checked = false;
                        rbtnRefer.Checked = false;
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

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitleID.Text))
            {
                MessageBox.Show("Please enter a Title ID to search.");
                txtTitleID.Focus();
                return;
            }

            string dbpath = "Data Source=DESKTOP-SFMP7H4\\SQLEXPRESS;Initial Catalog=LibMS;Integrated Security=True";
            using (SqlConnection connect = new SqlConnection(dbpath))
            {
                string query = "SELECT * FROM BookInfo WHERE TitleID = @TitleID";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@TitleID", txtTitleID.Text.Trim());

                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtBookName.Text = reader["BookName"].ToString();
                    txtAuthor.Text = reader["Author"].ToString();
                    txtPublisher.Text = reader["Publisher"].ToString();
                    string classifi = reader["Classifi"].ToString();

                    if (classifi == "Borrow")
                        rbtnBorrow.Checked = true;
                    else if (classifi == "Reference")
                        rbtnRefer.Checked = true;
                    else
                    {
                        rbtnBorrow.Checked = false;
                        rbtnRefer.Checked = false;
                    }
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
