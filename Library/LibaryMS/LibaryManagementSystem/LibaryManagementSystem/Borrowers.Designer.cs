namespace LibaryManagementSystem
{
    partial class frmBorrowers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbBorrowerInfo = new System.Windows.Forms.GroupBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtLMID = new System.Windows.Forms.TextBox();
            this.lblLMID = new System.Windows.Forms.Label();
            this.dtpJD = new System.Windows.Forms.DateTimePicker();
            this.lblJD = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbtnRegVisi = new System.Windows.Forms.RadioButton();
            this.rbtnRegMemb = new System.Windows.Forms.RadioButton();
            this.lblMembType = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.lblNIC = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtMembName = new System.Windows.Forms.TextBox();
            this.lblMembName = new System.Windows.Forms.Label();
            this.txtMembID = new System.Windows.Forms.TextBox();
            this.lblMembID = new System.Windows.Forms.Label();
            this.lblBorrower = new System.Windows.Forms.Label();
            this.grbBorrowerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBorrowerInfo
            // 
            this.grbBorrowerInfo.BackColor = System.Drawing.Color.AliceBlue;
            this.grbBorrowerInfo.Controls.Add(this.cmbGender);
            this.grbBorrowerInfo.Controls.Add(this.txtLMID);
            this.grbBorrowerInfo.Controls.Add(this.lblLMID);
            this.grbBorrowerInfo.Controls.Add(this.dtpJD);
            this.grbBorrowerInfo.Controls.Add(this.lblJD);
            this.grbBorrowerInfo.Controls.Add(this.txtAddress);
            this.grbBorrowerInfo.Controls.Add(this.lblAddress);
            this.grbBorrowerInfo.Controls.Add(this.btnDelete);
            this.grbBorrowerInfo.Controls.Add(this.btnSearch);
            this.grbBorrowerInfo.Controls.Add(this.btnUpdate);
            this.grbBorrowerInfo.Controls.Add(this.btnAdd);
            this.grbBorrowerInfo.Controls.Add(this.rbtnRegVisi);
            this.grbBorrowerInfo.Controls.Add(this.rbtnRegMemb);
            this.grbBorrowerInfo.Controls.Add(this.lblMembType);
            this.grbBorrowerInfo.Controls.Add(this.txtNIC);
            this.grbBorrowerInfo.Controls.Add(this.lblNIC);
            this.grbBorrowerInfo.Controls.Add(this.lblGender);
            this.grbBorrowerInfo.Controls.Add(this.txtMembName);
            this.grbBorrowerInfo.Controls.Add(this.lblMembName);
            this.grbBorrowerInfo.Controls.Add(this.txtMembID);
            this.grbBorrowerInfo.Controls.Add(this.lblMembID);
            this.grbBorrowerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBorrowerInfo.Location = new System.Drawing.Point(104, 94);
            this.grbBorrowerInfo.Name = "grbBorrowerInfo";
            this.grbBorrowerInfo.Size = new System.Drawing.Size(578, 605);
            this.grbBorrowerInfo.TabIndex = 1;
            this.grbBorrowerInfo.TabStop = false;
            this.grbBorrowerInfo.Text = "Borrower Details:";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(306, 206);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(191, 33);
            this.cmbGender.TabIndex = 26;
            // 
            // txtLMID
            // 
            this.txtLMID.Location = new System.Drawing.Point(306, 47);
            this.txtLMID.Name = "txtLMID";
            this.txtLMID.Size = new System.Drawing.Size(213, 30);
            this.txtLMID.TabIndex = 25;
            // 
            // lblLMID
            // 
            this.lblLMID.AutoSize = true;
            this.lblLMID.Location = new System.Drawing.Point(90, 47);
            this.lblLMID.Name = "lblLMID";
            this.lblLMID.Size = new System.Drawing.Size(171, 25);
            this.lblLMID.TabIndex = 24;
            this.lblLMID.Text = "Last Member ID:";
            // 
            // dtpJD
            // 
            this.dtpJD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJD.Location = new System.Drawing.Point(306, 458);
            this.dtpJD.Name = "dtpJD";
            this.dtpJD.Size = new System.Drawing.Size(195, 22);
            this.dtpJD.TabIndex = 23;
            this.dtpJD.ValueChanged += new System.EventHandler(this.dtpJD_ValueChanged);
            // 
            // lblJD
            // 
            this.lblJD.AutoSize = true;
            this.lblJD.Location = new System.Drawing.Point(78, 455);
            this.lblJD.Name = "lblJD";
            this.lblJD.Size = new System.Drawing.Size(104, 25);
            this.lblJD.TabIndex = 22;
            this.lblJD.Text = "Join Date";
            this.lblJD.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(306, 304);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(213, 30);
            this.txtAddress.TabIndex = 19;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(83, 307);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(99, 25);
            this.lblAddress.TabIndex = 18;
            this.lblAddress.Text = "Address:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(442, 528);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 40);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gold;
            this.btnSearch.Location = new System.Drawing.Point(306, 528);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 40);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SpringGreen;
            this.btnUpdate.Location = new System.Drawing.Point(161, 528);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 40);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Aqua;
            this.btnAdd.Location = new System.Drawing.Point(21, 528);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 40);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbtnRegVisi
            // 
            this.rbtnRegVisi.AutoSize = true;
            this.rbtnRegVisi.Location = new System.Drawing.Point(306, 403);
            this.rbtnRegVisi.Name = "rbtnRegVisi";
            this.rbtnRegVisi.Size = new System.Drawing.Size(203, 29);
            this.rbtnRegVisi.TabIndex = 13;
            this.rbtnRegVisi.TabStop = true;
            this.rbtnRegVisi.Text = "Registered Visiter";
            this.rbtnRegVisi.UseVisualStyleBackColor = true;
            this.rbtnRegVisi.CheckedChanged += new System.EventHandler(this.rbtnRegVisi_CheckedChanged);
            // 
            // rbtnRegMemb
            // 
            this.rbtnRegMemb.AutoSize = true;
            this.rbtnRegMemb.Location = new System.Drawing.Point(306, 368);
            this.rbtnRegMemb.Name = "rbtnRegMemb";
            this.rbtnRegMemb.Size = new System.Drawing.Size(220, 29);
            this.rbtnRegMemb.TabIndex = 12;
            this.rbtnRegMemb.TabStop = true;
            this.rbtnRegMemb.Text = "Registered Member";
            this.rbtnRegMemb.UseVisualStyleBackColor = true;
            this.rbtnRegMemb.CheckedChanged += new System.EventHandler(this.rbtnRegMemb_CheckedChanged);
            // 
            // lblMembType
            // 
            this.lblMembType.AutoSize = true;
            this.lblMembType.Location = new System.Drawing.Point(78, 385);
            this.lblMembType.Name = "lblMembType";
            this.lblMembType.Size = new System.Drawing.Size(152, 25);
            this.lblMembType.TabIndex = 8;
            this.lblMembType.Text = "Member Type:";
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(306, 252);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(213, 30);
            this.txtNIC.TabIndex = 7;
            this.txtNIC.TextChanged += new System.EventHandler(this.txtNIC_TextChanged);
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Location = new System.Drawing.Point(90, 257);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(56, 25);
            this.lblNIC.TabIndex = 6;
            this.lblNIC.Text = "NIC:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(90, 209);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(90, 25);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender:";
            // 
            // txtMembName
            // 
            this.txtMembName.Location = new System.Drawing.Point(306, 153);
            this.txtMembName.Name = "txtMembName";
            this.txtMembName.Size = new System.Drawing.Size(213, 30);
            this.txtMembName.TabIndex = 3;
            this.txtMembName.TextChanged += new System.EventHandler(this.txtMembName_TextChanged);
            // 
            // lblMembName
            // 
            this.lblMembName.AutoSize = true;
            this.lblMembName.Location = new System.Drawing.Point(90, 158);
            this.lblMembName.Name = "lblMembName";
            this.lblMembName.Size = new System.Drawing.Size(159, 25);
            this.lblMembName.TabIndex = 2;
            this.lblMembName.Text = "Member Name:";
            // 
            // txtMembID
            // 
            this.txtMembID.Location = new System.Drawing.Point(306, 105);
            this.txtMembID.Name = "txtMembID";
            this.txtMembID.Size = new System.Drawing.Size(213, 30);
            this.txtMembID.TabIndex = 1;
            this.txtMembID.TextChanged += new System.EventHandler(this.txtMembID_TextChanged);
            // 
            // lblMembID
            // 
            this.lblMembID.AutoSize = true;
            this.lblMembID.Location = new System.Drawing.Point(90, 105);
            this.lblMembID.Name = "lblMembID";
            this.lblMembID.Size = new System.Drawing.Size(172, 25);
            this.lblMembID.TabIndex = 0;
            this.lblMembID.Text = "New Member ID:";
            // 
            // lblBorrower
            // 
            this.lblBorrower.AutoSize = true;
            this.lblBorrower.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrower.ForeColor = System.Drawing.Color.Blue;
            this.lblBorrower.Location = new System.Drawing.Point(119, 23);
            this.lblBorrower.Name = "lblBorrower";
            this.lblBorrower.Size = new System.Drawing.Size(559, 32);
            this.lblBorrower.TabIndex = 2;
            this.lblBorrower.Text = "Borrowers Information - Sarasavi Library";
            // 
            // frmBorrowers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(792, 768);
            this.Controls.Add(this.lblBorrower);
            this.Controls.Add(this.grbBorrowerInfo);
            this.Name = "frmBorrowers";
            this.Text = "Borrowers";
            this.Load += new System.EventHandler(this.frmBorrowers_Load);
            this.grbBorrowerInfo.ResumeLayout(false);
            this.grbBorrowerInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBorrowerInfo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rbtnRegVisi;
        private System.Windows.Forms.RadioButton rbtnRegMemb;
        private System.Windows.Forms.Label lblMembType;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtMembName;
        private System.Windows.Forms.Label lblMembName;
        private System.Windows.Forms.TextBox txtMembID;
        private System.Windows.Forms.Label lblMembID;
        private System.Windows.Forms.Label lblBorrower;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblJD;
        private System.Windows.Forms.DateTimePicker dtpJD;
        private System.Windows.Forms.TextBox txtLMID;
        private System.Windows.Forms.Label lblLMID;
        private System.Windows.Forms.ComboBox cmbGender;
    }
}