namespace LibaryManagementSystem
{
    partial class frmCopies
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
            this.lblCopies = new System.Windows.Forms.Label();
            this.gbBCD = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbtnRefer = new System.Windows.Forms.RadioButton();
            this.rbtnBorrow = new System.Windows.Forms.RadioButton();
            this.txtCopyID = new System.Windows.Forms.TextBox();
            this.txtTitleID = new System.Windows.Forms.TextBox();
            this.lblBS = new System.Windows.Forms.Label();
            this.lblCID = new System.Windows.Forms.Label();
            this.lblTitleID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblEQ = new System.Windows.Forms.Label();
            this.txtEQ = new System.Windows.Forms.TextBox();
            this.lblEC = new System.Windows.Forms.Label();
            this.txtEC = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gbBCD.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCopies
            // 
            this.lblCopies.AutoSize = true;
            this.lblCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopies.ForeColor = System.Drawing.Color.Blue;
            this.lblCopies.Location = new System.Drawing.Point(235, 26);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(186, 32);
            this.lblCopies.TabIndex = 0;
            this.lblCopies.Text = "Book Copies";
            // 
            // gbBCD
            // 
            this.gbBCD.BackColor = System.Drawing.Color.AliceBlue;
            this.gbBCD.Controls.Add(this.btnEdit);
            this.gbBCD.Controls.Add(this.txtEC);
            this.gbBCD.Controls.Add(this.lblEC);
            this.gbBCD.Controls.Add(this.txtEQ);
            this.gbBCD.Controls.Add(this.lblEQ);
            this.gbBCD.Controls.Add(this.btnSearch);
            this.gbBCD.Controls.Add(this.btndelete);
            this.gbBCD.Controls.Add(this.btnAdd);
            this.gbBCD.Controls.Add(this.rbtnRefer);
            this.gbBCD.Controls.Add(this.rbtnBorrow);
            this.gbBCD.Controls.Add(this.txtCopyID);
            this.gbBCD.Controls.Add(this.txtTitleID);
            this.gbBCD.Controls.Add(this.lblBS);
            this.gbBCD.Controls.Add(this.lblCID);
            this.gbBCD.Controls.Add(this.lblTitleID);
            this.gbBCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBCD.Location = new System.Drawing.Point(86, 104);
            this.gbBCD.Name = "gbBCD";
            this.gbBCD.Size = new System.Drawing.Size(491, 573);
            this.gbBCD.TabIndex = 2;
            this.gbBCD.TabStop = false;
            this.gbBCD.Text = "Book Copies Details:";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Coral;
            this.btndelete.Location = new System.Drawing.Point(333, 488);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(114, 55);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAdd.Location = new System.Drawing.Point(31, 488);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 55);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbtnRefer
            // 
            this.rbtnRefer.AutoSize = true;
            this.rbtnRefer.Location = new System.Drawing.Point(212, 423);
            this.rbtnRefer.Name = "rbtnRefer";
            this.rbtnRefer.Size = new System.Drawing.Size(131, 29);
            this.rbtnRefer.TabIndex = 6;
            this.rbtnRefer.TabStop = true;
            this.rbtnRefer.Text = "Reference";
            this.rbtnRefer.UseVisualStyleBackColor = true;
            // 
            // rbtnBorrow
            // 
            this.rbtnBorrow.AutoSize = true;
            this.rbtnBorrow.Location = new System.Drawing.Point(212, 378);
            this.rbtnBorrow.Name = "rbtnBorrow";
            this.rbtnBorrow.Size = new System.Drawing.Size(141, 29);
            this.rbtnBorrow.TabIndex = 5;
            this.rbtnBorrow.TabStop = true;
            this.rbtnBorrow.Text = "Borrowable";
            this.rbtnBorrow.UseVisualStyleBackColor = true;
            // 
            // txtCopyID
            // 
            this.txtCopyID.Location = new System.Drawing.Point(237, 311);
            this.txtCopyID.Name = "txtCopyID";
            this.txtCopyID.Size = new System.Drawing.Size(162, 30);
            this.txtCopyID.TabIndex = 4;
            // 
            // txtTitleID
            // 
            this.txtTitleID.Location = new System.Drawing.Point(212, 60);
            this.txtTitleID.Name = "txtTitleID";
            this.txtTitleID.Size = new System.Drawing.Size(162, 30);
            this.txtTitleID.TabIndex = 3;
            // 
            // lblBS
            // 
            this.lblBS.AutoSize = true;
            this.lblBS.Location = new System.Drawing.Point(37, 399);
            this.lblBS.Name = "lblBS";
            this.lblBS.Size = new System.Drawing.Size(136, 25);
            this.lblBS.TabIndex = 2;
            this.lblBS.Text = "Book Status:";
            // 
            // lblCID
            // 
            this.lblCID.AutoSize = true;
            this.lblCID.Location = new System.Drawing.Point(37, 316);
            this.lblCID.Name = "lblCID";
            this.lblCID.Size = new System.Drawing.Size(172, 25);
            this.lblCID.TabIndex = 1;
            this.lblCID.Text = "Enter a Copy ID:";
            // 
            // lblTitleID
            // 
            this.lblTitleID.AutoSize = true;
            this.lblTitleID.Location = new System.Drawing.Point(118, 65);
            this.lblTitleID.Name = "lblTitleID";
            this.lblTitleID.Size = new System.Drawing.Size(88, 25);
            this.lblTitleID.TabIndex = 0;
            this.lblTitleID.Text = "Title ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Aqua;
            this.btnSearch.Location = new System.Drawing.Point(171, 106);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 41);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblEQ
            // 
            this.lblEQ.AutoSize = true;
            this.lblEQ.Location = new System.Drawing.Point(37, 171);
            this.lblEQ.Name = "lblEQ";
            this.lblEQ.Size = new System.Drawing.Size(182, 25);
            this.lblEQ.TabIndex = 10;
            this.lblEQ.Text = "Existing Quantity:";
            // 
            // txtEQ
            // 
            this.txtEQ.Location = new System.Drawing.Point(237, 171);
            this.txtEQ.Name = "txtEQ";
            this.txtEQ.Size = new System.Drawing.Size(162, 30);
            this.txtEQ.TabIndex = 11;
            // 
            // lblEC
            // 
            this.lblEC.AutoSize = true;
            this.lblEC.Location = new System.Drawing.Point(37, 222);
            this.lblEC.Name = "lblEC";
            this.lblEC.Size = new System.Drawing.Size(169, 25);
            this.lblEC.TabIndex = 12;
            this.lblEC.Text = "Existing Copies:";
            // 
            // txtEC
            // 
            this.txtEC.Location = new System.Drawing.Point(237, 222);
            this.txtEC.Name = "txtEC";
            this.txtEC.Size = new System.Drawing.Size(162, 30);
            this.txtEC.TabIndex = 13;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Gold;
            this.btnEdit.Location = new System.Drawing.Point(183, 488);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(126, 55);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // frmCopies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(667, 748);
            this.Controls.Add(this.gbBCD);
            this.Controls.Add(this.lblCopies);
            this.Name = "frmCopies";
            this.Text = "Copies";
            this.Load += new System.EventHandler(this.Copies_Load);
            this.gbBCD.ResumeLayout(false);
            this.gbBCD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCopies;
        private System.Windows.Forms.GroupBox gbBCD;
        private System.Windows.Forms.TextBox txtCopyID;
        private System.Windows.Forms.TextBox txtTitleID;
        private System.Windows.Forms.Label lblBS;
        private System.Windows.Forms.Label lblCID;
        private System.Windows.Forms.Label lblTitleID;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rbtnRefer;
        private System.Windows.Forms.RadioButton rbtnBorrow;
        private System.Windows.Forms.Label lblEQ;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtEC;
        private System.Windows.Forms.Label lblEC;
        private System.Windows.Forms.TextBox txtEQ;
        private System.Windows.Forms.Button btnEdit;
    }
}