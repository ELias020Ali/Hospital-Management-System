using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogInbtn_Click(object sender, EventArgs e)
        {
            if (IdTxt.Text=="Admin" && PassTxt.Text == "password")
            {
                new Form1().Show();
                this.Hide();
            }
            else if(IdTxt.Text=="Nurse" && PassTxt.Text == "password")
            {
                new Nurse_Form().Show();
                this.Hide();
            }
            else if(IdTxt.Text=="Receptionist" && PassTxt.Text == "password")
            {
                new Receptionist().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ERROR Incorrect ID or Passwword, Try again.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
