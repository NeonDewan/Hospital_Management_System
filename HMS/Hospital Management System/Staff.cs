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
    public delegate void MydelS();
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistrationForm rf = new RegistrationForm();
            MydelS d2 = rf.Show;
            d2.Invoke();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staffprofile sp = new Staffprofile();
            MydelS d1 = sp.Show;
            d1.Invoke();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
             StaffPatientList spl = new StaffPatientList();
            MydelS d3 = spl.Show;
            d3.Invoke();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AvailableDoctors ad = new AvailableDoctors();
            MydelS d4 = ad.Show;
            d4.Invoke();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AvailableRooms ar = new AvailableRooms();
            MydelA d5 = ar.Show;
            d5.Invoke();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            DischargedPatients dp = new DischargedPatients();
            dp.Show();
            this.Hide();
            
            //PatientDischarge pd = new DoctorPatientDischarge();
           // MydelA d6 = pd.Show;
            //d6.Invoke();
            //this.Hide();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            label10.Text = Convert.ToString(User.u.getLastName(Login.l.TextBox1Text));
            label9.Text = Convert.ToString(User.u.getFirstName(Login.l.TextBox1Text));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login.l.Show();
            this.Hide();
        }
    }
}
