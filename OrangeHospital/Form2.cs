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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void pwtxtbox_TextChanged(object sender, EventArgs e)
        {
           
            pwtxtbox.PasswordChar = '\u25CF';

            //Password should be less than 8 characters
            pwtxtbox.MaxLength = 8;

            
        }

        private void signupbtn_Click(object sender, EventArgs e)

        {
            //Field Validation
            if (!(String.IsNullOrEmpty(fnametxtbox.Text) && String.IsNullOrEmpty(untxtbox.Text) && 
                String.IsNullOrEmpty(pwtxtbox.Text) && String.IsNullOrEmpty(gendercmbox.Text)))
                signupbtn.Enabled = true;
            else
                signupbtn.Enabled = false;

            try
            {
                SqlConnection con = new SqlConnection("Data Source = ADMIN\\SQLEXPRESS; Initial Catalog = orangedb; Persist Security Info = True; User ID = sa; Password = !QAZ2wsx");
                string query = "INSERT INTO Persons VALUES(@fullname, @username, @password, @gender) ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@fullname", fnametxtbox.Text);
                cmd.Parameters.AddWithValue("@username", untxtbox.Text);
                cmd.Parameters.AddWithValue("@password", pwtxtbox.Text);
                cmd.Parameters.AddWithValue("@gender", gendercmbox.Text);

                con.Open();
                cmd.ExecuteScalar();
                con.Close();
                MessageBox.Show("Registered Successfully!");

            }
            catch
            {
                throw;
            }

            Form1 form1 = new Form1();
            form1.Show();
        }

        private void fnametxtbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void untxtbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void gendercmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
