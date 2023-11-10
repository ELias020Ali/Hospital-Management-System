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

namespace Hospital_Management_System
{
    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\c1013892\Hospital Management System 2.0\Hospital Management System.db");
            conn.Open();

            string query = "Select Patient_Record.Patient_ID, Appointment_ID, Patient_Record.first_name ||' '|| Patient_Record.last_name AS Patient, date, Doctor_name from Appointment_Record inner JOIN Patient_Record on (Patient_Record.Patient_ID = Appointment_Record.Patient_ID)";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dgvAppointment.DataSource = dt;

            //////
            string query3 = "Select Patient_Record.Patient_ID as ID, Patient_Record.first_name ||' '|| Patient_Record.last_name AS Patient from Patient_Record";
            SQLiteCommand cmd3 = new SQLiteCommand(query3, conn);

            DataTable dt3 = new DataTable();
            SQLiteDataAdapter adapter3 = new SQLiteDataAdapter(cmd3);
            adapter3.Fill(dt3);

            foreach(DataRow dr in dt3.Rows)
            {
                comboBox1.Items.Add(dr["Patient"]);
            }

            

            //////

            string query2 = "Select * from Patient_Record";
            cmd = new SQLiteCommand(query2, conn);

            DataTable dt2 = new DataTable();
            SQLiteDataAdapter adapter2 = new SQLiteDataAdapter(cmd);
            adapter2.Fill(dt2);

            dgvPatient.DataSource = dt2;

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

          
            PatIdTxt.Text = "";
            Datetxt.Text = "";
            DnameTxt.Text = "";

            FirstTxt.Text = "";
            LastTxt.Text = "";
            DateTxt2.Text = "";
            AddrTxt.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            string dbquery = "Insert into Appointment_Record(Patient_ID,Patient_name,Date,Doctor_name) " +//create patient name coloumn then add it here. Then add combobox in to queries.
            "values ('" + PatIdTxt.Text + "','" + comboBox1.SelectedItem.ToString() + "' ,'" + Datetxt.Text + "',  '" + DnameTxt.Text + "')";
            AmendDatabase(dbquery);
            LoadData();
        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            string dbquery = String.Format(" UPDATE Appointment_Record SET Patient_ID = '{0}', Patient_name = '{1}', Date = '{2}', Doctor_name = '{3}' WHERE Appointment_ID = '{4}'", PatIdTxt.Text, comboBox1.SelectedItem.ToString(), Datetxt.Text, DnameTxt.Text, IdTxt.Text);
            AmendDatabase(dbquery);
            LoadData();
        }

        private void RemBtn_Click(object sender, EventArgs e)
        {
            //new Caution().Show();
            string dbquery = "Delete from Appointment_Record where Patient_ID = '" + PatIdTxt.Text + "'";
            AmendDatabase(dbquery);
            LoadData();
        }
        private void dgvAppointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvAppointment.Rows[e.RowIndex];
                IdTxt.Text = row.Cells[0].Value.ToString();
                comboBox1.SelectedItem = row.Cells[0].Value.ToString();
                PatIdTxt.Text = row.Cells[0].Value.ToString();
                Datetxt.Text = row.Cells[2].Value.ToString();
                DnameTxt.Text = row.Cells[3].Value.ToString();

               
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addbtn2_Click(object sender, EventArgs e)
        {
            string dbquery = "Insert into Patient_Record(first_name,last_name,D_O_B,Address) " +
            "values ('" + FirstTxt.Text + "', '" + LastTxt.Text + "',  '" + DateTxt2.Text + "', '" + AddrTxt.Text + "' )";
            AmendDatabase(dbquery);
            LoadData();
        }

        private void UpBtn2_Click(object sender, EventArgs e)
        {
            string dbquery = String.Format(" UPDATE Patient_Record SET first_name = '{0}', last_name = '{1}', D_O_B = '{2}' , Address = '{3}', WHERE Patient_ID = '{4}'", FirstTxt.Text, LastTxt.Text, DateTxt2.Text, AddrTxt.Text, PatientIdTxt.Text);
            AmendDatabase(dbquery);
            LoadData();
        }

        private void Delbtn_Click(object sender, EventArgs e)
        {
            string dbquery = "Delete from Patient_Record where Patient_ID = '" + PatientIdTxt.Text + "'";
            AmendDatabase(dbquery);
            LoadData();
        }

        private void dgvPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row2 = this.dgvPatient.Rows[e.RowIndex];
                PatientIdTxt.Text = row2.Cells[0].Value.ToString();
                FirstTxt.Text = row2.Cells[1].Value.ToString();
                LastTxt.Text = row2.Cells[2].Value.ToString();
                DateTxt2.Text = row2.Cells[3].Value.ToString();
                AddrTxt.Text = row2.Cells[4].Value.ToString();
            }

        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            var newform = new Login();
            newform.Show();
            this.Hide();
        }

        private void PatIdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\c1013892\Hospital Management System 2.0\Hospital Management System.db");
            conn.Open();

            string query3 = "Select Distinct Patient_Record.Patient_ID as ID, Patient_Record.first_name ||' '|| Patient_Record.last_name AS Patient from Patient_Record";
            SQLiteCommand cmd3 = new SQLiteCommand(query3, conn);

            DataTable dt3 = new DataTable();
            SQLiteDataAdapter adapter3 = new SQLiteDataAdapter(cmd3);
            adapter3.Fill(dt3);

            conn.Close();
            if (comboBox1.SelectedItem != null )
            {
                foreach (DataRow dr in dt3.Rows)
                {
                    if (dr["Patient"].ToString() == comboBox1.SelectedItem.ToString())
                    {
                        PatIdTxt.Text = dr["ID"].ToString();
                    }
                    comboBox1.Items.Add(dr["Patient"]);
                }

            }
        }

        private void Datetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
