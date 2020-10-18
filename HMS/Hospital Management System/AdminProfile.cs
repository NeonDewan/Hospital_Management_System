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
    public delegate void MydelAP();
    public partial class AdminProfile : Form
    {
        public AdminProfile()
        {
            InitializeComponent();
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {
           

            this.label10.Text = Convert.ToString(User.u.getFirstName(Login.l.TextBox1Text));
            this.label11.Text = Convert.ToString(User.u.getLastName(Login.l.TextBox1Text));
            this.label12.Text = Login.l.TextBox1Text;
            this.label13.Text = Convert.ToString(User.u.getGender(Login.l.TextBox1Text));
            this.label14.Text = Convert.ToString(User.u.getAge(Login.l.TextBox1Text));
            this.label15.Text = Convert.ToString(User.u.getCellPhone(Login.l.TextBox1Text));
            this.label16.Text = Convert.ToString(User.u.getBloodgroup(Login.l.TextBox1Text));
            this.label17.Text = Convert.ToString(User.u.getEmergencyContact(Login.l.TextBox1Text));
            this.label18.Text = Convert.ToString(User.u.getPost(Login.l.TextBox1Text));
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            MydelAP d1 = a.Show;
            d1.Invoke();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login.l.Show();
            this.Hide();
        }
    }
}
