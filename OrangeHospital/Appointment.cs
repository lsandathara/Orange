using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OrangeHospital
{
    public partial class Appointment : Form
    {
        SqlConnection con = new SqlConnection("Data Source = ADMIN\\SQLEXPRESS; Initial Catalog = orangedb;Integrated Security=False; User ID = testuser; Password = testuser");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        String querystring;
        int count = 0;

        public Appointment()
        {
            InitializeComponent();
            ListAppoitments();
            FillDoctorData();
            setRefNumber();
            //LoadDoc();
        }

        void FillDoctorData() {
            String query = "select * from dbo.Doctor";
            SqlConnection con = new SqlConnection("Data Source = ADMIN\\SQLEXPRESS; Initial Catalog = orangedb;Integrated Security=False; User ID = testuser; Password = testuser");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader;

            try {
                con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    string docname = reader.GetString(reader.GetOrdinal("name"));
                    name.Items.Add(docname);
                }

            }
            catch (Exception e) {
                
            }
        }

       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                if (appointmentId.Text != "" && pname.Text != "" && contactnum.Text != "" && email.Text != "" && name.Text != "" && appoinDate.Text != "")
                {

                    string query = "INSERT INTO Appointment VALUES(@appointmentID, @patientName, @contactNum, @email,@doctorname,@Date)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@appointmentID", appointmentId.Text);
                    cmd.Parameters.AddWithValue("@patientName", pname.Text);
                    cmd.Parameters.AddWithValue("@contactNum", contactnum.Text);
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    cmd.Parameters.AddWithValue("@doctorname", name.Text);
                    cmd.Parameters.AddWithValue("@Date", appoinDate.Value.Date.ToString("yyyyMMdd"));
                   

                    cmd.ExecuteNonQuery();
                    // cmd.ExecuteScalar();
                    con.Close();
                    MessageBox.Show("Appoinement Added Successfully!");
                    ListAppoitments();


                    ResetForm(this);


                }
                else
                {
                    MessageBox.Show("Fill all the Fields");
                }


            }
            catch
            {
                throw;
            }

        }

        private void appointmentId_TextChanged(object sender, EventArgs e)
        {
         
        }

        void setRefNumber() {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            appointmentId.Text = "REF-OH-" + randomNumber.ToString();
        }

        private void ResetForm(Control parent)
        {

            //clear all the textboxs
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    ((TextBox)(c)).Text = string.Empty;
                }
            }

            //clear comboboxes
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)(c)).Text = string.Empty;
                }
            }
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
         
        }

        private void Doc_Load(object sender, EventArgs e)
        {
            
        }
        private void name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constr = @"Data Source = ADMIN\\SQLEXPRESS; Initial Catalog = orangedb; Integrated Security = False; User ID = testuser; Password = testuser";
            using (SqlConnection con = new SqlConnection(constr))
            {
                 cmd = new SqlCommand("SELECT * FROM Doctor", con);
                con.Open();
                SqlDataReader sqlReader = cmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    name.Items.Add(sqlReader["name"].ToString());
                }

                sqlReader.Close();


            }
        }

        private void ListAppoitments()
        {

            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select appointmentID,patientName,contactNum,doctorname,Date from Appointment", con);
            adapt.Fill(dt);
            listappointments.DataSource = dt;
            con.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void name_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
                con = new SqlConnection("Data Source = ADMIN\\SQLEXPRESS; Initial Catalog = orangedb;Integrated Security=False; User ID = testuser; Password = testuser");
                con.Open();
                adapt = new SqlDataAdapter("select appointmentID,patientName,contactNum,doctorname,Date from Appointment where doctorname like '" + searchbyDoc.Text + "%'", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                listappointments.DataSource = dt;
                con.Close();
            
        }

        private void searchbyPatient_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source = ADMIN\\SQLEXPRESS; Initial Catalog = orangedb;Integrated Security=False; User ID = testuser; Password = testuser");
            con.Open();
            adapt = new SqlDataAdapter("select appointmentID,patientName,contactNum,doctorname,Date from Appointment where patientName like '" + searchbyPatient.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            listappointments.DataSource = dt;
            con.Close();

        }
    }
}
