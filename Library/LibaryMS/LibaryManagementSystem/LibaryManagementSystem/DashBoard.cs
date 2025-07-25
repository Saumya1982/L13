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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            string dbpath;
            dbpath = "Data Source=DESKTOP-SFMP7H4\\SQLEXPRESS;Initial Catalog=LibMS;Integrated Security=True";
            SqlConnection connect = new SqlConnection(dbpath);
            connect.Open();
            SqlCommand getcount = new SqlCommand("select count (TitleID) from BookInfo", connect);
            int count = Convert.ToInt32(getcount.ExecuteScalar());
            lblBookCount.Text = count.ToString();
            connect.Close();

        }

        private void lblBorrowableNo_Click(object sender, EventArgs e)
        {
           
        }

        private void lblBorrow_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            string dbpath;
            dbpath = "Data Source=DESKTOP-SFMP7H4\\SQLEXPRESS;Initial Catalog=LibMS;Integrated Security=True";
            SqlConnection connect = new SqlConnection(dbpath);
            connect.Open();
            SqlCommand getcount = new SqlCommand("select count (TitleID) from BookInfo where Classifi='Borrow'", connect);
            int count = Convert.ToInt32(getcount.ExecuteScalar());
            lblBorrowableNo.Text = count.ToString();
            connect.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            string dbpath;
            dbpath = "Data Source=DESKTOP-SFMP7H4\\SQLEXPRESS;Initial Catalog=LibMS;Integrated Security=True";
            SqlConnection connect = new SqlConnection(dbpath);
            connect.Open();
            SqlCommand getcount = new SqlCommand("select count (TitleID) from BookInfo where Classifi='Reference'", connect);
            int count = Convert.ToInt32(getcount.ExecuteScalar());
            lblReferenceNo.Text = count.ToString();
            connect.Close();
        }

        private void bookInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBook ff1 = new frmBook();
            ff1.ShowDialog();

        }

        private void copiesUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookCopies copies = new frmBookCopies();
            copies.ShowDialog();
        }

        private void borrowerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrowers borrower = new frmBorrowers();   
            borrower.ShowDialog();
        }

        private void loanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoan loan = new frmLoan();
            loan.ShowDialog();
        }

        private void copiesInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCopies copies = new frmCopies();
            copies.ShowDialog();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReturn Return = new frmReturn();
            Return.ShowDialog();
        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservation Reservation = new frmReservation();  
            Reservation.ShowDialog();
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            frmInquiry inquiryForm = new frmInquiry();
            inquiryForm.Show();
        }
    }
}
