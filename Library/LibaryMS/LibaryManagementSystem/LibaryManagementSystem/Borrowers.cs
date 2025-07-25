using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace LibaryManagementSystem
{
    public partial class frmBorrowers : Form
    {
        public frmBorrowers()
        {
            InitializeComponent();
        }
        string dbpath = "Data Source=DESKTOP-SFMP7H4\\SQLEXPRESS;Initial Catalog=LibMS;Integrated Security=True";

        private void frmBorrowers_Load(object sender, EventArgs e)
        {
            LoadLastMemberID();

            cmbGender.Items.Clear();
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.SelectedIndex = -1;
        }

        private void clearAll()
        {
            txtMembID.Clear();
            txtMembName.Clear();
            txtNIC.Clear();
            txtAddress.Clear();
            rbtnRegMemb.Checked = false;
            rbtnRegVisi.Checked = false;
            dtpJD.Enabled = true;
            dtpJD.Value = DateTime.Now;
            LoadLastMemberID();
        }

        private void LoadLastMemberID()
        {
            using (SqlConnection connect = new SqlConnection(dbpath))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 MembID FROM Borrower ORDER BY MembID DESC", connect);
                object result = cmd.ExecuteScalar();
                txtLMID.Text = result != null ? result.ToString() : "None";
                connect.Close();
            }
        }

      
        private string getMemberType()
        {
            if (rbtnRegMemb.Checked)
                return "Registered Member";
            else if (rbtnRegVisi.Checked)
                return "Registered Visitor";
            else
                return ""; // No selection
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMembID.Text.Trim() == "")
            {
                MessageBox.Show("Enter Member ID manually.");
                return;
            }

            SqlConnection connect = new SqlConnection(dbpath);
            connect.Open();

            SqlCommand add = new SqlCommand(@"INSERT INTO Borrower 
                (MembID, MembName, Gender, NIC, Addres, MembType, JoinDate) 
                VALUES 
                (@MembID, @MembName, @Gender, @NIC, @Addres, @MembType ,@JoinDate)", connect);

            add.Parameters.AddWithValue("@MembID", txtMembID.Text);
            add.Parameters.AddWithValue("@MembName", txtMembName.Text);
            add.Parameters.AddWithValue("@Gender", cmbGender.Text);
            add.Parameters.AddWithValue("@NIC", txtNIC.Text);
            add.Parameters.AddWithValue("@Addres", txtAddress.Text);
            add.Parameters.AddWithValue("@MembType", getMemberType());
            add.Parameters.AddWithValue("@JoinDate", dtpJD.Value);

            add.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Member Added Successfully.");
            clearAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(dbpath);
            connect.Open();

            SqlCommand update = new SqlCommand(@"UPDATE Borrower SET 
                MembName=@MembName, Gender=@Gender, NIC=@NIC, Addres=@Addres, 
                MembType=@MembType, JoinDate=@JoinDate 
                WHERE MembID=@MembID", connect);

            update.Parameters.AddWithValue("@MembID", txtMembID.Text);
            update.Parameters.AddWithValue("@MembName", txtMembName.Text);
            update.Parameters.AddWithValue("@Gender", cmbGender.Text);
            update.Parameters.AddWithValue("@NIC", txtNIC.Text);
            update.Parameters.AddWithValue("@Addres", txtAddress.Text);
            update.Parameters.AddWithValue("@MembType", getMemberType());
            update.Parameters.AddWithValue("@JoinDate", dtpJD.Value);

            update.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Member Updated Successfully.");
            clearAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(dbpath);
            connect.Open();

            SqlCommand search = new SqlCommand("SELECT * FROM Borrower WHERE MembID = @MembID", connect);
            search.Parameters.AddWithValue("@MembID", txtMembID.Text);
            SqlDataReader reader = search.ExecuteReader();

            if (reader.Read())
            {
                txtMembName.Text = reader["MembName"].ToString();
                txtNIC.Text = reader["NIC"].ToString();
                txtAddress.Text = reader["Addres"].ToString();

                string gender = reader["Gender"].ToString();
                
                string type = reader["MembType"].ToString();
                rbtnRegMemb.Checked = type == "Registered Member";
                rbtnRegVisi.Checked = type == "Registered Visitor";

                dtpJD.Value = Convert.ToDateTime(reader["JoinDate"]);
            }
            else
            {
                MessageBox.Show("Member not found.");
            }

            connect.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMembID.Text == "")
            {
                MessageBox.Show("Enter Member ID to delete.");
                txtMembID.Focus();
                return;
            }

            SqlConnection connect = new SqlConnection(dbpath);
            connect.Open();

            SqlCommand delete = new SqlCommand("DELETE FROM Borrower WHERE MembID=@MembID", connect);
            delete.Parameters.AddWithValue("@MembID", txtMembID.Text);
            delete.ExecuteNonQuery();

            connect.Close();

            MessageBox.Show("Member Deleted.");
            clearAll();
        }

        // Optional event handlers (avoid accidental logic here)
        private void rbtnMale_CheckedChanged(object sender, EventArgs e) { }
        private void rbtnFemale_CheckedChanged(object sender, EventArgs e) { }
        private void rbtnRegMemb_CheckedChanged(object sender, EventArgs e) { }
        private void rbtnRegVisi_CheckedChanged(object sender, EventArgs e) { }
        private void dtpJD_ValueChanged(object sender, EventArgs e) { }
        private void txtMembID_TextChanged(object sender, EventArgs e) { }
        private void txtMembName_TextChanged(object sender, EventArgs e) { }
        private void txtNIC_TextChanged(object sender, EventArgs e) { }
        private void txtAddress_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}
