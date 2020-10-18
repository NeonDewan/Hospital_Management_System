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
    public delegate void MydelAD();
    public partial class AvailableDoctors : Form
    {
        public AvailableDoctors()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff s1 = new Staff();
            MydelAD d = s1.Show;
            d.Invoke();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login.l.Show();
            this.Hide();
        }
    }
}
