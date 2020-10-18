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
    public partial class DoctorPatientDischarge : Form
    {
        public DoctorPatientDischarge()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doctor d = new Doctor();
            d.Show();
            this.Hide();
        }

        private void DoctorPatientDischarge_Load(object sender, EventArgs e)
        {
            string id = User.u.getID(Login.l.TextBox1Text);
            dataGridView1.DataSource = User.u.getDoctorPatientList(id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User.u.PatientDischarge(textBox2.Text);
            MessageBox.Show("Patient Discharged By Doctor");
            string id = User.u.getID(Login.l.TextBox1Text);
            dataGridView1.DataSource = User.u.getDoctorPatientList(id);
        }
    }
}
