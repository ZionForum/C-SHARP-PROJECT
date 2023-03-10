namespace CS311_MD_2022
{
    partial class frmCompleteTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompleteTicket));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.labeldetails = new System.Windows.Forms.Label();
            this.labelproblem = new System.Windows.Forms.Label();
            this.labelticketnumber = new System.Windows.Forms.Label();
            this.labelcreatedby = new System.Windows.Forms.Label();
            this.labeldatecreated = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(221, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 86;
            this.label5.Text = "Date Created:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(221, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 84;
            this.label4.Text = "Created By:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 79;
            this.label3.Text = "Details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 78;
            this.label2.Text = "Problem:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 77;
            this.label1.Text = "Ticket Number:";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.White;
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.Black;
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.Location = new System.Drawing.Point(141, 197);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(94, 28);
            this.btnsave.TabIndex = 76;
            this.btnsave.Text = "&Complete";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(60, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(250, 32);
            this.label9.TabIndex = 75;
            this.label9.Text = "COMPLETE TICKET";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labeldetails
            // 
            this.labeldetails.AutoSize = true;
            this.labeldetails.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldetails.ForeColor = System.Drawing.Color.Red;
            this.labeldetails.Location = new System.Drawing.Point(17, 168);
            this.labeldetails.Name = "labeldetails";
            this.labeldetails.Size = new System.Drawing.Size(97, 15);
            this.labeldetails.TabIndex = 95;
            this.labeldetails.Text = "Details Display";
            // 
            // labelproblem
            // 
            this.labelproblem.AutoSize = true;
            this.labelproblem.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproblem.ForeColor = System.Drawing.Color.Red;
            this.labelproblem.Location = new System.Drawing.Point(17, 124);
            this.labelproblem.Name = "labelproblem";
            this.labelproblem.Size = new System.Drawing.Size(107, 15);
            this.labelproblem.TabIndex = 94;
            this.labelproblem.Text = "Problem Display";
            // 
            // labelticketnumber
            // 
            this.labelticketnumber.AutoSize = true;
            this.labelticketnumber.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelticketnumber.ForeColor = System.Drawing.Color.Red;
            this.labelticketnumber.Location = new System.Drawing.Point(17, 82);
            this.labelticketnumber.Name = "labelticketnumber";
            this.labelticketnumber.Size = new System.Drawing.Size(146, 15);
            this.labelticketnumber.TabIndex = 93;
            this.labelticketnumber.Text = "Ticket Number Display";
            // 
            // labelcreatedby
            // 
            this.labelcreatedby.AutoSize = true;
            this.labelcreatedby.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcreatedby.ForeColor = System.Drawing.Color.Red;
            this.labelcreatedby.Location = new System.Drawing.Point(221, 82);
            this.labelcreatedby.Name = "labelcreatedby";
            this.labelcreatedby.Size = new System.Drawing.Size(120, 15);
            this.labelcreatedby.TabIndex = 96;
            this.labelcreatedby.Text = "Created By Display";
            // 
            // labeldatecreated
            // 
            this.labeldatecreated.AutoSize = true;
            this.labeldatecreated.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldatecreated.ForeColor = System.Drawing.Color.Red;
            this.labeldatecreated.Location = new System.Drawing.Point(221, 139);
            this.labeldatecreated.Name = "labeldatecreated";
            this.labeldatecreated.Size = new System.Drawing.Size(133, 15);
            this.labeldatecreated.TabIndex = 97;
            this.labeldatecreated.Text = "Date Created Display";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(-2, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 11);
            this.panel1.TabIndex = 98;
            // 
            // frmCompleteTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(375, 237);
            this.Controls.Add(this.labeldatecreated);
            this.Controls.Add(this.labelcreatedby);
            this.Controls.Add(this.labeldetails);
            this.Controls.Add(this.labelproblem);
            this.Controls.Add(this.labelticketnumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCompleteTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complete Ticket";
            this.Load += new System.EventHandler(this.frmCompleteTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labeldetails;
        private System.Windows.Forms.Label labelproblem;
        private System.Windows.Forms.Label labelticketnumber;
        private System.Windows.Forms.Label labelcreatedby;
        private System.Windows.Forms.Label labeldatecreated;
        private System.Windows.Forms.Panel panel1;
    }
}