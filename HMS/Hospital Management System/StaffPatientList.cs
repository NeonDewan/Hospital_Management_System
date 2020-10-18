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
    public delegate void MydelSPL();
    public partial class StaffPatientList : Form
    {
        public static StaffPatientList spl;
        
        public StaffPatientList()
        {
            spl = this;
            InitializeComponent();
        }

        public string TextBox1Text
        {

            set { this.textBox1.Text = value; }
            get { return this.textBox1.Text; }
        }

        private void StaffPatientList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDatabaseDataSet.PatientsTable' table. You can move, or remove it, as needed.
           // this.patientsTableTableAdapter.Fill(this.hospitalDatabaseDataSet.PatientsTable);
            
            dataGridView1.DataSource = User.u.getPatientList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff s1 = new Staff();
            MydelSPL d = s1.Show;
            d.Invoke();
            this.Hide(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemovePatient rp = new RemovePatient();
            rp.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login.l.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditPatient ep = new EditPatient();
            ep.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StaffPatientSearch sps = new StaffPatientSearch();
            sps.Show();
            this.Hide();
        }
    }
}
