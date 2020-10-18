﻿using System;
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
    public partial class AdminPatientSearch : Form
    {
        public AdminPatientSearch()
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
            AdminPatientList.apl.Show();
            this.Hide();
        }

        private void AdminPatientSearch_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = User.u.searchPatient(AdminPatientList.apl.TextBox1Text);
        }
    }
}
