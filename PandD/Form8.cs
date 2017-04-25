using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PandD
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            Patient p = new Patient();
            p.set_display(1);
            dataGridView2.DataSource = p.get_display();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient p2 = new Patient();
            p2.set_id(textBox1.Text);
            p2.Delete();
            Patient p = new Patient();
            p.set_display(1);
            dataGridView2.DataSource = p.get_display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f3 = new Form2();
            f3.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Patient p = new Patient();
            p.set_display(1);
            dataGridView2.DataSource = p.get_display();
        }
    }
}
