using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Xml.Linq;
using System.Data.Entity.Infrastructure;

namespace Hospital_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\c1013892\Hospital Management System 2.0\Hospital Management System.db");
            conn.Open();

            string query = "Select * from Staff_Record";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dgvStaff.DataSource = dt;

            string query2 = "Select * from Patient_Record";
            cmd = new SQLiteCommand(query2, conn);

            DataTable dt2 = new DataTable();
            SQLiteDataAdapter adapter2 = new SQLiteDataAdapter(cmd);
            adapter2.Fill(dt2);

            dgvPatients.DataSource = dt2;

            conn.Close();
        }

        private void AmendDatabase(string txtQuery)
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\c1013892\Hospital Management System 2.0\Hospital Management System.db");
            conn.Open();
            string query = txtQuery;
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            FirstTxt.Text = "";
            LastTxt.Text = "";
            BirthTxt.Text = "";
            RoleTxt.Text = "";
            PassTxt.Text = "";

          /*  conn.Open();
            string query2 = txtQuery;
            SQLiteCommand cmd2 = new SQLiteCommand(query2, conn);
            cmd2.ExecuteNonQuery();
            conn.Close();
          */
            FirstTxt2.Text = "";
            LastTxt2.Text = "";
            BirthTxt2.Text = "";
            AddressTxt.Text = "";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserName_Click(object sender, EventArgs e)
        {

        }

        private void Addbtn1_Click(object sender, EventArgs e)
        {
            string dbquery = "Insert into Staff_Record(First_Name,Last_Name,Day_birth,Role,Password) " +
            "values ('" + FirstTxt.Text + "', '" + LastTxt.Text + "',  '" + BirthTxt.Text + "',  '" + RoleTxt.Text + "',  '" + PassTxt.Text + "' )";
            AmendDatabase(dbquery);
            LoadData();
        }

        private void Updatebtn1_Click(object sender, EventArgs e)
        {
            //string dbquery = " UPDATE Staff_Record SET First_Name = " + "'" + FirstTxt.Text + "'" + "," + "Last_Name = " + "'" + LastTxt.Text
            //    + "'" + "," + "Day_Birth = " + "'" + BirthTxt.Text + "'" + "," + "Role = " + "'" + RoleTxt.Text + "'" + "'" + "Password = " +"'" + PassTxt.Text + "WHERE Staff_ID = " + "'" + StaffIdTxt.Text + "'";

            string dbquery = String.Format(" UPDATE Staff_Record SET First_Name = '{0}', Last_Name = '{1}', Day_Birth = '{2}' , Role = '{3}',Password = '{4}' WHERE Staff_ID = '{5}'", FirstTxt.Text, LastTxt.Text, BirthTxt.Text, RoleTxt.Text, PassTxt.Text, StaffIdTxt.Text);
            AmendDatabase(dbquery);
            LoadData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Addbtn2_Click(object sender, EventArgs e)
        {
            string dbquery = "Insert into Patient_Record(first_name,last_name,D_O_B,Address) " +
            "values ('" + FirstTxt2.Text + "', '" + LastTxt2.Text + "',  '" + BirthTxt2.Text + "', '" + AddressTxt.Text + "' )";
            AmendDatabase(dbquery);
            LoadData();
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvStaff.Rows[e.RowIndex];
                StaffIdTxt.Text = row.Cells[0].Value.ToString();
                FirstTxt.Text = row.Cells[1].Value.ToString();
                LastTxt.Text = row.Cells[2].Value.ToString();
                BirthTxt.Text = row.Cells[3].Value.ToString();
                RoleTxt.Text = row.Cells[4].Value.ToString();
                PassTxt.Text = row.Cells[5].Value.ToString();
            }
          
        }

        private void Deletebtn1_Click(object sender, EventArgs e)
        {
            string dbquery = "Delete from Staff_Record where Staff_ID = '" + StaffIdTxt.Text + "'";
            AmendDatabase(dbquery);
            LoadData();
        }

        private void Updatebtn2_Click(object sender, EventArgs e)
        {
            string dbquery = String.Format(" UPDATE Patient_Record SET first_name = '{0}', last_name = '{1}', D_O_B = '{2}' , Address = '{3}' WHERE Patient_ID = '{4}'", FirstTxt2.Text, LastTxt2.Text, BirthTxt2.Text,AddressTxt.Text, PatientIdTxt.Text);
            AmendDatabase(dbquery);
            LoadData();
        }

        private void dgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row2 = this.dgvPatients.Rows[e.RowIndex];
                PatientIdTxt.Text = row2.Cells[0].Value.ToString();
                FirstTxt2.Text = row2.Cells[1].Value.ToString();
                LastTxt2.Text = row2.Cells[2].Value.ToString();
                BirthTxt2.Text = row2.Cells[3].Value.ToString();
                AddressTxt.Text = row2.Cells[4].Value.ToString();
            }

        }

        private void Deletebtn2_Click(object sender, EventArgs e)
        {
            string dbquery = "Delete from Patient_Record where Patient_ID = '" + PatientIdTxt.Text + "'";
            AmendDatabase(dbquery);
            LoadData();
        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            var newform = new Login();
            newform.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
