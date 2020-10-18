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
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDatabaseDataSet.RoomTable' table. You can move, or remove it, as needed.
            //this.roomTableTableAdapter.Fill(this.hospitalDatabaseDataSet.RoomTable);
            dataGridView1.DataSource = User.u.getRoomList();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login.l.Show();
            this.Hide();
        }
    }
}
