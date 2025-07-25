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
    public partial class frmReservation : Form
    {
        string dbpath = "Data Source=DESKTOP-SFMP7H4\\SQLEXPRESS;Initial Catalog=LibMS;Integrated Security=True";

        public frmReservation()
        {
            InitializeComponent();
        }

        private void frmReservation_Load(object sender, EventArgs e)
        {
            LoadReservations(); // ✅ Load existing reservation data
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(dbpath))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Reservation (MembID, TitleID, CopyID, ReserveDate) VALUES (@MembID, @TitleID, @CopyID, @ReserveDate)", conn);
                cmd.Parameters.AddWithValue("@MembID", txtMembID.Text);
                cmd.Parameters.AddWithValue("@TitleID", txtTitleID.Text);
                cmd.Parameters.AddWithValue("@CopyID", txtCopyID.Text);
                cmd.Parameters.AddWithValue("@ReserveDate", DateTime.Now); // Date + Time

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    SqlCommand updateCmd = new SqlCommand("UPDATE Copies SET Reserved = 1 WHERE CopyID = @CopyID", conn);
                    updateCmd.Parameters.AddWithValue("@CopyID", txtCopyID.Text);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("✅ Reservation added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadReservations();    // Refresh reservation list
                    ResetFields();         // Clear input fields
                }
                else
                {
                    MessageBox.Show("❌ Failed to add reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadReservations()
        {
            using (SqlConnection conn = new SqlConnection(dbpath))
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT ReservationID, MembID, TitleID, CopyID, ReserveDate FROM Reservation ORDER BY ReserveDate ASC", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReservations.DataSource = dt;

                dgvReservations.Columns["ReserveDate"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
                dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void ResetFields()
        {
            txtMembID.Clear();
            txtTitleID.Clear();
            txtCopyID.Clear();
            txtMembID.Focus();
        }
    }
}