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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Patient p = new Patient();
            p.set_display(1);
            dataGridView1.DataSource = p.get_display();
        }

        //search by date


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Patient p = new Patient();

                if (string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(comboBox2.Text) || string.IsNullOrWhiteSpace(comboBox3.Text))
                {
                    throw (new AnExep());
                }

                p.setdate(comboBox1.Text + "-" + comboBox2.Text + "-" + comboBox3.Text);
                p.set_search(1);
                dataGridView1.DataSource = p.get_search();
            }
            catch (AnExep)
            {

            }
        }





        private void button3_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.set_display(1);
            dataGridView1.DataSource = p.get_display();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        //search by type
        private void button2_Click(object sender, EventArgs e)
        {
            Patient p;
            if(comboBox4.Text=="Normal")
            {
                 p = new Normal_patient();
            }
            else
            {
                 p = new emergency_patient();
            }
            p.set_type(comboBox4.Text);
            //type
            p.set_search(3);
            dataGridView1.DataSource = p.get_search();


        }
        //search by name
        private void button4_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.set_name(textBox1.Text);
            //name search
            p.set_search(2);
            dataGridView1.DataSource = p.get_search();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f3 = new Form2();
            f3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
