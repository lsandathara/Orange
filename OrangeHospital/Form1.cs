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

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace OrangeHospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void signuplink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void pwtxtbox_TextChanged(object sender, EventArgs e)
        {
          
            pwtxtbox.PasswordChar = '\u25CF';

            //Password should be less than 8 characters
            pwtxtbox.MaxLength = 8;

            if (String.IsNullOrEmpty(pwtxtbox.Text))
                loginbtn.Enabled = false;
            else
                loginbtn.Enabled = true;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source = ADMIN\\SQLEXPRESS; Initial Catalog = orangedb; Persist Security Info = True; User ID = sa; Password = !QAZ2wsx");   
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT COUNT(*) FROM Persons WHERE username='" + untxtbox.Text + "' AND password='" + pwtxtbox.Text + "'", connection);
            
            DataTable dt = new DataTable(); 
            adapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                //this.Hide();
                Home home = new Home();
                home.Show();

            }
            else
                MessageBox.Show("Invalid username or password");

        }

        private void untxtbox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(untxtbox.Text))
                loginbtn.Enabled = false;
            else
                loginbtn.Enabled = true;
        }
    }
}
