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
    public delegate void Mydel();
    public partial class Login : Form
    {
        public static Login l = null;
        public Login()
        {
            if (l == null)
                l = this;
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void Error() { MessageBox.Show("Wrong Username or Password"); }
        public string TextBox1Text
        {
            set { this.textBox1.Text = value; }
            get { return this.textBox1.Text; }

        }

        public string TextBox2Text
        {
            set { this.textBox2.Text = value; }
            get { return this.textBox2.Text; }

        }

        public void button1_Click(object sender, EventArgs e)
        {

            Admin a1 = new Admin();
            Staff s1 = new Staff();
            Doctor d1 = new Doctor();
            Mydel d;
            User u1 = new User();

            int val = u1.logIn(TextBox1Text, TextBox2Text);

            if (val == 0)
            {
                d = a1.Show;
                d.Invoke();
                this.Hide();

            }

            else if (val == 1)
            {
                d = d1.Show;
                d.Invoke();
                this.Hide();
            }
            else if (val == 2)
            {
                d = s1.Show;
                d.Invoke();
                this.Hide();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
