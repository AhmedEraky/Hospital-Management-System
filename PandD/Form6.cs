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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            Doctor d = new Doctor();
            d.set_display(2);
            dataGridView1.DataSource = d.get_display();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Doctor d = new Doctor();
            d.set_display(2);
            dataGridView1.DataSource = d.get_display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doctor d = new Doctor();
            d.set_type(comboBox4.Text);
            d.set_search(2);
            dataGridView1.DataSource = d.get_search();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Doctor d = new Doctor();
            d.set_name(textBox1.Text);
            d.set_search(1);
            dataGridView1.DataSource = d.get_search();
        }
    }
}
