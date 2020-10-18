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
    public partial class EditStaff : Form
    {
        public static EditStaff es;
        public string TextBox1Text
        {

            set { this.textBox1.Text = value; }
            get { return this.textBox1.Text; }
        }

        public EditStaff()
        {
            es = this;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffManagement sm = new StaffManagement();
            sm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EditStaff2 es2 = new EditStaff2();
            es2.Show();
            this.Hide();
        }

        private void EditStaff_Load(object sender, EventArgs e)
        {

        }
    }
}
