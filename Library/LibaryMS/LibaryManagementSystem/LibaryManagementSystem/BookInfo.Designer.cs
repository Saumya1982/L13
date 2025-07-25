namespace LibaryManagementSystem
{
    partial class frmBook
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
            this.grbBookInfo = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbtnRefer = new System.Windows.Forms.RadioButton();
            this.rbtnBorrow = new System.Windows.Forms.RadioButton();
            this.lblClasifi = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtTitleID = new System.Windows.Forms.TextBox();
            this.lblTitleID = new System.Windows.Forms.Label();
            this.lblBookInfo = new System.Windows.Forms.Label();
            this.grbBookInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBookInfo
            // 
            this.grbBookInfo.BackColor = System.Drawing.Color.AliceBlue;
            this.grbBookInfo.Controls.Add(this.btnDelete);
            this.grbBookInfo.Controls.Add(this.btnSearch);
            this.grbBookInfo.Controls.Add(this.btnEdit);
            this.grbBookInfo.Controls.Add(this.btnAdd);
            this.grbBookInfo.Controls.Add(this.rbtnRefer);
            this.grbBookInfo.Controls.Add(this.rbtnBorrow);
            this.grbBookInfo.Controls.Add(this.lblClasifi);
            this.grbBookInfo.Controls.Add(this.txtPublisher);
            this.grbBookInfo.Controls.Add(this.lblPublisher);
            this.grbBookInfo.Controls.Add(this.txtAuthor);
            this.grbBookInfo.Controls.Add(this.lblAuthor);
            this.grbBookInfo.Controls.Add(this.txtBookName);
            this.grbBookInfo.Controls.Add(this.lblBookName);
            this.grbBookInfo.Controls.Add(this.txtTitleID);
            this.grbBookInfo.Controls.Add(this.lblTitleID);
            this.grbBookInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBookInfo.Location = new System.Drawing.Point(83, 83);
            this.grbBookInfo.Name = "grbBookInfo";
            this.grbBookInfo.Size = new System.Drawing.Size(578, 488);
            this.grbBookInfo.TabIndex = 0;
            this.grbBookInfo.TabStop = false;
            this.grbBookInfo.Text = "Book Details:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(430, 415);
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
            this.btnSearch.Location = new System.Drawing.Point(292, 415);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 40);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SpringGreen;
            this.btnEdit.Location = new System.Drawing.Point(157, 415);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(116, 40);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Aqua;
            this.btnAdd.Location = new System.Drawing.Point(16, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 40);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbtnRefer
            // 
            this.rbtnRefer.AutoSize = true;
            this.rbtnRefer.Location = new System.Drawing.Point(258, 316);
            this.rbtnRefer.Name = "rbtnRefer";
            this.rbtnRefer.Size = new System.Drawing.Size(131, 29);
            this.rbtnRefer.TabIndex = 13;
            this.rbtnRefer.TabStop = true;
            this.rbtnRefer.Text = "Reference";
            this.rbtnRefer.UseVisualStyleBackColor = true;
            // 
            // rbtnBorrow
            // 
            this.rbtnBorrow.AutoSize = true;
            this.rbtnBorrow.Location = new System.Drawing.Point(258, 267);
            this.rbtnBorrow.Name = "rbtnBorrow";
            this.rbtnBorrow.Size = new System.Drawing.Size(141, 29);
            this.rbtnBorrow.TabIndex = 12;
            this.rbtnBorrow.TabStop = true;
            this.rbtnBorrow.Text = "Borrowable";
            this.rbtnBorrow.UseVisualStyleBackColor = true;
            // 
            // lblClasifi
            // 
            this.lblClasifi.AutoSize = true;
            this.lblClasifi.Location = new System.Drawing.Point(90, 297);
            this.lblClasifi.Name = "lblClasifi";
            this.lblClasifi.Size = new System.Drawing.Size(148, 25);
            this.lblClasifi.TabIndex = 8;
            this.lblClasifi.Text = "Classification:";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(258, 205);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(213, 30);
            this.txtPublisher.TabIndex = 7;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(90, 205);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(109, 25);
            this.lblPublisher.TabIndex = 6;
            this.lblPublisher.Text = "Publisher:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(258, 157);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(213, 30);
            this.txtAuthor.TabIndex = 5;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(92, 157);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(83, 25);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Author:";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(258, 105);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(213, 30);
            this.txtBookName.TabIndex = 3;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(92, 105);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(130, 25);
            this.lblBookName.TabIndex = 2;
            this.lblBookName.Text = "Book Name:";
            // 
            // txtTitleID
            // 
            this.txtTitleID.Location = new System.Drawing.Point(258, 53);
            this.txtTitleID.Name = "txtTitleID";
            this.txtTitleID.Size = new System.Drawing.Size(213, 30);
            this.txtTitleID.TabIndex = 1;
            // 
            // lblTitleID
            // 
            this.lblTitleID.AutoSize = true;
            this.lblTitleID.Location = new System.Drawing.Point(90, 58);
            this.lblTitleID.Name = "lblTitleID";
            this.lblTitleID.Size = new System.Drawing.Size(88, 25);
            this.lblTitleID.TabIndex = 0;
            this.lblTitleID.Text = "Title ID:";
            // 
            // lblBookInfo
            // 
            this.lblBookInfo.AutoSize = true;
            this.lblBookInfo.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookInfo.ForeColor = System.Drawing.Color.Blue;
            this.lblBookInfo.Location = new System.Drawing.Point(233, 9);
            this.lblBookInfo.Name = "lblBookInfo";
            this.lblBookInfo.Size = new System.Drawing.Size(285, 40);
            this.lblBookInfo.TabIndex = 1;
            this.lblBookInfo.Text = "Book Information";
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(744, 646);
            this.Controls.Add(this.lblBookInfo);
            this.Controls.Add(this.grbBookInfo);
            this.Name = "frmBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookInfo";
            this.Load += new System.EventHandler(this.frmBook_Load);
            this.grbBookInfo.ResumeLayout(false);
            this.grbBookInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBookInfo;
        private System.Windows.Forms.Label lblBookInfo;
        private System.Windows.Forms.TextBox txtTitleID;
        private System.Windows.Forms.Label lblTitleID;
        private System.Windows.Forms.Label lblClasifi;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.RadioButton rbtnRefer;
        private System.Windows.Forms.RadioButton rbtnBorrow;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}

