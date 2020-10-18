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
    public partial class RemoveStaff : Form
    {
        public RemoveStaff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffManagement.sm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            User.u.removeDoctor(textBox1.Text);
            MessageBox.Show("Staff Removed");
            StaffManagement.sm.Show();
            this.Hide();
            
        }
    }
}
