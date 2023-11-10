namespace Hospital_Management_System
{
    partial class Caution
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
            this.label1 = new System.Windows.Forms.Label();
            this.oKbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "        You are \r\nabout to DELETE this \r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // oKbtn
            // 
            this.oKbtn.Location = new System.Drawing.Point(66, 80);
            this.oKbtn.Name = "oKbtn";
            this.oKbtn.Size = new System.Drawing.Size(79, 41);
            this.oKbtn.TabIndex = 2;
            this.oKbtn.Text = "Okay";
            this.oKbtn.UseVisualStyleBackColor = true;
            this.oKbtn.Click += new System.EventHandler(this.Yesbtn_Click);
            // 
            // Caution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 154);
            this.Controls.Add(this.oKbtn);
            this.Controls.Add(this.label1);
            this.Name = "Caution";
            this.Text = "Caution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button oKbtn;
    }
}