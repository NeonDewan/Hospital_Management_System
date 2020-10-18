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
    public partial class StaffManagement : Form
    {
        public static StaffManagement sm;
        public StaffManagement()
        {
            sm = this;
            InitializeComponent();
        }

        public string TextBox1Text
        {

            set { this.textBox1.Text = value; }
            get { return this.textBox1.Text; }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStaff asf = new AddStaff();
            asf.Show();
            this.Hide();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveStaff rs = new RemoveStaff();
            rs.Show();
            this.Hide();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login.l.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EditStaff es = new EditStaff();
            es.Show();
            this.Hide();
        }

        private void StaffManagement_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = User.u.getStaffList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StaffSearch ss = new StaffSearch();
            ss.Show();
            this.Hide();
        }
    }
}
