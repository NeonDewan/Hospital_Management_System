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
    public partial class DoctorManagement : Form
    {
        public static DoctorManagement dm;
        public DoctorManagement()
        {
            dm = this;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddDoctor ad = new AddDoctor();
            ad.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveDoctor rd = new RemoveDoctor();
            rd.Show();
            this.Hide();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login.l.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EditDoctor ed = new EditDoctor();
            ed.Show();
            this.Hide();
        }

        private void DoctorManagement_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = User.u.getDoctorList();
        }

        public string TextBox1Text
        {

            set { this.textBox1.Text = value; }
            get { return this.textBox1.Text; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DoctorSearch ds = new DoctorSearch();
            ds.Show();
            this.Hide();
                
        }
    }
}
