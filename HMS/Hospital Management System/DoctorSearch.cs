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
    public partial class DoctorSearch : Form
    {
        public DoctorSearch()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login.l.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoctorManagement.dm.Show();
            this.Hide();
        }

        private void DoctorSearch_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = User.u.searchUser(DoctorManagement.dm.TextBox1Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
