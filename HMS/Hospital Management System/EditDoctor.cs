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
    public partial class EditDoctor : Form
    {
        public static EditDoctor ed; 
        public EditDoctor()
        {
            ed = this;
            InitializeComponent();
        }

        public string TextBox1Text 
        {

            set { this.textBox1.Text = value; }
            get { return this.textBox1.Text; }
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
             
            EditDoctor2 ed2 = new EditDoctor2();
            ed2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorManagement dm = new DoctorManagement();
            dm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditDoctor_Load(object sender, EventArgs e)
        {

        }
    }
}
