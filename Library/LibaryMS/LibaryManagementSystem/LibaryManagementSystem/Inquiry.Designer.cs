namespace LibaryManagementSystem
{
    partial class frmInquiry
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
            this.lblInquiry = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtTitleID = new System.Windows.Forms.TextBox();
            this.lblTitleID = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtCopyID = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCopyID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInquiry
            // 
            this.lblInquiry.AutoSize = true;
            this.lblInquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInquiry.ForeColor = System.Drawing.Color.Blue;
            this.lblInquiry.Location = new System.Drawing.Point(424, 23);
            this.lblInquiry.Name = "lblInquiry";
            this.lblInquiry.Size = new System.Drawing.Size(455, 32);
            this.lblInquiry.TabIndex = 0;
            this.lblInquiry.Text = "Search the Availability of a Book";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.txtTitleID);
            this.groupBox1.Controls.Add(this.lblTitleID);
            this.groupBox1.Controls.Add(this.dgvResults);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.txtBookName);
            this.groupBox1.Controls.Add(this.txtCopyID);
            this.groupBox1.Controls.Add(this.lblAuthor);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCopyID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1204, 568);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Inquiry";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.HotPink;
            this.btnReset.Location = new System.Drawing.Point(473, 507);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(306, 39);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtTitleID
            // 
            this.txtTitleID.Location = new System.Drawing.Point(195, 49);
            this.txtTitleID.Name = "txtTitleID";
            this.txtTitleID.Size = new System.Drawing.Size(302, 30);
            this.txtTitleID.TabIndex = 10;
            // 
            // lblTitleID
            // 
            this.lblTitleID.AutoSize = true;
            this.lblTitleID.Location = new System.Drawing.Point(56, 54);
            this.lblTitleID.Name = "lblTitleID";
            this.lblTitleID.Size = new System.Drawing.Size(88, 25);
            this.lblTitleID.TabIndex = 9;
            this.lblTitleID.Text = "Title ID:";
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(6, 352);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.RowTemplate.Height = 24;
            this.dgvResults.Size = new System.Drawing.Size(1192, 133);
            this.dgvResults.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Chartreuse;
            this.btnSearch.Location = new System.Drawing.Point(545, 275);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(157, 59);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(195, 209);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(302, 30);
            this.txtAuthor.TabIndex = 6;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(195, 159);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(302, 30);
            this.txtBookName.TabIndex = 5;
            // 
            // txtCopyID
            // 
            this.txtCopyID.Location = new System.Drawing.Point(195, 100);
            this.txtCopyID.Name = "txtCopyID";
            this.txtCopyID.Size = new System.Drawing.Size(302, 30);
            this.txtCopyID.TabIndex = 4;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(56, 209);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(83, 25);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "Author:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(56, 159);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(130, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Book Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 1;
            // 
            // lblCopyID
            // 
            this.lblCopyID.AutoSize = true;
            this.lblCopyID.Location = new System.Drawing.Point(56, 105);
            this.lblCopyID.Name = "lblCopyID";
            this.lblCopyID.Size = new System.Drawing.Size(97, 25);
            this.lblCopyID.TabIndex = 0;
            this.lblCopyID.Text = "Copy ID:";
            // 
            // frmInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1290, 714);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblInquiry);
            this.Name = "frmInquiry";
            this.Text = "Inquiry";
            this.Load += new System.EventHandler(this.frmInquiry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInquiry;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCopyID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtCopyID;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTitleID;
        private System.Windows.Forms.TextBox txtTitleID;
        private System.Windows.Forms.Button btnReset;
    }
}