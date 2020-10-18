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
    public partial class StaffPatientSearch : Form
    {
        public StaffPatientSearch()
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
            StaffPatientList.spl.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StaffPatientSearch_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = User.u.searchPatient(StaffPatientList.spl.TextBox1Text);
        }
    }
}
