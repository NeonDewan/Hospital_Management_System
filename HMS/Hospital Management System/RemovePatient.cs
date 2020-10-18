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
    public partial class RemovePatient : Form
    {
        public RemovePatient()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            User.u.removePatient(textBox1.Text);
            MessageBox.Show("Patient Removed");
            DischargedPatients dp = new DischargedPatients();
            dp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DischargedPatients dp = new DischargedPatients();
            dp.Show();
            this.Hide();
        }
    }
}
