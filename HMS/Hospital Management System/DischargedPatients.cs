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
    public partial class DischargedPatients : Form
    {
        public DischargedPatients()
        {
            InitializeComponent();
        }

        private void DischargedPatients_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = User.u.dischargedPatientList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemovePatient rp = new RemovePatient();
            rp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff s = new Staff();
            s.Show();
            this.Hide();
        }
    }
}
