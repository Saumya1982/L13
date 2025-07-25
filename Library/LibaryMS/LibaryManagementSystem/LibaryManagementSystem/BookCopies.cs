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
    public partial class frmBookCopies : Form
    {
        public frmBookCopies()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAB_Click(object sender, EventArgs e)
        {
            string dbpath;
            dbpath = "Data Source=DESKTOP-SFMP7H4\\SQLEXPRESS;Initial Catalog=LibMS;Integrated Security=True";
            SqlConnection connect = new SqlConnection(dbpath);
            connect.Open();
            SqlCommand getcopies = new SqlCommand("select * from BookCopy where TitleID='" + txtTitleID.Text + "'", connect);
            SqlDataReader dr = getcopies.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                SqlCommand updatecopies = new SqlCommand("update BookCopy set qty="+txtqty.Text+" where TitleID = '" + txtTitleID.Text + "'" , connect);
                updatecopies.ExecuteNonQuery();
                MessageBox.Show(txtTitleID.Text +"Book Stock is Updated.");
            }
            else
            {
                MessageBox.Show("Book Not Available.");
            }
            connect.Close();
            MessageBox.Show("Book Copies Added.");
        }

        private void frmBookCopies_Load(object sender, EventArgs e)
        {

        }
    }
}
