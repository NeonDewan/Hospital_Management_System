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
    public delegate void MydelRF();
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff s2 = new Staff();
            MydelRF d1 = s2.Show;
            d1.Invoke();
            this.Hide();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            User.u.PatientFirstName = textBox1.Text;
            User.u.PatientLastName = textBox2.Text;
            User.u.PatientAge = textBox3.Text;
            User.u.PatientBloodGroup = textBox6.Text;
            User.u.PatientAddress = textBox7.Text;
            User.u.PatientCellNo = textBox8.Text;
            User.u.PatientDoctor = textBox9.Text;
            User.u.PatientRoomNo = textBox10.Text;
            User.u.PatientNo = textBox4.Text;
            User.u.PatientDoctorID = textBox5.Text;

            if (radioButton1.Checked == true) { User.u.PatientGender = "Male"; }
            if (radioButton2.Checked == true) { User.u.PatientGender = "Female"; }

            User.u.addPatient(User.u.PatientNo, User.u.PatientFirstName, User.u.PatientLastName, User.u.PatientAge, User.u.PatientGender, User.u.PatientBloodGroup, User.u.PatientAddress, User.u.PatientCellNo, User.u.PatientDoctor, User.u.PatientRoomNo, User.u.PatientDoctorID);
            MessageBox.Show("Patient Added");
            this.Hide();
            Staff s = new Staff();
            s.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login.l.Show();
            this.Hide();
        }
    }
}
