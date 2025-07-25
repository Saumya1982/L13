namespace LibaryManagementSystem
{
    partial class DashBoard
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiesUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiesInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowerInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBookCount = new System.Windows.Forms.Label();
            this.lblBCount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBorrowableNo = new System.Windows.Forms.Label();
            this.lblBorrow = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblReferenceNo = new System.Windows.Forms.Label();
            this.lblReserved = new System.Windows.Forms.Label();
            this.btnInquiry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.borrowersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.contactDetailsToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 32);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(243, 32);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // contactDetailsToolStripMenuItem
            // 
            this.contactDetailsToolStripMenuItem.Name = "contactDetailsToolStripMenuItem";
            this.contactDetailsToolStripMenuItem.Size = new System.Drawing.Size(243, 32);
            this.contactDetailsToolStripMenuItem.Text = "Contact Details";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookInfoToolStripMenuItem,
            this.copiesUpdateToolStripMenuItem,
            this.copiesInfoToolStripMenuItem,
            this.loanToolStripMenuItem,
            this.returnToolStripMenuItem,
            this.reservationToolStripMenuItem});
            this.booksToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(83, 32);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // bookInfoToolStripMenuItem
            // 
            this.bookInfoToolStripMenuItem.Name = "bookInfoToolStripMenuItem";
            this.bookInfoToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.bookInfoToolStripMenuItem.Text = "Book Info";
            this.bookInfoToolStripMenuItem.Click += new System.EventHandler(this.bookInfoToolStripMenuItem_Click);
            // 
            // copiesUpdateToolStripMenuItem
            // 
            this.copiesUpdateToolStripMenuItem.Name = "copiesUpdateToolStripMenuItem";
            this.copiesUpdateToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.copiesUpdateToolStripMenuItem.Text = "Update Stock";
            this.copiesUpdateToolStripMenuItem.Click += new System.EventHandler(this.copiesUpdateToolStripMenuItem_Click);
            // 
            // copiesInfoToolStripMenuItem
            // 
            this.copiesInfoToolStripMenuItem.Name = "copiesInfoToolStripMenuItem";
            this.copiesInfoToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.copiesInfoToolStripMenuItem.Text = "Copies Info";
            this.copiesInfoToolStripMenuItem.Click += new System.EventHandler(this.copiesInfoToolStripMenuItem_Click);
            // 
            // loanToolStripMenuItem
            // 
            this.loanToolStripMenuItem.Name = "loanToolStripMenuItem";
            this.loanToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.loanToolStripMenuItem.Text = "Loan";
            this.loanToolStripMenuItem.Click += new System.EventHandler(this.loanToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.reservationToolStripMenuItem.Text = "Reservation";
            this.reservationToolStripMenuItem.Click += new System.EventHandler(this.reservationToolStripMenuItem_Click);
            // 
            // borrowersToolStripMenuItem
            // 
            this.borrowersToolStripMenuItem.BackColor = System.Drawing.Color.LightSalmon;
            this.borrowersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowerInfoToolStripMenuItem});
            this.borrowersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowersToolStripMenuItem.Name = "borrowersToolStripMenuItem";
            this.borrowersToolStripMenuItem.Size = new System.Drawing.Size(123, 32);
            this.borrowersToolStripMenuItem.Text = "Borrowers";
            // 
            // borrowerInfoToolStripMenuItem
            // 
            this.borrowerInfoToolStripMenuItem.Name = "borrowerInfoToolStripMenuItem";
            this.borrowerInfoToolStripMenuItem.Size = new System.Drawing.Size(230, 32);
            this.borrowerInfoToolStripMenuItem.Text = "Borrower Info";
            this.borrowerInfoToolStripMenuItem.Click += new System.EventHandler(this.borrowerInfoToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblBookCount);
            this.panel1.Controls.Add(this.lblBCount);
            this.panel1.Location = new System.Drawing.Point(28, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 87);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblBookCount
            // 
            this.lblBookCount.AutoSize = true;
            this.lblBookCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookCount.Location = new System.Drawing.Point(93, 44);
            this.lblBookCount.Name = "lblBookCount";
            this.lblBookCount.Size = new System.Drawing.Size(36, 25);
            this.lblBookCount.TabIndex = 1;
            this.lblBookCount.Text = "00";
            this.lblBookCount.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblBCount
            // 
            this.lblBCount.AutoSize = true;
            this.lblBCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBCount.Location = new System.Drawing.Point(16, 9);
            this.lblBCount.Name = "lblBCount";
            this.lblBCount.Size = new System.Drawing.Size(197, 25);
            this.lblBCount.TabIndex = 0;
            this.lblBCount.Text = "No. of Total Books:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.lblBorrowableNo);
            this.panel2.Controls.Add(this.lblBorrow);
            this.panel2.Location = new System.Drawing.Point(288, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 87);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblBorrowableNo
            // 
            this.lblBorrowableNo.AutoSize = true;
            this.lblBorrowableNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowableNo.Location = new System.Drawing.Point(117, 44);
            this.lblBorrowableNo.Name = "lblBorrowableNo";
            this.lblBorrowableNo.Size = new System.Drawing.Size(36, 25);
            this.lblBorrowableNo.TabIndex = 1;
            this.lblBorrowableNo.Text = "00";
            this.lblBorrowableNo.Click += new System.EventHandler(this.lblBorrowableNo_Click);
            // 
            // lblBorrow
            // 
            this.lblBorrow.AutoSize = true;
            this.lblBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrow.Location = new System.Drawing.Point(16, 9);
            this.lblBorrow.Name = "lblBorrow";
            this.lblBorrow.Size = new System.Drawing.Size(256, 25);
            this.lblBorrow.TabIndex = 0;
            this.lblBorrow.Text = "No. of Borrowable Books:";
            this.lblBorrow.Click += new System.EventHandler(this.lblBorrow_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.lblReferenceNo);
            this.panel3.Controls.Add(this.lblReserved);
            this.panel3.Location = new System.Drawing.Point(610, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 87);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblReferenceNo
            // 
            this.lblReferenceNo.AutoSize = true;
            this.lblReferenceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferenceNo.Location = new System.Drawing.Point(114, 44);
            this.lblReferenceNo.Name = "lblReferenceNo";
            this.lblReferenceNo.Size = new System.Drawing.Size(36, 25);
            this.lblReferenceNo.TabIndex = 1;
            this.lblReferenceNo.Text = "00";
            // 
            // lblReserved
            // 
            this.lblReserved.AutoSize = true;
            this.lblReserved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserved.Location = new System.Drawing.Point(16, 9);
            this.lblReserved.Name = "lblReserved";
            this.lblReserved.Size = new System.Drawing.Size(246, 25);
            this.lblReserved.TabIndex = 0;
            this.lblReserved.Text = "No. of Reference Books:";
            // 
            // btnInquiry
            // 
            this.btnInquiry.BackColor = System.Drawing.Color.GreenYellow;
            this.btnInquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInquiry.Location = new System.Drawing.Point(317, 337);
            this.btnInquiry.Name = "btnInquiry";
            this.btnInquiry.Size = new System.Drawing.Size(242, 69);
            this.btnInquiry.TabIndex = 5;
            this.btnInquiry.Text = "Search a Book";
            this.btnInquiry.UseVisualStyleBackColor = false;
            this.btnInquiry.Click += new System.EventHandler(this.btnInquiry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(250, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sarasavi Library - DashBoard";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInquiry);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBookCount;
        private System.Windows.Forms.Label lblBCount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBorrowableNo;
        private System.Windows.Forms.Label lblBorrow;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblReferenceNo;
        private System.Windows.Forms.Label lblReserved;
        private System.Windows.Forms.ToolStripMenuItem copiesUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowerInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiesInfoToolStripMenuItem;
        private System.Windows.Forms.Button btnInquiry;
        private System.Windows.Forms.Label label1;
    }
}