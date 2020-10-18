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
    public partial class EditStaff2 : Form
    {
        public EditStaff2()
        {
            InitializeComponent();
        }

        private void EditStaff2_Load(object sender, EventArgs e)
        {
            textBox1.Text = User.u.getID(EditStaff.es.TextBox1Text);
            textBox2.Text = User.u.getFirstName(EditStaff.es.TextBox1Text);
            textBox3.Text = User.u.getLastName(EditStaff.es.TextBox1Text);
            textBox4.Text = EditStaff.es.TextBox1Text;
            textBox5.Text = User.u.getGender(EditStaff.es.TextBox1Text);
            textBox6.Text = User.u.getAge(EditStaff.es.TextBox1Text);
            textBox7.Text = User.u.getCellPhone(EditStaff.es.TextBox1Text);
            textBox8.Text = User.u.getBloodgroup(EditStaff.es.TextBox1Text);
            textBox9.Text = User.u.getEmergencyContact(EditStaff.es.TextBox1Text);
            textBox10.Text = User.u.getPost(EditStaff.es.TextBox1Text);
            textBox12.Text = User.u.getPassword(EditStaff.es.TextBox1Text);
            textBox13.Text = User.u.getType(EditStaff.es.TextBox1Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditStaff es = new EditStaff();
            es.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User.u.updateStaff(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox12.Text, textBox13.Text);
            DoctorManagement dm = new DoctorManagement();
            dm.Show();
            MessageBox.Show("Doctor Updated");
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login.l.Show();
            this.Hide();
        }
    }
}
