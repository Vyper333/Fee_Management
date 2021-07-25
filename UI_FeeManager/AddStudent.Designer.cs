namespace UI_FeePayment
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Dept = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.ComboBox();
            this.Sem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Div = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGuardian = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtGmobile = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.AddStuSubmit = new System.Windows.Forms.Button();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtYOA = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.ComboBox();
            this.Paid = new System.Windows.Forms.ComboBox();
            this.buttonreset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Roll No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(303, 26);
            this.txtName.TabIndex = 4;
            // 
            // Dept
            // 
            this.Dept.FormattingEnabled = true;
            this.Dept.Items.AddRange(new object[] {
            "Civil",
            "Computer",
            "ETC",
            "Mechanical"});
            this.Dept.Location = new System.Drawing.Point(111, 154);
            this.Dept.Name = "Dept";
            this.Dept.Size = new System.Drawing.Size(145, 30);
            this.Dept.TabIndex = 5;
            this.Dept.Text = "Select";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(11, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Year";
            // 
            // Year
            // 
            this.Year.FormattingEnabled = true;
            this.Year.Items.AddRange(new object[] {
            "FE",
            "SE",
            "TE",
            "BE"});
            this.Year.Location = new System.Drawing.Point(80, 224);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(80, 30);
            this.Year.TabIndex = 7;
            this.Year.Text = "Select";
            // 
            // Sem
            // 
            this.Sem.FormattingEnabled = true;
            this.Sem.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.Sem.Location = new System.Drawing.Point(282, 229);
            this.Sem.Name = "Sem";
            this.Sem.Size = new System.Drawing.Size(101, 30);
            this.Sem.TabIndex = 9;
            this.Sem.Text = "Select";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(200, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Semester";
            // 
            // Div
            // 
            this.Div.FormattingEnabled = true;
            this.Div.Items.AddRange(new object[] {
            "1",
            "2"});
            this.Div.Location = new System.Drawing.Point(84, 297);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(84, 30);
            this.Div.TabIndex = 11;
            this.Div.Text = "Select";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(11, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Division";
            // 
            // txtGuardian
            // 
            this.txtGuardian.Location = new System.Drawing.Point(559, 29);
            this.txtGuardian.Name = "txtGuardian";
            this.txtGuardian.Size = new System.Drawing.Size(246, 26);
            this.txtGuardian.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(427, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Guardian Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(428, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "Guardian Mobile";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(428, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "Mobile Number";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(559, 158);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(246, 26);
            this.txtMobile.TabIndex = 19;
            // 
            // txtGmobile
            // 
            this.txtGmobile.Location = new System.Drawing.Point(559, 230);
            this.txtGmobile.Name = "txtGmobile";
            this.txtGmobile.Size = new System.Drawing.Size(246, 26);
            this.txtGmobile.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(200, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 22);
            this.label12.TabIndex = 20;
            this.label12.Text = "Sex";
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(559, 293);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(86, 26);
            this.txtFee.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(427, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 22);
            this.label13.TabIndex = 22;
            this.label13.Text = "Fee Amount";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(428, 367);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 22);
            this.label14.TabIndex = 24;
            this.label14.Text = "Paid";
            // 
            // AddStuSubmit
            // 
            this.AddStuSubmit.BackColor = System.Drawing.Color.Gold;
            this.AddStuSubmit.FlatAppearance.BorderSize = 0;
            this.AddStuSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStuSubmit.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddStuSubmit.Location = new System.Drawing.Point(304, 526);
            this.AddStuSubmit.Name = "AddStuSubmit";
            this.AddStuSubmit.Size = new System.Drawing.Size(99, 32);
            this.AddStuSubmit.TabIndex = 27;
            this.AddStuSubmit.Text = "Submit";
            this.AddStuSubmit.UseVisualStyleBackColor = false;
            this.AddStuSubmit.Click += new System.EventHandler(this.AddStuSubmit_Click);
            // 
            // txtRollNo
            // 
            this.txtRollNo.Location = new System.Drawing.Point(80, 30);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(100, 26);
            this.txtRollNo.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(15, 371);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 22);
            this.label15.TabIndex = 29;
            this.label15.Text = "Year of Admission";
            // 
            // txtYOA
            // 
            this.txtYOA.Location = new System.Drawing.Point(156, 367);
            this.txtYOA.Name = "txtYOA";
            this.txtYOA.Size = new System.Drawing.Size(100, 26);
            this.txtYOA.TabIndex = 30;
            // 
            // Sex
            // 
            this.Sex.FormattingEnabled = true;
            this.Sex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.Sex.Location = new System.Drawing.Point(253, 297);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(130, 30);
            this.Sex.TabIndex = 31;
            this.Sex.Text = "Select";
            // 
            // Paid
            // 
            this.Paid.FormattingEnabled = true;
            this.Paid.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.Paid.Location = new System.Drawing.Point(559, 359);
            this.Paid.Name = "Paid";
            this.Paid.Size = new System.Drawing.Size(89, 30);
            this.Paid.TabIndex = 32;
            this.Paid.Text = "Select";
            // 
            // buttonreset
            // 
            this.buttonreset.BackColor = System.Drawing.Color.Gold;
            this.buttonreset.FlatAppearance.BorderSize = 0;
            this.buttonreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonreset.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonreset.Location = new System.Drawing.Point(465, 526);
            this.buttonreset.Name = "buttonreset";
            this.buttonreset.Size = new System.Drawing.Size(99, 32);
            this.buttonreset.TabIndex = 33;
            this.buttonreset.Text = "Reset";
            this.buttonreset.UseVisualStyleBackColor = false;
            this.buttonreset.Click += new System.EventHandler(this.buttonreset_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(832, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 42);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(428, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 22);
            this.label11.TabIndex = 36;
            this.label11.Text = "E-Mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(559, 92);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(246, 26);
            this.txtEmail.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.Paid);
            this.panel1.Controls.Add(this.Sex);
            this.panel1.Controls.Add(this.txtYOA);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtRollNo);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtFee);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtGmobile);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtMobile);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtGuardian);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Div);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Sem);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Year);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Dept);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(34, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 421);
            this.panel1.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(36, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 22);
            this.label17.TabIndex = 38;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(894, 595);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonreset);
            this.Controls.Add(this.AddStuSubmit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox Dept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Year;
        private System.Windows.Forms.ComboBox Sem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Div;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGuardian;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtGmobile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button AddStuSubmit;
        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtYOA;
        private System.Windows.Forms.ComboBox Sex;
        private System.Windows.Forms.ComboBox Paid;
        private System.Windows.Forms.Button buttonreset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
    }
}