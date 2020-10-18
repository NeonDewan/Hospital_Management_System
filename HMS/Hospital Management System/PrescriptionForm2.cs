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
    public partial class PrescriptionForm2 : Form
    {
       
        public PrescriptionForm2()
        {
           
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PrescriptionForm2_Load(object sender, EventArgs e)
        {
            label2.Text = User.u.getFirstName(Login.l.TextBox1Text);
            label3.Text = User.u.getEducation(Login.l.TextBox1Text);
            label12.Text = PrescriptionForm.pf.PName;
            label11.Text = PrescriptionForm.pf.PAge;
            label10.Text = PrescriptionForm.pf.Medicine;
            label9.Text = PrescriptionForm.pf.Advice;
            label8.Text = PrescriptionForm.pf.Test;


        }
    }
}
