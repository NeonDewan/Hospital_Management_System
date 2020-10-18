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
    public delegate void MydelAR();
    public partial class AvailableRooms : Form
    {
        public AvailableRooms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff s1 = new Staff();
            MydelAR d = s1.Show;
            d.Invoke();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login.l.Show();
            this.Hide();
        }

        private void AvailableRooms_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = User.u.getAvailableRooms();
        }
    }
}
