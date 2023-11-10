namespace Hospital_Management_System
{
    partial class Form1
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
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.DayBirth = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstTxt = new System.Windows.Forms.TextBox();
            this.LastTxt = new System.Windows.Forms.TextBox();
            this.BirthTxt = new System.Windows.Forms.TextBox();
            this.RoleTxt = new System.Windows.Forms.TextBox();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.Addbtn1 = new System.Windows.Forms.Button();
            this.Updatebtn1 = new System.Windows.Forms.Button();
            this.Deletebtn1 = new System.Windows.Forms.Button();
            this.StaffIdTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.PatientIdTxt = new System.Windows.Forms.TextBox();
            this.FirstTxt2 = new System.Windows.Forms.TextBox();
            this.LastTxt2 = new System.Windows.Forms.TextBox();
            this.BirthTxt2 = new System.Windows.Forms.TextBox();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            this.firstnme = new System.Windows.Forms.Label();
            this.lastnme = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Addbtn2 = new System.Windows.Forms.Button();
            this.Updatebtn2 = new System.Windows.Forms.Button();
            this.Deletebtn2 = new System.Windows.Forms.Button();
            this.LogOutbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStaff
            // 
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Location = new System.Drawing.Point(-43, 45);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.Size = new System.Drawing.Size(662, 222);
            this.dgvStaff.TabIndex = 0;
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick);
            this.dgvStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(193, 448);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(91, 22);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "First Name:";
            this.FirstName.Click += new System.EventHandler(this.UserName_Click);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(192, 498);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(89, 22);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "Last Name:";
            // 
            // DayBirth
            // 
            this.DayBirth.AutoSize = true;
            this.DayBirth.Location = new System.Drawing.Point(184, 545);
            this.DayBirth.Name = "DayBirth";
            this.DayBirth.Size = new System.Drawing.Size(105, 22);
            this.DayBirth.TabIndex = 3;
            this.DayBirth.Text = "Date of Birth:";
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Location = new System.Drawing.Point(210, 600);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(46, 22);
            this.Role.TabIndex = 4;
            this.Role.Text = "Role:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 640);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password:";
            // 
            // FirstTxt
            // 
            this.FirstTxt.Location = new System.Drawing.Point(341, 445);
            this.FirstTxt.Name = "FirstTxt";
            this.FirstTxt.Size = new System.Drawing.Size(196, 30);
            this.FirstTxt.TabIndex = 6;
            // 
            // LastTxt
            // 
            this.LastTxt.Location = new System.Drawing.Point(341, 491);
            this.LastTxt.Name = "LastTxt";
            this.LastTxt.Size = new System.Drawing.Size(196, 30);
            this.LastTxt.TabIndex = 7;
            // 
            // BirthTxt
            // 
            this.BirthTxt.Location = new System.Drawing.Point(341, 545);
            this.BirthTxt.Name = "BirthTxt";
            this.BirthTxt.Size = new System.Drawing.Size(196, 30);
            this.BirthTxt.TabIndex = 8;
            // 
            // RoleTxt
            // 
            this.RoleTxt.Location = new System.Drawing.Point(341, 585);
            this.RoleTxt.Name = "RoleTxt";
            this.RoleTxt.Size = new System.Drawing.Size(196, 30);
            this.RoleTxt.TabIndex = 9;
            // 
            // PassTxt
            // 
            this.PassTxt.Location = new System.Drawing.Point(341, 633);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(196, 30);
            this.PassTxt.TabIndex = 10;
            // 
            // Addbtn1
            // 
            this.Addbtn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Addbtn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Addbtn1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Addbtn1.Location = new System.Drawing.Point(21, 299);
            this.Addbtn1.Name = "Addbtn1";
            this.Addbtn1.Size = new System.Drawing.Size(100, 41);
            this.Addbtn1.TabIndex = 11;
            this.Addbtn1.Text = "Add";
            this.Addbtn1.UseVisualStyleBackColor = true;
            this.Addbtn1.Click += new System.EventHandler(this.Addbtn1_Click);
            // 
            // Updatebtn1
            // 
            this.Updatebtn1.Location = new System.Drawing.Point(253, 302);
            this.Updatebtn1.Name = "Updatebtn1";
            this.Updatebtn1.Size = new System.Drawing.Size(100, 38);
            this.Updatebtn1.TabIndex = 12;
            this.Updatebtn1.Text = "Update";
            this.Updatebtn1.UseVisualStyleBackColor = true;
            this.Updatebtn1.Click += new System.EventHandler(this.Updatebtn1_Click);
            // 
            // Deletebtn1
            // 
            this.Deletebtn1.Location = new System.Drawing.Point(484, 305);
            this.Deletebtn1.Name = "Deletebtn1";
            this.Deletebtn1.Size = new System.Drawing.Size(100, 35);
            this.Deletebtn1.TabIndex = 13;
            this.Deletebtn1.Text = "Delete";
            this.Deletebtn1.UseVisualStyleBackColor = true;
            this.Deletebtn1.Click += new System.EventHandler(this.Deletebtn1_Click);
            // 
            // StaffIdTxt
            // 
            this.StaffIdTxt.Location = new System.Drawing.Point(21, 376);
            this.StaffIdTxt.Name = "StaffIdTxt";
            this.StaffIdTxt.Size = new System.Drawing.Size(196, 30);
            this.StaffIdTxt.TabIndex = 14;
            this.StaffIdTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(700, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Welcome Administrator";
            // 
            // dgvPatients
            // 
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Location = new System.Drawing.Point(15, 69);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.Size = new System.Drawing.Size(662, 222);
            this.dgvPatients.TabIndex = 17;
            this.dgvPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatients_CellClick);
            this.dgvPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatients_CellClick);
            // 
            // PatientIdTxt
            // 
            this.PatientIdTxt.Location = new System.Drawing.Point(29, 421);
            this.PatientIdTxt.Name = "PatientIdTxt";
            this.PatientIdTxt.Size = new System.Drawing.Size(196, 30);
            this.PatientIdTxt.TabIndex = 18;
            // 
            // FirstTxt2
            // 
            this.FirstTxt2.Location = new System.Drawing.Point(226, 485);
            this.FirstTxt2.Name = "FirstTxt2";
            this.FirstTxt2.Size = new System.Drawing.Size(196, 30);
            this.FirstTxt2.TabIndex = 19;
            // 
            // LastTxt2
            // 
            this.LastTxt2.Location = new System.Drawing.Point(226, 528);
            this.LastTxt2.Name = "LastTxt2";
            this.LastTxt2.Size = new System.Drawing.Size(196, 30);
            this.LastTxt2.TabIndex = 20;
            // 
            // BirthTxt2
            // 
            this.BirthTxt2.Location = new System.Drawing.Point(226, 582);
            this.BirthTxt2.Name = "BirthTxt2";
            this.BirthTxt2.Size = new System.Drawing.Size(196, 30);
            this.BirthTxt2.TabIndex = 21;
            // 
            // AddressTxt
            // 
            this.AddressTxt.Location = new System.Drawing.Point(226, 630);
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.Size = new System.Drawing.Size(196, 30);
            this.AddressTxt.TabIndex = 22;
            // 
            // firstnme
            // 
            this.firstnme.AutoSize = true;
            this.firstnme.Location = new System.Drawing.Point(86, 485);
            this.firstnme.Name = "firstnme";
            this.firstnme.Size = new System.Drawing.Size(91, 22);
            this.firstnme.TabIndex = 24;
            this.firstnme.Text = "First Name:";
            this.firstnme.Click += new System.EventHandler(this.label4_Click);
            // 
            // lastnme
            // 
            this.lastnme.AutoSize = true;
            this.lastnme.Location = new System.Drawing.Point(89, 528);
            this.lastnme.Name = "lastnme";
            this.lastnme.Size = new System.Drawing.Size(89, 22);
            this.lastnme.TabIndex = 25;
            this.lastnme.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 582);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "Date of Birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 630);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Address:";
            // 
            // Addbtn2
            // 
            this.Addbtn2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Addbtn2.Location = new System.Drawing.Point(26, 313);
            this.Addbtn2.Name = "Addbtn2";
            this.Addbtn2.Size = new System.Drawing.Size(102, 32);
            this.Addbtn2.TabIndex = 29;
            this.Addbtn2.Text = "Add";
            this.Addbtn2.UseVisualStyleBackColor = true;
            this.Addbtn2.Click += new System.EventHandler(this.Addbtn2_Click);
            // 
            // Updatebtn2
            // 
            this.Updatebtn2.Location = new System.Drawing.Point(169, 310);
            this.Updatebtn2.Name = "Updatebtn2";
            this.Updatebtn2.Size = new System.Drawing.Size(102, 35);
            this.Updatebtn2.TabIndex = 30;
            this.Updatebtn2.Text = "Update";
            this.Updatebtn2.UseVisualStyleBackColor = true;
            this.Updatebtn2.Click += new System.EventHandler(this.Updatebtn2_Click);
            // 
            // Deletebtn2
            // 
            this.Deletebtn2.Location = new System.Drawing.Point(320, 313);
            this.Deletebtn2.Name = "Deletebtn2";
            this.Deletebtn2.Size = new System.Drawing.Size(102, 35);
            this.Deletebtn2.TabIndex = 31;
            this.Deletebtn2.Text = "Delete";
            this.Deletebtn2.UseVisualStyleBackColor = true;
            this.Deletebtn2.Click += new System.EventHandler(this.Deletebtn2_Click);
            // 
            // LogOutbtn
            // 
            this.LogOutbtn.BackColor = System.Drawing.Color.Red;
            this.LogOutbtn.Location = new System.Drawing.Point(1606, 22);
            this.LogOutbtn.Name = "LogOutbtn";
            this.LogOutbtn.Size = new System.Drawing.Size(104, 43);
            this.LogOutbtn.TabIndex = 32;
            this.LogOutbtn.Text = "Log out";
            this.LogOutbtn.UseVisualStyleBackColor = false;
            this.LogOutbtn.Click += new System.EventHandler(this.LogOutbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPatients);
            this.groupBox1.Controls.Add(this.Addbtn2);
            this.groupBox1.Controls.Add(this.Deletebtn2);
            this.groupBox1.Controls.Add(this.AddressTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BirthTxt2);
            this.groupBox1.Controls.Add(this.Updatebtn2);
            this.groupBox1.Controls.Add(this.LastTxt2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.FirstTxt2);
            this.groupBox1.Controls.Add(this.PatientIdTxt);
            this.groupBox1.Controls.Add(this.lastnme);
            this.groupBox1.Controls.Add(this.firstnme);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(971, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 820);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Record ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvStaff);
            this.groupBox2.Controls.Add(this.Addbtn1);
            this.groupBox2.Controls.Add(this.Updatebtn1);
            this.groupBox2.Controls.Add(this.Deletebtn1);
            this.groupBox2.Controls.Add(this.StaffIdTxt);
            this.groupBox2.Controls.Add(this.Role);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.PassTxt);
            this.groupBox2.Controls.Add(this.FirstTxt);
            this.groupBox2.Controls.Add(this.DayBirth);
            this.groupBox2.Controls.Add(this.RoleTxt);
            this.groupBox2.Controls.Add(this.LastName);
            this.groupBox2.Controls.Add(this.LastTxt);
            this.groupBox2.Controls.Add(this.FirstName);
            this.groupBox2.Controls.Add(this.BirthTxt);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(45, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 808);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Staff Record";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1777, 983);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LogOutbtn);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "                        ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label DayBirth;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstTxt;
        private System.Windows.Forms.TextBox LastTxt;
        private System.Windows.Forms.TextBox BirthTxt;
        private System.Windows.Forms.TextBox RoleTxt;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.Button Addbtn1;
        private System.Windows.Forms.Button Updatebtn1;
        private System.Windows.Forms.Button Deletebtn1;
        private System.Windows.Forms.TextBox StaffIdTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.TextBox PatientIdTxt;
        private System.Windows.Forms.TextBox FirstTxt2;
        private System.Windows.Forms.TextBox LastTxt2;
        private System.Windows.Forms.TextBox BirthTxt2;
        private System.Windows.Forms.TextBox AddressTxt;
        private System.Windows.Forms.Label firstnme;
        private System.Windows.Forms.Label lastnme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Addbtn2;
        private System.Windows.Forms.Button Updatebtn2;
        private System.Windows.Forms.Button Deletebtn2;
        private System.Windows.Forms.Button LogOutbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

