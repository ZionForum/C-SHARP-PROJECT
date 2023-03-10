namespace CS311_MD_2022
{
    partial class frmUpdateEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateEquipment));
            this.btnsave = new System.Windows.Forms.Button();
            this.cmbdepartments = new System.Windows.Forms.ComboBox();
            this.cmbbranch = new System.Windows.Forms.ComboBox();
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txtyearmodel = new System.Windows.Forms.TextBox();
            this.txtmanufacturer = new System.Windows.Forms.TextBox();
            this.txtserialNumber = new System.Windows.Forms.TextBox();
            this.txtassetNumber = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rbretired = new System.Windows.Forms.RadioButton();
            this.rbrepair = new System.Windows.Forms.RadioButton();
            this.rbworking = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.White;
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.Location = new System.Drawing.Point(302, 422);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(70, 25);
            this.btnsave.TabIndex = 51;
            this.btnsave.Text = "&Save";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // cmbdepartments
            // 
            this.cmbdepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdepartments.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdepartments.FormattingEnabled = true;
            this.cmbdepartments.Items.AddRange(new object[] {
            "Dean, Graduate School of Education",
            "Dean, Graduate School of Nursing",
            "Dean, Graduate School of Business",
            "OIC, School of Liberal Arts, Social Sciences, and Humanities",
            "Cluster Dean, School of Business, Technology & Management",
            "Department Chair, College of Business Administration",
            "Cluster Dean, School of Science and Mathematics",
            "Department Chair, College of Nursing",
            "Dean, School of Education, Industrial Arts, Skills Training and Continuing Educat" +
                "ion",
            "Department Chair, College of Education",
            "Department Chair, Hospitality & Tourism Mgt.",
            "Department Chair, Institute of Accountancy",
            "Department Chair, College of Radiologic Technology",
            "Department Chair, School of Computer Science",
            "Director, International Nursing Program",
            "Department Chair, College of Medical Laboratory Science",
            "Department Chair, College of Pharmacy",
            "Department Chair, College of Physical Therapy",
            "Department Chair, School of Midwifery",
            "Department Chair, BS Psychology",
            "Department Chair, College of Criminal Justice",
            "Dean, Arellano University School of Law"});
            this.cmbdepartments.Location = new System.Drawing.Point(272, 194);
            this.cmbdepartments.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbdepartments.Name = "cmbdepartments";
            this.cmbdepartments.Size = new System.Drawing.Size(177, 23);
            this.cmbdepartments.TabIndex = 50;
            // 
            // cmbbranch
            // 
            this.cmbbranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbranch.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbranch.FormattingEnabled = true;
            this.cmbbranch.Items.AddRange(new object[] {
            "Juan Sumulong Campus (AU Legarda/Main)",
            "Jose Abad Santos (AU Pasay)",
            "Andres Bonifacio Campus (AU Pasig)",
            "Jose Rizal Campus (AU Malabon)",
            "Plaridel Campus (AU Mandaluyong)",
            "Apolinario Mabini Campus (AU Pasay)",
            "Elisa Esguerra Campus (AU Malabon)"});
            this.cmbbranch.Location = new System.Drawing.Point(272, 146);
            this.cmbbranch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbbranch.Name = "cmbbranch";
            this.cmbbranch.Size = new System.Drawing.Size(177, 23);
            this.cmbbranch.TabIndex = 49;
            // 
            // cmbtype
            // 
            this.cmbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtype.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Items.AddRange(new object[] {
            "Monitor",
            "CPU",
            "Keyboard",
            "Mouse",
            "AVR",
            "MAC",
            "Printer",
            "Projector"});
            this.cmbtype.Location = new System.Drawing.Point(272, 98);
            this.cmbtype.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(177, 23);
            this.cmbtype.TabIndex = 48;
            // 
            // txtdescription
            // 
            this.txtdescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdescription.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescription.Location = new System.Drawing.Point(31, 333);
            this.txtdescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(419, 74);
            this.txtdescription.TabIndex = 47;
            // 
            // txtyearmodel
            // 
            this.txtyearmodel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtyearmodel.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyearmodel.Location = new System.Drawing.Point(30, 245);
            this.txtyearmodel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtyearmodel.Name = "txtyearmodel";
            this.txtyearmodel.Size = new System.Drawing.Size(176, 23);
            this.txtyearmodel.TabIndex = 46;
            this.txtyearmodel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtyearmodel_KeyPress);
            // 
            // txtmanufacturer
            // 
            this.txtmanufacturer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmanufacturer.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanufacturer.Location = new System.Drawing.Point(31, 194);
            this.txtmanufacturer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmanufacturer.Name = "txtmanufacturer";
            this.txtmanufacturer.Size = new System.Drawing.Size(176, 23);
            this.txtmanufacturer.TabIndex = 45;
            // 
            // txtserialNumber
            // 
            this.txtserialNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtserialNumber.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtserialNumber.Location = new System.Drawing.Point(31, 146);
            this.txtserialNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtserialNumber.Name = "txtserialNumber";
            this.txtserialNumber.Size = new System.Drawing.Size(176, 23);
            this.txtserialNumber.TabIndex = 44;
            // 
            // txtassetNumber
            // 
            this.txtassetNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtassetNumber.Enabled = false;
            this.txtassetNumber.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtassetNumber.Location = new System.Drawing.Point(28, 98);
            this.txtassetNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtassetNumber.Name = "txtassetNumber";
            this.txtassetNumber.Size = new System.Drawing.Size(176, 23);
            this.txtassetNumber.TabIndex = 43;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Image = ((System.Drawing.Image)(resources.GetObject("btnclear.Image")));
            this.btnclear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclear.Location = new System.Drawing.Point(380, 422);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(70, 25);
            this.btnclear.TabIndex = 42;
            this.btnclear.Text = "&Clear";
            this.btnclear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(269, 176);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 41;
            this.label8.Text = "Department:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(269, 128);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 40;
            this.label7.Text = "Branch:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(33, 318);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "Description:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "Year Model:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "Manufacturer:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(269, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Type:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Serial Number:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Asset Number:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(107, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(275, 32);
            this.label9.TabIndex = 52;
            this.label9.Text = "UPDATE EQUIPMENT";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.rbretired);
            this.groupBox1.Controls.Add(this.rbrepair);
            this.groupBox1.Controls.Add(this.rbworking);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(272, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 100);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(16, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "   ";
            // 
            // rbretired
            // 
            this.rbretired.AutoSize = true;
            this.rbretired.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbretired.Location = new System.Drawing.Point(76, 69);
            this.rbretired.Name = "rbretired";
            this.rbretired.Size = new System.Drawing.Size(81, 19);
            this.rbretired.TabIndex = 2;
            this.rbretired.TabStop = true;
            this.rbretired.Text = "RETIRED";
            this.rbretired.UseVisualStyleBackColor = true;
            // 
            // rbrepair
            // 
            this.rbrepair.AutoSize = true;
            this.rbrepair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbrepair.Location = new System.Drawing.Point(76, 44);
            this.rbrepair.Name = "rbrepair";
            this.rbrepair.Size = new System.Drawing.Size(93, 19);
            this.rbrepair.TabIndex = 1;
            this.rbrepair.TabStop = true;
            this.rbrepair.Text = "ON-REPAIR";
            this.rbrepair.UseVisualStyleBackColor = true;
            // 
            // rbworking
            // 
            this.rbworking.AutoSize = true;
            this.rbworking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbworking.Location = new System.Drawing.Point(76, 19);
            this.rbworking.Name = "rbworking";
            this.rbworking.Size = new System.Drawing.Size(86, 19);
            this.rbworking.TabIndex = 0;
            this.rbworking.TabStop = true;
            this.rbworking.Text = "WORKING";
            this.rbworking.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(1, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 11);
            this.panel1.TabIndex = 54;
            // 
            // frmUpdateEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(481, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.cmbdepartments);
            this.Controls.Add(this.txtserialNumber);
            this.Controls.Add(this.cmbbranch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbtype);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txtyearmodel);
            this.Controls.Add(this.txtmanufacturer);
            this.Controls.Add(this.txtassetNumber);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmUpdateEquipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Equipment";
            this.Load += new System.EventHandler(this.frmUpdateEquipment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.ComboBox cmbdepartments;
        private System.Windows.Forms.ComboBox cmbbranch;
        private System.Windows.Forms.ComboBox cmbtype;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.TextBox txtyearmodel;
        private System.Windows.Forms.TextBox txtmanufacturer;
        private System.Windows.Forms.TextBox txtserialNumber;
        private System.Windows.Forms.TextBox txtassetNumber;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbretired;
        private System.Windows.Forms.RadioButton rbrepair;
        private System.Windows.Forms.RadioButton rbworking;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
    }
}