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
    public delegate void MydelD();
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Doctor_Load(object sender, EventArgs e)
        {
              
              label10.Text = Convert.ToString(User.u.getLastName(Login.l.TextBox1Text));
              label9.Text = Convert.ToString(User.u.getFirstName(Login.l.TextBox1Text));
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Doctorprofile dp = new Doctorprofile();
            MydelD d1 = dp.Show;
            d1.Invoke();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DoctorPatientDischarge dpd = new DoctorPatientDischarge();
            dpd.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrescriptionForm pf = new PrescriptionForm();
            MydelD d3 = pf.Show;
            d3.Invoke();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoctorPatientList pl = new DoctorPatientList();
            MydelD d5 = pl.Show;
            d5.Invoke();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login.l.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
