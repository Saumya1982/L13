namespace LibaryManagementSystem
{
    partial class frmReservation
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
            this.txtTitleID = new System.Windows.Forms.TextBox();
            this.lblTitleID = new System.Windows.Forms.Label();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.btnReserve = new System.Windows.Forms.Button();
            this.txtCopyID = new System.Windows.Forms.TextBox();
            this.txtMembID = new System.Windows.Forms.TextBox();
            this.lblCopyID = new System.Windows.Forms.Label();
            this.lblMembID = new System.Windows.Forms.Label();
            this.lblReser = new System.Windows.Forms.Label();
            this.gbBR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBR
            // 
            this.gbBR.BackColor = System.Drawing.Color.AliceBlue;
            this.gbBR.Controls.Add(this.txtTitleID);
            this.gbBR.Controls.Add(this.lblTitleID);
            this.gbBR.Controls.Add(this.dgvReservations);
            this.gbBR.Controls.Add(this.btnReserve);
            this.gbBR.Controls.Add(this.txtCopyID);
            this.gbBR.Controls.Add(this.txtMembID);
            this.gbBR.Controls.Add(this.lblCopyID);
            this.gbBR.Controls.Add(this.lblMembID);
            this.gbBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBR.Location = new System.Drawing.Point(69, 84);
            this.gbBR.Name = "gbBR";
            this.gbBR.Size = new System.Drawing.Size(968, 466);
            this.gbBR.TabIndex = 0;
            this.gbBR.TabStop = false;
            this.gbBR.Text = "Book Reservation";
            // 
            // txtTitleID
            // 
            this.txtTitleID.Location = new System.Drawing.Point(189, 110);
            this.txtTitleID.Name = "txtTitleID";
            this.txtTitleID.Size = new System.Drawing.Size(323, 30);
            this.txtTitleID.TabIndex = 7;
            // 
            // lblTitleID
            // 
            this.lblTitleID.AutoSize = true;
            this.lblTitleID.Location = new System.Drawing.Point(49, 115);
            this.lblTitleID.Name = "lblTitleID";
            this.lblTitleID.Size = new System.Drawing.Size(88, 25);
            this.lblTitleID.TabIndex = 6;
            this.lblTitleID.Text = "Title ID:";
            // 
            // dgvReservations
            // 
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(54, 278);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.RowHeadersWidth = 51;
            this.dgvReservations.RowTemplate.Height = 24;
            this.dgvReservations.Size = new System.Drawing.Size(869, 135);
            this.dgvReservations.TabIndex = 5;
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnReserve.Location = new System.Drawing.Point(328, 219);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(308, 44);
            this.btnReserve.TabIndex = 4;
            this.btnReserve.Text = "Book Reserve";
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // txtCopyID
            // 
            this.txtCopyID.Location = new System.Drawing.Point(189, 158);
            this.txtCopyID.Name = "txtCopyID";
            this.txtCopyID.Size = new System.Drawing.Size(323, 30);
            this.txtCopyID.TabIndex = 3;
            // 
            // txtMembID
            // 
            this.txtMembID.Location = new System.Drawing.Point(189, 67);
            this.txtMembID.Name = "txtMembID";
            this.txtMembID.Size = new System.Drawing.Size(323, 30);
            this.txtMembID.TabIndex = 2;
            // 
            // lblCopyID
            // 
            this.lblCopyID.AutoSize = true;
            this.lblCopyID.Location = new System.Drawing.Point(49, 163);
            this.lblCopyID.Name = "lblCopyID";
            this.lblCopyID.Size = new System.Drawing.Size(97, 25);
            this.lblCopyID.TabIndex = 1;
            this.lblCopyID.Text = "Copy ID:";
            // 
            // lblMembID
            // 
            this.lblMembID.AutoSize = true;
            this.lblMembID.Location = new System.Drawing.Point(49, 70);
            this.lblMembID.Name = "lblMembID";
            this.lblMembID.Size = new System.Drawing.Size(124, 25);
            this.lblMembID.TabIndex = 0;
            this.lblMembID.Text = "Member ID:";
            // 
            // lblReser
            // 
            this.lblReser.AutoSize = true;
            this.lblReser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReser.ForeColor = System.Drawing.Color.Blue;
            this.lblReser.Location = new System.Drawing.Point(433, 9);
            this.lblReser.Name = "lblReser";
            this.lblReser.Size = new System.Drawing.Size(262, 32);
            this.lblReser.TabIndex = 1;
            this.lblReser.Text = "Book Reservation ";
            // 
            // frmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1104, 610);
            this.Controls.Add(this.lblReser);
            this.Controls.Add(this.gbBR);
            this.Name = "frmReservation";
            this.Text = "Book Reservation";
            this.Load += new System.EventHandler(this.frmReservation_Load);
            this.gbBR.ResumeLayout(false);
            this.gbBR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBR;
        private System.Windows.Forms.Label lblMembID;
        private System.Windows.Forms.Label lblReser;
        private System.Windows.Forms.Label lblCopyID;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.TextBox txtCopyID;
        private System.Windows.Forms.TextBox txtMembID;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.TextBox txtTitleID;
        private System.Windows.Forms.Label lblTitleID;
    }
}