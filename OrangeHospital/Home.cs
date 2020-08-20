using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrangeHospital
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void patients_Click(object sender, EventArgs e)
        {
            Patients patient = new Patients();
            patient.Show();
        }

        private void doctors_Click(object sender, EventArgs e)
        {
            Doctors doctor = new Doctors();
            doctor.Show();
        }

        private void appointments_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            appointment.Show();
        }
    }
}
