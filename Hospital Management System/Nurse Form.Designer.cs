namespace Hospital_Management_System
{
    partial class Nurse_Form
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
            this.dgvMedicine = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MedIdTxt = new System.Windows.Forms.TextBox();
            this.StffIdTxt = new System.Windows.Forms.TextBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.IdentTxt = new System.Windows.Forms.TextBox();
            this.QuanTxt = new System.Windows.Forms.TextBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Upbtn = new System.Windows.Forms.Button();
            this.Takebtn = new System.Windows.Forms.Button();
            this.dgvDiagnosis = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DiagIdTxt = new System.Windows.Forms.TextBox();
            this.PatIdTxt = new System.Windows.Forms.TextBox();
            this.MedIdtxt2 = new System.Windows.Forms.TextBox();
            this.DateIdTxt = new System.Windows.Forms.TextBox();
            this.DocTxt = new System.Windows.Forms.TextBox();
            this.Addbtn2 = new System.Windows.Forms.Button();
            this.Upbtn2 = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.LogOutbtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvPatient = new System.Windows.Forms.DataGridView();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.Lnametxt = new System.Windows.Forms.TextBox();
            this.Birthtxt = new System.Windows.Forms.TextBox();
            this.Addresstxt = new System.Windows.Forms.TextBox();
            this.PidTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedicine
            // 
            this.dgvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicine.Location = new System.Drawing.Point(12, 217);
            this.dgvMedicine.Name = "dgvMedicine";
            this.dgvMedicine.Size = new System.Drawing.Size(657, 150);
            this.dgvMedicine.TabIndex = 0;
            this.dgvMedicine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicine_CellClick);
            this.dgvMedicine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicine_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(946, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Nurse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Staff ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 554);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 593);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Identification:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 632);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Quantity:";
            // 
            // MedIdTxt
            // 
            this.MedIdTxt.Location = new System.Drawing.Point(56, 484);
            this.MedIdTxt.Name = "MedIdTxt";
            this.MedIdTxt.Size = new System.Drawing.Size(223, 20);
            this.MedIdTxt.TabIndex = 7;
            // 
            // StffIdTxt
            // 
            this.StffIdTxt.Location = new System.Drawing.Point(365, 484);
            this.StffIdTxt.Name = "StffIdTxt";
            this.StffIdTxt.Size = new System.Drawing.Size(223, 20);
            this.StffIdTxt.TabIndex = 8;
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(137, 554);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(223, 20);
            this.NameTxt.TabIndex = 9;
            // 
            // IdentTxt
            // 
            this.IdentTxt.Location = new System.Drawing.Point(138, 593);
            this.IdentTxt.Name = "IdentTxt";
            this.IdentTxt.Size = new System.Drawing.Size(222, 20);
            this.IdentTxt.TabIndex = 10;
            // 
            // QuanTxt
            // 
            this.QuanTxt.Location = new System.Drawing.Point(138, 629);
            this.QuanTxt.Name = "QuanTxt";
            this.QuanTxt.Size = new System.Drawing.Size(221, 20);
            this.QuanTxt.TabIndex = 11;
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(32, 399);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(107, 35);
            this.Addbtn.TabIndex = 12;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Upbtn
            // 
            this.Upbtn.Location = new System.Drawing.Point(220, 399);
            this.Upbtn.Name = "Upbtn";
            this.Upbtn.Size = new System.Drawing.Size(107, 35);
            this.Upbtn.TabIndex = 13;
            this.Upbtn.Text = "Update";
            this.Upbtn.UseVisualStyleBackColor = true;
            this.Upbtn.Click += new System.EventHandler(this.Upbtn_Click);
            // 
            // Takebtn
            // 
            this.Takebtn.Location = new System.Drawing.Point(443, 399);
            this.Takebtn.Name = "Takebtn";
            this.Takebtn.Size = new System.Drawing.Size(107, 35);
            this.Takebtn.TabIndex = 14;
            this.Takebtn.Text = "Take";
            this.Takebtn.UseVisualStyleBackColor = true;
            this.Takebtn.Click += new System.EventHandler(this.Takebtn_Click);
            // 
            // dgvDiagnosis
            // 
            this.dgvDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagnosis.Location = new System.Drawing.Point(1456, 217);
            this.dgvDiagnosis.Name = "dgvDiagnosis";
            this.dgvDiagnosis.Size = new System.Drawing.Size(657, 150);
            this.dgvDiagnosis.TabIndex = 15;
            this.dgvDiagnosis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiagnosis_CellClick);
            this.dgvDiagnosis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiagnosis_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1484, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1674, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Patient ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1664, 539);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Medicine ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1698, 579);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1658, 618);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Doctor Name:";
            // 
            // DiagIdTxt
            // 
            this.DiagIdTxt.Location = new System.Drawing.Point(1520, 459);
            this.DiagIdTxt.Name = "DiagIdTxt";
            this.DiagIdTxt.Size = new System.Drawing.Size(246, 20);
            this.DiagIdTxt.TabIndex = 21;
            // 
            // PatIdTxt
            // 
            this.PatIdTxt.Location = new System.Drawing.Point(1786, 499);
            this.PatIdTxt.Name = "PatIdTxt";
            this.PatIdTxt.Size = new System.Drawing.Size(246, 20);
            this.PatIdTxt.TabIndex = 22;
            // 
            // MedIdtxt2
            // 
            this.MedIdtxt2.Location = new System.Drawing.Point(1786, 536);
            this.MedIdtxt2.Name = "MedIdtxt2";
            this.MedIdtxt2.Size = new System.Drawing.Size(246, 20);
            this.MedIdtxt2.TabIndex = 23;
            // 
            // DateIdTxt
            // 
            this.DateIdTxt.Location = new System.Drawing.Point(1786, 576);
            this.DateIdTxt.Name = "DateIdTxt";
            this.DateIdTxt.Size = new System.Drawing.Size(246, 20);
            this.DateIdTxt.TabIndex = 24;
            // 
            // DocTxt
            // 
            this.DocTxt.Location = new System.Drawing.Point(1786, 618);
            this.DocTxt.Name = "DocTxt";
            this.DocTxt.Size = new System.Drawing.Size(246, 20);
            this.DocTxt.TabIndex = 25;
            // 
            // Addbtn2
            // 
            this.Addbtn2.Location = new System.Drawing.Point(1487, 404);
            this.Addbtn2.Name = "Addbtn2";
            this.Addbtn2.Size = new System.Drawing.Size(107, 34);
            this.Addbtn2.TabIndex = 26;
            this.Addbtn2.Text = "Add";
            this.Addbtn2.UseVisualStyleBackColor = true;
            this.Addbtn2.Click += new System.EventHandler(this.Addbtn2_Click);
            // 
            // Upbtn2
            // 
            this.Upbtn2.Location = new System.Drawing.Point(1713, 404);
            this.Upbtn2.Name = "Upbtn2";
            this.Upbtn2.Size = new System.Drawing.Size(107, 34);
            this.Upbtn2.TabIndex = 27;
            this.Upbtn2.Text = "Update";
            this.Upbtn2.UseVisualStyleBackColor = true;
            this.Upbtn2.Click += new System.EventHandler(this.Upbtn2_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(1938, 404);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(107, 34);
            this.Deletebtn.TabIndex = 28;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // LogOutbtn
            // 
            this.LogOutbtn.BackColor = System.Drawing.Color.Red;
            this.LogOutbtn.Location = new System.Drawing.Point(1967, 35);
            this.LogOutbtn.Name = "LogOutbtn";
            this.LogOutbtn.Size = new System.Drawing.Size(107, 39);
            this.LogOutbtn.TabIndex = 29;
            this.LogOutbtn.Text = "Log out";
            this.LogOutbtn.UseVisualStyleBackColor = false;
            this.LogOutbtn.Click += new System.EventHandler(this.LogOutbtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(239, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "Supply chain";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1778, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "Diagnosis";
            // 
            // dgvPatient
            // 
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatient.Location = new System.Drawing.Point(781, 217);
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.Size = new System.Drawing.Size(576, 150);
            this.dgvPatient.TabIndex = 32;
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(936, 409);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(288, 20);
            this.SearchTxt.TabIndex = 33;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(806, 412);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Search for First Name:";
            this.label14.UseMnemonic = false;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // Searchbtn
            // 
            this.Searchbtn.Location = new System.Drawing.Point(1247, 409);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(101, 37);
            this.Searchbtn.TabIndex = 35;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // Lnametxt
            // 
            this.Lnametxt.Location = new System.Drawing.Point(936, 455);
            this.Lnametxt.Name = "Lnametxt";
            this.Lnametxt.Size = new System.Drawing.Size(288, 20);
            this.Lnametxt.TabIndex = 36;
            // 
            // Birthtxt
            // 
            this.Birthtxt.Location = new System.Drawing.Point(936, 499);
            this.Birthtxt.Name = "Birthtxt";
            this.Birthtxt.Size = new System.Drawing.Size(288, 20);
            this.Birthtxt.TabIndex = 37;
            // 
            // Addresstxt
            // 
            this.Addresstxt.Location = new System.Drawing.Point(936, 539);
            this.Addresstxt.Name = "Addresstxt";
            this.Addresstxt.Size = new System.Drawing.Size(288, 20);
            this.Addresstxt.TabIndex = 38;
            // 
            // PidTxt
            // 
            this.PidTxt.Location = new System.Drawing.Point(936, 579);
            this.PidTxt.Name = "PidTxt";
            this.PidTxt.Size = new System.Drawing.Size(288, 20);
            this.PidTxt.TabIndex = 39;
            // 
            // Nurse_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2152, 1006);
            this.Controls.Add(this.PidTxt);
            this.Controls.Add(this.Addresstxt);
            this.Controls.Add(this.Birthtxt);
            this.Controls.Add(this.Lnametxt);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.dgvPatient);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LogOutbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Upbtn2);
            this.Controls.Add(this.Addbtn2);
            this.Controls.Add(this.DocTxt);
            this.Controls.Add(this.DateIdTxt);
            this.Controls.Add(this.MedIdtxt2);
            this.Controls.Add(this.PatIdTxt);
            this.Controls.Add(this.DiagIdTxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvDiagnosis);
            this.Controls.Add(this.Takebtn);
            this.Controls.Add(this.Upbtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.QuanTxt);
            this.Controls.Add(this.IdentTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.StffIdTxt);
            this.Controls.Add(this.MedIdTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMedicine);
            this.Name = "Nurse_Form";
            this.Text = "Nurse_Form";
            this.Load += new System.EventHandler(this.Nurse_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MedIdTxt;
        private System.Windows.Forms.TextBox StffIdTxt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox IdentTxt;
        private System.Windows.Forms.TextBox QuanTxt;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Upbtn;
        private System.Windows.Forms.Button Takebtn;
        private System.Windows.Forms.DataGridView dgvDiagnosis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DiagIdTxt;
        private System.Windows.Forms.TextBox PatIdTxt;
        private System.Windows.Forms.TextBox MedIdtxt2;
        private System.Windows.Forms.TextBox DateIdTxt;
        private System.Windows.Forms.TextBox DocTxt;
        private System.Windows.Forms.Button Addbtn2;
        private System.Windows.Forms.Button Upbtn2;
        private System.Windows.Forms.Button Deletebtn;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.Button LogOutbtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvPatient;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox Lnametxt;
        private System.Windows.Forms.TextBox Birthtxt;
        private System.Windows.Forms.TextBox Addresstxt;
        private System.Windows.Forms.TextBox PidTxt;
    }
}