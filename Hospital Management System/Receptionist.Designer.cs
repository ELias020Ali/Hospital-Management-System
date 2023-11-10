namespace Hospital_Management_System
{
    partial class Receptionist
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
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PatIdTxt = new System.Windows.Forms.TextBox();
            this.Datetxt = new System.Windows.Forms.TextBox();
            this.DnameTxt = new System.Windows.Forms.TextBox();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.UpBtn = new System.Windows.Forms.Button();
            this.RemBtn = new System.Windows.Forms.Button();
            this.dgvPatient = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FirstTxt = new System.Windows.Forms.TextBox();
            this.LastTxt = new System.Windows.Forms.TextBox();
            this.DateTxt2 = new System.Windows.Forms.TextBox();
            this.AddrTxt = new System.Windows.Forms.TextBox();
            this.PatientIdTxt = new System.Windows.Forms.TextBox();
            this.Addbtn2 = new System.Windows.Forms.Button();
            this.UpBtn2 = new System.Windows.Forms.Button();
            this.Delbtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.LogOutbtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.Location = new System.Drawing.Point(37, 201);
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.Size = new System.Drawing.Size(577, 174);
            this.dgvAppointment.TabIndex = 0;
            this.dgvAppointment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointment_CellClick);
            this.dgvAppointment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointment_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 607);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 650);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Doctor Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // PatIdTxt
            // 
            this.PatIdTxt.Location = new System.Drawing.Point(254, 557);
            this.PatIdTxt.Name = "PatIdTxt";
            this.PatIdTxt.Size = new System.Drawing.Size(250, 20);
            this.PatIdTxt.TabIndex = 4;
            this.PatIdTxt.TextChanged += new System.EventHandler(this.PatIdTxt_TextChanged);
            // 
            // Datetxt
            // 
            this.Datetxt.Location = new System.Drawing.Point(254, 604);
            this.Datetxt.Name = "Datetxt";
            this.Datetxt.Size = new System.Drawing.Size(250, 20);
            this.Datetxt.TabIndex = 5;
            this.Datetxt.TextChanged += new System.EventHandler(this.Datetxt_TextChanged);
            // 
            // DnameTxt
            // 
            this.DnameTxt.Location = new System.Drawing.Point(254, 647);
            this.DnameTxt.Name = "DnameTxt";
            this.DnameTxt.Size = new System.Drawing.Size(250, 20);
            this.DnameTxt.TabIndex = 6;
            // 
            // IdTxt
            // 
            this.IdTxt.Location = new System.Drawing.Point(66, 461);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(249, 20);
            this.IdTxt.TabIndex = 7;
            this.IdTxt.TextChanged += new System.EventHandler(this.IdTxt_TextChanged);
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(66, 397);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(97, 35);
            this.Addbtn.TabIndex = 8;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // UpBtn
            // 
            this.UpBtn.Location = new System.Drawing.Point(234, 398);
            this.UpBtn.Name = "UpBtn";
            this.UpBtn.Size = new System.Drawing.Size(97, 34);
            this.UpBtn.TabIndex = 9;
            this.UpBtn.Text = "Update";
            this.UpBtn.UseVisualStyleBackColor = true;
            this.UpBtn.Click += new System.EventHandler(this.UpBtn_Click);
            // 
            // RemBtn
            // 
            this.RemBtn.Location = new System.Drawing.Point(407, 398);
            this.RemBtn.Name = "RemBtn";
            this.RemBtn.Size = new System.Drawing.Size(97, 34);
            this.RemBtn.TabIndex = 10;
            this.RemBtn.Text = "Remove";
            this.RemBtn.UseVisualStyleBackColor = true;
            this.RemBtn.Click += new System.EventHandler(this.RemBtn_Click);
            // 
            // dgvPatient
            // 
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatient.Location = new System.Drawing.Point(1131, 201);
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.Size = new System.Drawing.Size(577, 174);
            this.dgvPatient.TabIndex = 11;
            this.dgvPatient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatient_CellClick);
            this.dgvPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatient_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1234, 523);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "First name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1233, 564);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Last name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1223, 607);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Date of Birth:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1244, 647);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Address:";
            // 
            // FirstTxt
            // 
            this.FirstTxt.Location = new System.Drawing.Point(1326, 523);
            this.FirstTxt.Name = "FirstTxt";
            this.FirstTxt.Size = new System.Drawing.Size(249, 20);
            this.FirstTxt.TabIndex = 16;
            // 
            // LastTxt
            // 
            this.LastTxt.Location = new System.Drawing.Point(1326, 564);
            this.LastTxt.Name = "LastTxt";
            this.LastTxt.Size = new System.Drawing.Size(249, 20);
            this.LastTxt.TabIndex = 17;
            // 
            // DateTxt2
            // 
            this.DateTxt2.Location = new System.Drawing.Point(1326, 604);
            this.DateTxt2.Name = "DateTxt2";
            this.DateTxt2.Size = new System.Drawing.Size(249, 20);
            this.DateTxt2.TabIndex = 18;
            this.DateTxt2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // AddrTxt
            // 
            this.AddrTxt.Location = new System.Drawing.Point(1326, 643);
            this.AddrTxt.Name = "AddrTxt";
            this.AddrTxt.Size = new System.Drawing.Size(249, 20);
            this.AddrTxt.TabIndex = 19;
            // 
            // PatientIdTxt
            // 
            this.PatientIdTxt.Location = new System.Drawing.Point(1212, 476);
            this.PatientIdTxt.Name = "PatientIdTxt";
            this.PatientIdTxt.Size = new System.Drawing.Size(249, 20);
            this.PatientIdTxt.TabIndex = 20;
            // 
            // Addbtn2
            // 
            this.Addbtn2.Location = new System.Drawing.Point(1212, 408);
            this.Addbtn2.Name = "Addbtn2";
            this.Addbtn2.Size = new System.Drawing.Size(75, 23);
            this.Addbtn2.TabIndex = 21;
            this.Addbtn2.Text = "Add";
            this.Addbtn2.UseVisualStyleBackColor = true;
            this.Addbtn2.Click += new System.EventHandler(this.Addbtn2_Click);
            // 
            // UpBtn2
            // 
            this.UpBtn2.Location = new System.Drawing.Point(1409, 408);
            this.UpBtn2.Name = "UpBtn2";
            this.UpBtn2.Size = new System.Drawing.Size(75, 23);
            this.UpBtn2.TabIndex = 22;
            this.UpBtn2.Text = "Update";
            this.UpBtn2.UseVisualStyleBackColor = true;
            this.UpBtn2.Click += new System.EventHandler(this.UpBtn2_Click);
            // 
            // Delbtn
            // 
            this.Delbtn.Location = new System.Drawing.Point(1588, 409);
            this.Delbtn.Name = "Delbtn";
            this.Delbtn.Size = new System.Drawing.Size(75, 23);
            this.Delbtn.TabIndex = 23;
            this.Delbtn.Text = "Delete";
            this.Delbtn.UseVisualStyleBackColor = true;
            this.Delbtn.Click += new System.EventHandler(this.Delbtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(791, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Welcome Receptionist";
            // 
            // LogOutbtn
            // 
            this.LogOutbtn.BackColor = System.Drawing.Color.Red;
            this.LogOutbtn.Location = new System.Drawing.Point(1621, 22);
            this.LogOutbtn.Name = "LogOutbtn";
            this.LogOutbtn.Size = new System.Drawing.Size(130, 40);
            this.LogOutbtn.TabIndex = 25;
            this.LogOutbtn.Text = "Log out";
            this.LogOutbtn.UseVisualStyleBackColor = false;
            this.LogOutbtn.Click += new System.EventHandler(this.LogOutbtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(254, 513);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 21);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(180, 564);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Patient ID:";
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1817, 865);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LogOutbtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Delbtn);
            this.Controls.Add(this.UpBtn2);
            this.Controls.Add(this.Addbtn2);
            this.Controls.Add(this.PatientIdTxt);
            this.Controls.Add(this.AddrTxt);
            this.Controls.Add(this.DateTxt2);
            this.Controls.Add(this.LastTxt);
            this.Controls.Add(this.FirstTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvPatient);
            this.Controls.Add(this.RemBtn);
            this.Controls.Add(this.UpBtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.DnameTxt);
            this.Controls.Add(this.Datetxt);
            this.Controls.Add(this.PatIdTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAppointment);
            this.Name = "Receptionist";
            this.Text = "Receptionist";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PatIdTxt;
        private System.Windows.Forms.TextBox Datetxt;
        private System.Windows.Forms.TextBox DnameTxt;
        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button UpBtn;
        private System.Windows.Forms.Button RemBtn;
        private System.Windows.Forms.DataGridView dgvPatient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FirstTxt;
        private System.Windows.Forms.TextBox LastTxt;
        private System.Windows.Forms.TextBox DateTxt2;
        private System.Windows.Forms.TextBox AddrTxt;
        private System.Windows.Forms.TextBox PatientIdTxt;
        private System.Windows.Forms.Button Addbtn2;
        private System.Windows.Forms.Button UpBtn2;
        private System.Windows.Forms.Button Delbtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button LogOutbtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
    }
}