namespace LibaryManagementSystem
{
    partial class frmReturn
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
            this.gbBR = new System.Windows.Forms.GroupBox();
            this.dgvLoanInfo = new System.Windows.Forms.DataGridView();
            this.btnRB = new System.Windows.Forms.Button();
            this.btnCL = new System.Windows.Forms.Button();
            this.txtReturnDate = new System.Windows.Forms.TextBox();
            this.txtCopyID = new System.Windows.Forms.TextBox();
            this.txtMembID = new System.Windows.Forms.TextBox();
            this.lblRD = new System.Windows.Forms.Label();
            this.lblCopyID = new System.Windows.Forms.Label();
            this.lblMembID = new System.Windows.Forms.Label();
            this.lblReturn = new System.Windows.Forms.Label();
            this.gbBR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBR
            // 
            this.gbBR.BackColor = System.Drawing.Color.AliceBlue;
            this.gbBR.Controls.Add(this.dgvLoanInfo);
            this.gbBR.Controls.Add(this.btnRB);
            this.gbBR.Controls.Add(this.btnCL);
            this.gbBR.Controls.Add(this.txtReturnDate);
            this.gbBR.Controls.Add(this.txtCopyID);
            this.gbBR.Controls.Add(this.txtMembID);
            this.gbBR.Controls.Add(this.lblRD);
            this.gbBR.Controls.Add(this.lblCopyID);
            this.gbBR.Controls.Add(this.lblMembID);
            this.gbBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBR.Location = new System.Drawing.Point(59, 74);
            this.gbBR.Name = "gbBR";
            this.gbBR.Size = new System.Drawing.Size(1058, 620);
            this.gbBR.TabIndex = 0;
            this.gbBR.TabStop = false;
            this.gbBR.Text = "Book Return";
            // 
            // dgvLoanInfo
            // 
            this.dgvLoanInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanInfo.Location = new System.Drawing.Point(29, 416);
            this.dgvLoanInfo.Name = "dgvLoanInfo";
            this.dgvLoanInfo.RowHeadersWidth = 51;
            this.dgvLoanInfo.RowTemplate.Height = 24;
            this.dgvLoanInfo.Size = new System.Drawing.Size(996, 164);
            this.dgvLoanInfo.TabIndex = 9;
            // 
            // btnRB
            // 
            this.btnRB.BackColor = System.Drawing.Color.Chartreuse;
            this.btnRB.Location = new System.Drawing.Point(394, 342);
            this.btnRB.Name = "btnRB";
            this.btnRB.Size = new System.Drawing.Size(172, 39);
            this.btnRB.TabIndex = 7;
            this.btnRB.Text = "Return Book ";
            this.btnRB.UseVisualStyleBackColor = false;
            this.btnRB.Click += new System.EventHandler(this.btnRB_Click);
            // 
            // btnCL
            // 
            this.btnCL.BackColor = System.Drawing.Color.PowderBlue;
            this.btnCL.Location = new System.Drawing.Point(394, 249);
            this.btnCL.Name = "btnCL";
            this.btnCL.Size = new System.Drawing.Size(172, 39);
            this.btnCL.TabIndex = 6;
            this.btnCL.Text = "Check Loan";
            this.btnCL.UseVisualStyleBackColor = false;
            this.btnCL.Click += new System.EventHandler(this.btnCL_Click);
            // 
            // txtReturnDate
            // 
            this.txtReturnDate.Location = new System.Drawing.Point(190, 181);
            this.txtReturnDate.Name = "txtReturnDate";
            this.txtReturnDate.Size = new System.Drawing.Size(196, 30);
            this.txtReturnDate.TabIndex = 5;
            // 
            // txtCopyID
            // 
            this.txtCopyID.Location = new System.Drawing.Point(190, 126);
            this.txtCopyID.Name = "txtCopyID";
            this.txtCopyID.Size = new System.Drawing.Size(196, 30);
            this.txtCopyID.TabIndex = 4;
            // 
            // txtMembID
            // 
            this.txtMembID.Location = new System.Drawing.Point(190, 71);
            this.txtMembID.Name = "txtMembID";
            this.txtMembID.Size = new System.Drawing.Size(196, 30);
            this.txtMembID.TabIndex = 3;
            // 
            // lblRD
            // 
            this.lblRD.AutoSize = true;
            this.lblRD.Location = new System.Drawing.Point(38, 181);
            this.lblRD.Name = "lblRD";
            this.lblRD.Size = new System.Drawing.Size(133, 25);
            this.lblRD.TabIndex = 2;
            this.lblRD.Text = "Return Date:";
            // 
            // lblCopyID
            // 
            this.lblCopyID.AutoSize = true;
            this.lblCopyID.Location = new System.Drawing.Point(38, 129);
            this.lblCopyID.Name = "lblCopyID";
            this.lblCopyID.Size = new System.Drawing.Size(97, 25);
            this.lblCopyID.TabIndex = 1;
            this.lblCopyID.Text = "Copy ID:";
            // 
            // lblMembID
            // 
            this.lblMembID.AutoSize = true;
            this.lblMembID.Location = new System.Drawing.Point(38, 76);
            this.lblMembID.Name = "lblMembID";
            this.lblMembID.Size = new System.Drawing.Size(124, 25);
            this.lblMembID.TabIndex = 0;
            this.lblMembID.Text = "Member ID:";
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.ForeColor = System.Drawing.Color.Blue;
            this.lblReturn.Location = new System.Drawing.Point(488, 9);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(190, 32);
            this.lblReturn.TabIndex = 1;
            this.lblReturn.Text = "Book Return ";
            // 
            // frmReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1183, 753);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.gbBR);
            this.Name = "frmReturn";
            this.Text = "Book Return";
            this.Load += new System.EventHandler(this.frmReturn_Load);
            this.gbBR.ResumeLayout(false);
            this.gbBR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBR;
        private System.Windows.Forms.Label lblRD;
        private System.Windows.Forms.Label lblCopyID;
        private System.Windows.Forms.Label lblMembID;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.TextBox txtReturnDate;
        private System.Windows.Forms.TextBox txtCopyID;
        private System.Windows.Forms.TextBox txtMembID;
        private System.Windows.Forms.Button btnRB;
        private System.Windows.Forms.Button btnCL;
        private System.Windows.Forms.DataGridView dgvLoanInfo;
    }
}