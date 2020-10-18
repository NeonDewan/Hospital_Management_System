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
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffManagement.sm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            User.u.StaffFirstName = textBox1.Text;
            User.u.StaffLastName = textBox2.Text;
            User.u.StaffAge = textBox3.Text;
            User.u.StaffBloodGroup = textBox6.Text;
            User.u.StaffID = textBox7.Text;
            User.u.StaffCellno = textBox8.Text;
            User.u.StaffPost = textBox10.Text;
            User.u.StaffUserName = textBox11.Text;
            User.u.StaffPassword = textBox4.Text;
            User.u.StaffEmergencyContact = textBox5.Text;
            User.u.Type = Convert.ToInt32(textBox12.Text);
            if (radioButton1.Checked == true) { User.u.StaffGender = "Male"; }
            if (radioButton2.Checked == true) { User.u.StaffGender = "Female"; }
            User.u.addStaff(User.u.StaffID, User.u.StaffFirstName, User.u.StaffLastName, User.u.StaffUserName, User.u.StaffAge, User.u.StaffGender, User.u.StaffBloodGroup, User.u.StaffCellno, User.u.StaffPost, User.u.StaffPassword, User.u.StaffEmergencyContact, User.u.Type);
            MessageBox.Show("Staff Added");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login.l.Show();
            this.Hide();
        }
    }
}
