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
    public partial class EditPatient : Form
    {
        public static EditPatient ep;
        public EditPatient()
        {
            ep = this;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffPatientList spl = new StaffPatientList();
            spl.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EditPatient2 ep2 = new EditPatient2();
            ep2.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditPatient_Load(object sender, EventArgs e)
        {

        }

        public string TextBox1Text
        {
            set { this.textBox1.Text = value; }
            get { return this.textBox1.Text; }
        }
    }
}
