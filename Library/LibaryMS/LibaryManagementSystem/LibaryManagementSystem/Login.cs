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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUN.Text.Trim();
            string password = txtPW.Text.Trim();

            string dbpath = "Data Source=DESKTOP-SFMP7H4\\SQLEXPRESS;Initial Catalog=LibMS;Integrated Security=True";
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";

            using (SqlConnection con = new SqlConnection(dbpath))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password); // Consider hashing for real use

                con.Open();
                int count = (int)cmd.ExecuteScalar();
                con.Close();

                if (count > 0)
                {
                    DashBoard dash = new DashBoard();
                    dash.Show();
                    this.Hide();

                    // Redirect to another form or dashboard
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password.");
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // This will close the entire application
        }
    }
}

    
    

