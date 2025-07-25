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
    public partial class frmInquiry : Form
    {
        public frmInquiry()
        {
            InitializeComponent();
            this.btnSearch.Click += new EventHandler(this.btnSearch_Click);
            this.btnReset.Click += new EventHandler(this.btnReset_Click);
            this.Load += new EventHandler(this.frmInquiry_Load);
        }

        string dbpath = "Data Source=DESKTOP-SFMP7H4\\SQLEXPRESS;Initial Catalog=LibMS;Integrated Security=True";

        private void frmInquiry_Load(object sender, EventArgs e)
        {
            // Optional: auto-load all data
            // LoadInquiryData();
        }

        private void LoadInquiryData()
        {
            using (SqlConnection conn = new SqlConnection(dbpath))
            {
                conn.Open();

                StringBuilder queryBuilder = new StringBuilder(@"
                    SELECT 
                        T.TitleID,
                        C.CopyID,
                        T.BookName,
                        T.Author,
                        CASE 
                            WHEN C.LoanedOut = 0 AND C.Reserved = 0 THEN 'Yes'
                            ELSE 'No'
                        END AS Available,
                        CASE WHEN C.Borrowable = 1 THEN 'Yes' ELSE 'No' END AS Borrowable,
                        CASE WHEN C.Referenced = 1 THEN 'Yes' ELSE 'No' END AS Referenced,
                        CASE WHEN C.LoanedOut = 1 THEN 'Yes' ELSE 'No' END AS LoanedOut,
                        CASE WHEN C.Reserved = 1 THEN 'Yes' ELSE 'No' END AS Reserved
                    FROM BookInfo T
                    INNER JOIN Copies C ON T.TitleID = C.TitleID
                    WHERE 1 = 1
                ");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                // Append filters dynamically
                if (!string.IsNullOrWhiteSpace(txtTitleID.Text))
                {
                    queryBuilder.Append(" AND T.TitleID = @TitleID");
                    cmd.Parameters.AddWithValue("@TitleID", txtTitleID.Text.Trim());
                }

                if (!string.IsNullOrWhiteSpace(txtCopyID.Text))
                {
                    queryBuilder.Append(" AND C.CopyID = @CopyID");
                    cmd.Parameters.AddWithValue("@CopyID", txtCopyID.Text.Trim());
                }

                if (!string.IsNullOrWhiteSpace(txtBookName.Text))
                {
                    queryBuilder.Append(" AND LOWER(T.BookName) LIKE @BookName");
                    cmd.Parameters.AddWithValue("@BookName", "%" + txtBookName.Text.Trim().ToLower() + "%");
                }

                if (!string.IsNullOrWhiteSpace(txtAuthor.Text))
                {
                    queryBuilder.Append(" AND LOWER(T.Author) LIKE @Author");
                    cmd.Parameters.AddWithValue("@Author", "%" + txtAuthor.Text.Trim().ToLower() + "%");
                }

                cmd.CommandText = queryBuilder.ToString();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvResults.DataSource = dt;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadInquiryData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTitleID.Clear();
            txtCopyID.Clear();
            txtBookName.Clear();
            txtAuthor.Clear();

            dgvResults.DataSource = null;
            dgvResults.Rows.Clear();
        }
    }
}