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
    public partial class EditDoctor2 : Form
    {
        public EditDoctor2()
        {
            InitializeComponent();
        }

        private void EditDoctor2_Load(object sender, EventArgs e)
        {
            textBox1.Text = User.u.getID(EditDoctor.ed.TextBox1Text);
            textBox2.Text = User.u.getFirstName(EditDoctor.ed.TextBox1Text);
            textBox3.Text = User.u.getLastName(EditDoctor.ed.TextBox1Text);
            textBox4.Text = EditDoctor.ed.TextBox1Text;
            textBox5.Text = User.u.getGender(EditDoctor.ed.TextBox1Text);
            textBox6.Text = User.u.getAge(EditDoctor.ed.TextBox1Text);
            textBox7.Text = User.u.getCellPhone(EditDoctor.ed.TextBox1Text);
            textBox8.Text = User.u.getBloodgroup(EditDoctor.ed.TextBox1Text);
            textBox9.Text = User.u.getEmergencyContact(EditDoctor.ed.TextBox1Text);
            textBox10.Text = User.u.getPost(EditDoctor.ed.TextBox1Text);
            textBox11.Text = User.u.getEducation(EditDoctor.ed.TextBox1Text);
            textBox12.Text = User.u.getPassword(EditDoctor.ed.TextBox1Text);
            textBox13.Text = User.u.getType(EditDoctor.ed.TextBox1Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login.l.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditDoctor ed = new EditDoctor();
            ed.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User.u.updateDoctor(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox6.Text, textBox5.Text, textBox8.Text, textBox7.Text, textBox11.Text, textBox10.Text, textBox12.Text, textBox9.Text, textBox13.Text);
            DoctorManagement dm = new DoctorManagement();
            dm.Show();
            MessageBox.Show("Doctor Updated");
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
