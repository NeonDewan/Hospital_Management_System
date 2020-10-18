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
    public delegate void MydelPF();
    public partial class PrescriptionForm : Form
    {

        public string PName
        {

            set { this.textBox1.Text = value; }
            get { return this.textBox1.Text; }
        }

        public string PAge
        {

            set { this.textBox2.Text = value; }
            get { return this.textBox2.Text; }
        }

        public string Medicine
        {

            set { this.textBox3.Text = value; }
            get { return this.textBox3.Text; }
        }

        public string Advice
        {

            set { this.textBox4.Text = value; }
            get { return this.textBox4.Text; }
        }

        public string Test
        {

            set { this.textBox5.Text = value; }
            get { return this.textBox5.Text; }
        }

        public static PrescriptionForm pf;
        public PrescriptionForm()
        {
            pf = this;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doctor d2 = new Doctor();
            MydelPF d1 = d2.Show;
            d1.Invoke();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login.l.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PrescriptionForm_Load(object sender, EventArgs e)
        {
            label2.Text = User.u.getFirstName(Login.l.TextBox1Text);
            label3.Text = User.u.getEducation(Login.l.TextBox1Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
            PrescriptionForm2 pf = new PrescriptionForm2();
            pf.Show();
           

        }
    }
}
