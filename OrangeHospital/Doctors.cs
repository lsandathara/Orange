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
    public partial class Doctors : Form
    {

        SqlConnection con = new SqlConnection("Data Source = ADMIN\\SQLEXPRESS; Initial Catalog = orangedb; Persist Security Info = True; User ID = testuser; Password = testuser");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public Doctors()
        {
            InitializeComponent();
            ListDoctors();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void addpatient_Click(object sender, EventArgs e)
        {
            try
            {
              if (docrefid.Text != "" && doctorname.Text != "" && docgender.Text != "" && docemail.Text != "" && doccontactnum.Text != "" && specialization.Text != "")  { 
           
                string query = "INSERT INTO Doctor VALUES(@docrefID, @name, @gender, @email, @contactnum, @specialization) ";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.AddWithValue("@docrefID", docrefid.Text);
                cmd.Parameters.AddWithValue("@name", doctorname.Text);
                cmd.Parameters.AddWithValue("@gender", docgender.Text);
                cmd.Parameters.AddWithValue("@email", docemail.Text);
                cmd.Parameters.AddWithValue("@contactnum", doccontactnum.Text);
                cmd.Parameters.AddWithValue("@specialization", specialization.Text);

                cmd.ExecuteNonQuery();
               // cmd.ExecuteScalar();
                con.Close();
                MessageBox.Show("Doctor Added Successfully!");
                ListDoctors();
                //ListDoctors();

                ResetForm(this);


            }
            else{
                MessageBox.Show("Fill all the Fields");
            }


            }
            catch
            {
                throw;
            }
        }

        private void ResetForm(Control parent)
        {
            
                foreach (Control c in parent.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        ((TextBox)(c)).Text = string.Empty;
                    }
                }

            foreach (Control c in parent.Controls) {
                if (c.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)(c)).Text = string.Empty;
                }
            }
            
        }

        private void ListDoctors() {
           
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select docrefID,name,email,contactnum,specialization from Doctor", con);
                adapt.Fill(dt);
                listdoctors.DataSource = dt;
                con.Close();
            

        }

        private void listdoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Doctors_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void doctorname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void docrefid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void specialization_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void docgender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void docemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void doccontactnum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
