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
    public delegate void MydelDP();
    public partial class Doctorprofile : Form
    {
        public Doctorprofile()
        {
            InitializeComponent();
        }
       

        private void Doctorprofile_Load(object sender, EventArgs e)
        {
            try
            {
                

                this.label11.Text = Convert.ToString(User.u.getFirstName(Login.l.TextBox1Text));
                this.label12.Text = Convert.ToString(User.u.getLastName(Login.l.TextBox1Text));
                this.label13.Text = Login.l.TextBox1Text;
                this.label14.Text = Convert.ToString(User.u.getGender(Login.l.TextBox1Text));
                this.label15.Text = Convert.ToString(User.u.getAge(Login.l.TextBox1Text));
                this.label16.Text = Convert.ToString(User.u.getCellPhone(Login.l.TextBox1Text));
                this.label17.Text = Convert.ToString(User.u.getPost(Login.l.TextBox1Text));
                this.label18.Text = Convert.ToString(User.u.getBloodgroup(Login.l.TextBox1Text));
                this.label19.Text = Convert.ToString(User.u.getEducation(Login.l.TextBox1Text));
                this.label20.Text = Convert.ToString(User.u.getEmergencyContact(Login.l.TextBox1Text));
            }
            catch { throw; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doctor d1 = new Doctor();
            MydelDP d = d1.Show;
            d.Invoke();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login.l.Show();
            this.Hide();
        }
    }
}
