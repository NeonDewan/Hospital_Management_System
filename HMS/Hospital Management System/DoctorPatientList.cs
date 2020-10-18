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
    public delegate void MydelPL();
    public partial class DoctorPatientList : Form
    {
        public DoctorPatientList()
        {
            InitializeComponent();
        }

        private void PatientList_Load(object sender, EventArgs e)
        {
            string id = User.u.getID(Login.l.TextBox1Text);
            dataGridView1.DataSource = User.u.getDoctorPatientList(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doctor d1 = new Doctor();
            MydelPL d = d1.Show;
            d.Invoke();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login.l.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
