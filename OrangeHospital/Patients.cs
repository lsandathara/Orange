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
    public partial class Patients : Form
    {
        SqlConnection con = new SqlConnection("Data Source = ADMIN\\SQLEXPRESS; Initial Catalog = orangedb; Persist Security Info = True; User ID = testuser; Password = testuser");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public Patients()
        {
            InitializeComponent();
            ListPatients();
        }

        private void addpatient_Click(object sender, EventArgs e)
        {
            try
            {
            

            if (refid.Text != "" && fname.Text != "" && gender.Text != "" && email.Text != "" && dob.Text != "" && contactnum.Text != "" &&  address.Text != "" && emergcontact.Text != "" && relationship.Text != "" &&  contactemg.Text != "")
            {

                string query = "INSERT INTO Patient VALUES(@refID, @fullname, @gender, @email,@dob, @contactnum, @address, @emergContact, @relationship,@contactEmg) ";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.AddWithValue("@refID", refid.Text);
                cmd.Parameters.AddWithValue("@fullname", fname.Text);
                cmd.Parameters.AddWithValue("@gender", gender.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@dob", dob.Text);
                cmd.Parameters.AddWithValue("@contactnum", contactnum.Text);
                cmd.Parameters.AddWithValue("@address", address.Text);
                cmd.Parameters.AddWithValue("@emergContact", emergcontact.Text);
                cmd.Parameters.AddWithValue("@relationship", relationship.Text);
                cmd.Parameters.AddWithValue("@contactEmg", contactemg.Text);

                cmd.ExecuteNonQuery();
                // cmd.ExecuteScalar();
                con.Close();
                MessageBox.Show("Patient Added Successfully!");
                ListPatients();
                

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

        private void ListPatients() {

            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select refID,fullname,gender,contactnum,emergContact,contactEmg from Patient", con);
            adapt.Fill(dt);
            listpatient.DataSource = dt;
            con.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
