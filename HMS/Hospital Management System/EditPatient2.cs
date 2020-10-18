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
    public partial class EditPatient2 : Form
    {
       
        public EditPatient2()
        {
            InitializeComponent();
        }

        private void EditPatient2_Load(object sender, EventArgs e)
        {
            textBox1.Text = EditPatient.ep.TextBox1Text; 
            textBox2.Text = User.u.getPatientFirstName(EditPatient.ep.TextBox1Text);
            textBox3.Text = User.u.getPatientLastName(EditPatient.ep.TextBox1Text);
            textBox4.Text = User.u.getPatientAge(EditPatient.ep.TextBox1Text);
            textBox5.Text = User.u.getPatientGender(EditPatient.ep.TextBox1Text);
            textBox6.Text = User.u.getPatientBloodGroup(EditPatient.ep.TextBox1Text);
            textBox7.Text = User.u.getPatientAddress(EditPatient.ep.TextBox1Text);
            textBox8.Text = User.u.getPatientCell(EditPatient.ep.TextBox1Text);
            textBox9.Text = User.u.getPatientDoctor(EditPatient.ep.TextBox1Text);
            textBox10.Text = User.u.getPatientRoomNo(EditPatient.ep.TextBox1Text);
            textBox11.Text = User.u.getPatientDoctorID(EditPatient.ep.TextBox1Text);  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User.u.updatePatient(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text,textBox11.Text);
            MessageBox.Show("Patient Updated");
            StaffPatientList spl = new StaffPatientList();
            spl.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login.l.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditPatient.ep.Show();
            this.Hide();
        }
    }
}
