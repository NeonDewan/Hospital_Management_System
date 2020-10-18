using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class AdminPatientList : Form
    {
        public static AdminPatientList apl;
        public AdminPatientList()
        {
            apl = this;
            InitializeComponent();
        }

        public string TextBox1Text
        {

            set { this.textBox1.Text = value; }
            get { return this.textBox1.Text; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*User u = new User();
            this.dataGridView1.Visible = true;
            dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = u.getPatientList();*/
        }

        private void AdminPatientList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDatabaseDataSet.PatientsTable' table. You can move, or remove it, as needed.
           // this.patientsTableTableAdapter.Fill(this.hospitalDatabaseDataSet.PatientsTable);
            dataGridView1.DataSource = User.u.getPatientList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login.l.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminPatientSearch aps = new AdminPatientSearch();
            aps.Show();
            this.Hide();
        }
        
    }
}
