namespace LibaryManagementSystem
{
    partial class frmBookCopies
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
            this.gbBookCopies = new System.Windows.Forms.GroupBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtTitleID = new System.Windows.Forms.TextBox();
            this.btnAB = new System.Windows.Forms.Button();
            this.lblTID = new System.Windows.Forms.Label();
            this.lblBStock = new System.Windows.Forms.Label();
            this.gbBookCopies.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBookCopies
            // 
            this.gbBookCopies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbBookCopies.Controls.Add(this.txtqty);
            this.gbBookCopies.Controls.Add(this.lblQty);
            this.gbBookCopies.Controls.Add(this.txtTitleID);
            this.gbBookCopies.Controls.Add(this.btnAB);
            this.gbBookCopies.Controls.Add(this.lblTID);
            this.gbBookCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBookCopies.Location = new System.Drawing.Point(29, 94);
            this.gbBookCopies.Name = "gbBookCopies";
            this.gbBookCopies.Size = new System.Drawing.Size(454, 300);
            this.gbBookCopies.TabIndex = 0;
            this.gbBookCopies.TabStop = false;
            this.gbBookCopies.Text = "Book Copies";
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(282, 133);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(157, 30);
            this.txtqty.TabIndex = 4;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(66, 138);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(192, 25);
            this.lblQty.TabIndex = 3;
            this.lblQty.Text = "Number of Copies:";
            this.lblQty.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTitleID
            // 
            this.txtTitleID.Location = new System.Drawing.Point(282, 64);
            this.txtTitleID.Name = "txtTitleID";
            this.txtTitleID.Size = new System.Drawing.Size(155, 30);
            this.txtTitleID.TabIndex = 2;
            // 
            // btnAB
            // 
            this.btnAB.BackColor = System.Drawing.Color.Lime;
            this.btnAB.Location = new System.Drawing.Point(135, 219);
            this.btnAB.Name = "btnAB";
            this.btnAB.Size = new System.Drawing.Size(163, 52);
            this.btnAB.TabIndex = 1;
            this.btnAB.Text = "Add Copies";
            this.btnAB.UseVisualStyleBackColor = false;
            this.btnAB.Click += new System.EventHandler(this.btnAB_Click);
            // 
            // lblTID
            // 
            this.lblTID.AutoSize = true;
            this.lblTID.Location = new System.Drawing.Point(66, 67);
            this.lblTID.Name = "lblTID";
            this.lblTID.Size = new System.Drawing.Size(82, 25);
            this.lblTID.TabIndex = 0;
            this.lblTID.Text = "TitleID:";
            // 
            // lblBStock
            // 
            this.lblBStock.AutoSize = true;
            this.lblBStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBStock.ForeColor = System.Drawing.Color.Blue;
            this.lblBStock.Location = new System.Drawing.Point(172, 33);
            this.lblBStock.Name = "lblBStock";
            this.lblBStock.Size = new System.Drawing.Size(167, 32);
            this.lblBStock.TabIndex = 1;
            this.lblBStock.Text = "Book Stock";
            // 
            // frmBookCopies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.lblBStock);
            this.Controls.Add(this.gbBookCopies);
            this.Name = "frmBookCopies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookCopies";
            this.Load += new System.EventHandler(this.frmBookCopies_Load);
            this.gbBookCopies.ResumeLayout(false);
            this.gbBookCopies.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBookCopies;
        private System.Windows.Forms.Label lblBStock;
        private System.Windows.Forms.TextBox txtTitleID;
        private System.Windows.Forms.Button btnAB;
        private System.Windows.Forms.Label lblTID;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label lblQty;
    }
}