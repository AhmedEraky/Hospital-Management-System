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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            Doctor p = new Doctor();
            p.set_display(1);
            dataGridView2.DataSource = p.get_display(); 
            Patient p1 = new Patient();
            p1.set_display(2);
            dataGridView1.DataSource = p1.get_display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                Doctor p2 = new Doctor();
                p2.set_id(textBox1.Text);
                p2.Delete(textBox2.Text);

                Doctor p = new Doctor();
                p.set_display(1);
                dataGridView2.DataSource = p.get_display();

                Patient p1 = new Patient();
                p1.set_display(2);
                dataGridView1.DataSource = p1.get_display();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
