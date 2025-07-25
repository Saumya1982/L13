namespace LibaryManagementSystem
{
    partial class frmLoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbloan = new System.Windows.Forms.GroupBox();
            this.txtLID = new System.Windows.Forms.TextBox();
            this.lblLID = new System.Windows.Forms.Label();
            this.dtpLoanDate = new System.Windows.Forms.DateTimePicker();
            this.lblLoanDate = new System.Windows.Forms.Label();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtBS = new System.Windows.Forms.TextBox();
            this.txtMembType = new System.Windows.Forms.TextBox();
            this.txtCopyID = new System.Windows.Forms.TextBox();
            this.txtMembID = new System.Windows.Forms.TextBox();
            this.lblBS = new System.Windows.Forms.Label();
            this.lblMembType = new System.Windows.Forms.Label();
            this.lblCopyID = new System.Windows.Forms.Label();
            this.lblMembID = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbloan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(481, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Loan ";
            // 
            // gbloan
            // 
            this.gbloan.BackColor = System.Drawing.Color.AliceBlue;
            this.gbloan.Controls.Add(this.btnReset);
            this.gbloan.Controls.Add(this.txtLID);
            this.gbloan.Controls.Add(this.lblLID);
            this.gbloan.Controls.Add(this.dtpLoanDate);
            this.gbloan.Controls.Add(this.lblLoanDate);
            this.gbloan.Controls.Add(this.btnBorrow);
            this.gbloan.Controls.Add(this.dgvLoans);
            this.gbloan.Controls.Add(this.btnCheck);
            this.gbloan.Controls.Add(this.txtBS);
            this.gbloan.Controls.Add(this.txtMembType);
            this.gbloan.Controls.Add(this.txtCopyID);
            this.gbloan.Controls.Add(this.txtMembID);
            this.gbloan.Controls.Add(this.lblBS);
            this.gbloan.Controls.Add(this.lblMembType);
            this.gbloan.Controls.Add(this.lblCopyID);
            this.gbloan.Controls.Add(this.lblMembID);
            this.gbloan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbloan.Location = new System.Drawing.Point(80, 76);
            this.gbloan.Name = "gbloan";
            this.gbloan.Size = new System.Drawing.Size(987, 707);
            this.gbloan.TabIndex = 1;
            this.gbloan.TabStop = false;
            this.gbloan.Text = "Loan Books";
            // 
            // txtLID
            // 
            this.txtLID.Location = new System.Drawing.Point(278, 405);
            this.txtLID.Name = "txtLID";
            this.txtLID.Size = new System.Drawing.Size(191, 30);
            this.txtLID.TabIndex = 14;
            // 
            // lblLID
            // 
            this.lblLID.AutoSize = true;
            this.lblLID.Location = new System.Drawing.Point(50, 410);
            this.lblLID.Name = "lblLID";
            this.lblLID.Size = new System.Drawing.Size(94, 25);
            this.lblLID.TabIndex = 13;
            this.lblLID.Text = "Loan ID:";
            // 
            // dtpLoanDate
            // 
            this.dtpLoanDate.Location = new System.Drawing.Point(278, 460);
            this.dtpLoanDate.Name = "dtpLoanDate";
            this.dtpLoanDate.Size = new System.Drawing.Size(389, 30);
            this.dtpLoanDate.TabIndex = 12;
            // 
            // lblLoanDate
            // 
            this.lblLoanDate.AutoSize = true;
            this.lblLoanDate.Location = new System.Drawing.Point(50, 460);
            this.lblLoanDate.Name = "lblLoanDate";
            this.lblLoanDate.Size = new System.Drawing.Size(115, 25);
            this.lblLoanDate.TabIndex = 11;
            this.lblLoanDate.Text = "Loan date:";
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.Color.SpringGreen;
            this.btnBorrow.Location = new System.Drawing.Point(315, 346);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(228, 44);
            this.btnBorrow.TabIndex = 10;
            this.btnBorrow.Text = "Confirm Loan";
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // dgvLoans
            // 
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.Location = new System.Drawing.Point(55, 513);
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.RowHeadersWidth = 51;
            this.dgvLoans.RowTemplate.Height = 24;
            this.dgvLoans.Size = new System.Drawing.Size(875, 117);
            this.dgvLoans.TabIndex = 9;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Cyan;
            this.btnCheck.Location = new System.Drawing.Point(231, 174);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(436, 45);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Text = "Check Member and Book Status";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtBS
            // 
            this.txtBS.Location = new System.Drawing.Point(278, 294);
            this.txtBS.Name = "txtBS";
            this.txtBS.Size = new System.Drawing.Size(307, 30);
            this.txtBS.TabIndex = 7;
            // 
            // txtMembType
            // 
            this.txtMembType.Location = new System.Drawing.Point(278, 247);
            this.txtMembType.Name = "txtMembType";
            this.txtMembType.Size = new System.Drawing.Size(307, 30);
            this.txtMembType.TabIndex = 6;
            // 
            // txtCopyID
            // 
            this.txtCopyID.Location = new System.Drawing.Point(278, 121);
            this.txtCopyID.Name = "txtCopyID";
            this.txtCopyID.Size = new System.Drawing.Size(191, 30);
            this.txtCopyID.TabIndex = 5;
            // 
            // txtMembID
            // 
            this.txtMembID.Location = new System.Drawing.Point(278, 65);
            this.txtMembID.Name = "txtMembID";
            this.txtMembID.Size = new System.Drawing.Size(191, 30);
            this.txtMembID.TabIndex = 4;
            // 
            // lblBS
            // 
            this.lblBS.AutoSize = true;
            this.lblBS.Location = new System.Drawing.Point(50, 297);
            this.lblBS.Name = "lblBS";
            this.lblBS.Size = new System.Drawing.Size(136, 25);
            this.lblBS.TabIndex = 3;
            this.lblBS.Text = "Book Status:";
            // 
            // lblMembType
            // 
            this.lblMembType.AutoSize = true;
            this.lblMembType.Location = new System.Drawing.Point(50, 247);
            this.lblMembType.Name = "lblMembType";
            this.lblMembType.Size = new System.Drawing.Size(152, 25);
            this.lblMembType.TabIndex = 2;
            this.lblMembType.Text = "Member Type:";
            // 
            // lblCopyID
            // 
            this.lblCopyID.AutoSize = true;
            this.lblCopyID.Location = new System.Drawing.Point(50, 124);
            this.lblCopyID.Name = "lblCopyID";
            this.lblCopyID.Size = new System.Drawing.Size(154, 25);
            this.lblCopyID.TabIndex = 1;
            this.lblCopyID.Text = "Enter Copy ID:";
            // 
            // lblMembID
            // 
            this.lblMembID.AutoSize = true;
            this.lblMembID.Location = new System.Drawing.Point(50, 65);
            this.lblMembID.Name = "lblMembID";
            this.lblMembID.Size = new System.Drawing.Size(181, 25);
            this.lblMembID.TabIndex = 0;
            this.lblMembID.Text = "Enter Member ID:";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightSalmon;
            this.btnReset.Location = new System.Drawing.Point(372, 651);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(228, 44);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // frmLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1148, 842);
            this.Controls.Add(this.gbloan);
            this.Controls.Add(this.label1);
            this.Name = "frmLoan";
            this.Text = "Loan";
            this.Load += new System.EventHandler(this.Loan_Load);
            this.gbloan.ResumeLayout(false);
            this.gbloan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbloan;
        private System.Windows.Forms.Label lblBS;
        private System.Windows.Forms.Label lblMembType;
        private System.Windows.Forms.Label lblCopyID;
        private System.Windows.Forms.Label lblMembID;
        private System.Windows.Forms.TextBox txtMembID;
        private System.Windows.Forms.TextBox txtCopyID;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtBS;
        private System.Windows.Forms.TextBox txtMembType;
        private System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Label lblLoanDate;
        private System.Windows.Forms.DateTimePicker dtpLoanDate;
        private System.Windows.Forms.TextBox txtLID;
        private System.Windows.Forms.Label lblLID;
        private System.Windows.Forms.Button btnReset;
    }
}