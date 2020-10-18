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
    public partial class AddDoctor : Form
    {
        public AddDoctor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorManagement.dm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
          
            User.u.DocFirstName= textBox1.Text;
            User.u.DocLastName = textBox2.Text;
            User.u.DocAge = textBox3.Text;
            User.u.DocBloodGroup = textBox6.Text;
            User.u.DocID = textBox7.Text;
            User.u.DocCellno = textBox8.Text;
            User.u.DocEducation = textBox9.Text;
            User.u.DocPost = textBox10.Text;
            User.u.DocUserName = textBox11.Text;
            User.u.DocPassword = textBox4.Text;
            User.u.DocEmergencyContact = textBox5.Text;
            User.u.Type = Convert.ToInt32(textBox12.Text);
            if (radioButton1.Checked == true) { User.u.DocGender = "Male"; }
            if (radioButton2.Checked == true) { User.u.DocGender = "Female"; }
            User.u.addDoctor(User.u.DocID, User.u.DocFirstName, User.u.DocLastName, User.u.DocUserName, User.u.DocAge, User.u.DocGender, User.u.DocBloodGroup, User.u.DocCellno, User.u.DocEducation, User.u.DocPost, User.u.DocPassword, User.u.DocEmergencyContact, User.u.Type);
            MessageBox.Show("Doctor Added");
            DoctorManagement.dm.Show();
            this.Hide();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            Login.l.Show();
            this.Hide();
            
        }
    }
}
