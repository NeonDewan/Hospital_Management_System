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
    public delegate void MydelA();
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(User.u.getDoctorCount());
            label6.Text = Convert.ToString(User.u.getPatientCount());
            label5.Text = Convert.ToString(User.u.getStaffCount());
            label10.Text = Convert.ToString(User.u.getLastName(Login.l.TextBox1Text));
            label9.Text = Convert.ToString(User.u.getFirstName(Login.l.TextBox1Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminProfile ap = new AdminProfile();
            MydelA d1 = ap.Show;
            d1.Invoke();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminPatientList pm = new AdminPatientList();
            MydelA d2 = pm.Show;
            d2.Invoke();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Room r = new Room();
            MydelA d3 = r.Show;
            d3.Invoke();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StaffManagement sm = new StaffManagement();
            MydelA d5 = sm.Show;
            d5.Invoke();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Accounts acc = new Accounts();
            MydelA d6 = acc.Show;
            d6.Invoke();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorManagement dm = new DoctorManagement();
            MydelA d7 = dm.Show;
            d7.Invoke();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Login.l.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
