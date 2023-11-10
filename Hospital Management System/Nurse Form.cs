using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Hospital_Management_System
{
    public partial class Nurse_Form : Form
    {
        public Nurse_Form()
        {
            InitializeComponent();
            LoadData(); 
        }
        private void LoadData()
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\Elias\source\repos\Hospital Management System 3.0\Hospital Management System.db");
            conn.Open();

            string query = "Select * from Medicine";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dgvMedicine.DataSource = dt;

            string query2 = "Select * from Diagnosis";
            cmd = new SQLiteCommand(query2, conn);

            DataTable dt2 = new DataTable();
            SQLiteDataAdapter adapter2 = new SQLiteDataAdapter(cmd);
            adapter2.Fill(dt2);

            dgvDiagnosis.DataSource = dt2;

            string query3 = "Select * from Patient_Record";
            cmd = new SQLiteCommand(query3, conn);

            DataTable dt3 = new DataTable();
            SQLiteDataAdapter adapter3 = new SQLiteDataAdapter(cmd);
            adapter3.Fill(dt3);

            dgvPatient.DataSource = dt3;
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

            StffIdTxt.Text = "";
            NameTxt.Text = "";
            IdentTxt.Text = "";
            QuanTxt.Text = "";

            PatIdTxt.Text = "";
            MedIdtxt2.Text = "";
            DateIdTxt.Text = "";
            DocTxt.Text = "";
        }

        private void Nurse_Form_Load(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            string dbquery = "Insert into Medicine(Staff_ID,Name,Identification,Quantity) " +
            "values ('" + StffIdTxt.Text + "', '" + NameTxt.Text + "',  '" + IdentTxt.Text + "',  '" + QuanTxt.Text + "')";
            AmendDatabase(dbquery);
            LoadData();
        }

        private void Upbtn_Click(object sender, EventArgs e)
        {
            string dbquery = String.Format(" UPDATE Medicine SET Staff_ID = '{0}', Name = '{1}', Identification = '{2}' , Quantity = '{3}' WHERE Medicine_ID = '{4}'", StffIdTxt.Text, NameTxt.Text, IdentTxt.Text, QuanTxt.Text);
            AmendDatabase(dbquery);
            LoadData();
        }

        private void Takebtn_Click(object sender, EventArgs e)
        {

            string dbquery = "Delete from Medicine where Medicine_ID = '" + MedIdTxt.Text + "'";
            AmendDatabase(dbquery);
            LoadData();
        }

        private void dgvMedicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvMedicine.Rows[e.RowIndex];
                StffIdTxt.Text = row.Cells[0].Value.ToString();
                NameTxt.Text = row.Cells[1].Value.ToString();
                IdentTxt.Text = row.Cells[2].Value.ToString();
                QuanTxt.Text = row.Cells[3].Value.ToString();
            }

        }

        private void Addbtn2_Click(object sender, EventArgs e)
        {
            string dbquery = "Insert into Diagnosis(Patient_ID,Medicine_ID,date,Doctor_Name) " +
            "values ('" + PatIdTxt.Text + "', '" + MedIdtxt2.Text + "',  '" + DateIdTxt.Text + "', '" + DocTxt.Text + "' )";
            AmendDatabase(dbquery);
            LoadData();
        }

        private void Upbtn2_Click(object sender, EventArgs e)
        {
            string dbquery = String.Format(" UPDATE Patient_Record SET Patient_ID = '{0}', Medicine_ID = '{1}', date = '{2}' , Doctor_Name = '{3}', WHERE Diagnosis_ID = '{4}'", PatIdTxt.Text, MedIdtxt2.Text, DateIdTxt.Text, DocTxt.Text, DiagIdTxt.Text);
            AmendDatabase(dbquery);
            LoadData();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string dbquery = "Delete from Diagnosis where Diagnosis_ID = '" + DiagIdTxt.Text + "'";
            AmendDatabase(dbquery);
            LoadData();
        }

        private void dgvDiagnosis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row2 = this.dgvDiagnosis.Rows[e.RowIndex];
                PatIdTxt.Text = row2.Cells[0].Value.ToString();
                MedIdtxt2.Text = row2.Cells[1].Value.ToString();
                DateIdTxt.Text = row2.Cells[2].Value.ToString();
                DocTxt.Text = row2.Cells[3].Value.ToString();
                DiagIdTxt.Text = row2.Cells[4].Value.ToString();
            }

        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            var newform = new Login();
            newform.Show();
            this.Hide();
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\Elias\source\repos\Hospital Management System 3.0\Hospital Management System.db");
            conn.Open();
            string dbquery = "Select * from Patient_Record where first_name = '" + SearchTxt.Text + "'";
            SQLiteCommand cmd = new SQLiteCommand(dbquery, conn);

            DataTable dt3 = new DataTable();
            SQLiteDataAdapter adapter3 = new SQLiteDataAdapter(cmd);
            adapter3.Fill(dt3);

            dgvPatient.DataSource = dt3;
            conn.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
