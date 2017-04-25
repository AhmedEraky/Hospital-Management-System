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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            Doctor d = new Doctor();
            d.set_display(1);
            dataGridView1.DataSource = d.get_display();
            Patient p = new Patient();
            p.set_display(2);
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

        private void button1_Click(object sender, EventArgs e)

        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(comboBox4.Text) || string.IsNullOrWhiteSpace(comboBox5.Text) || string.IsNullOrWhiteSpace(comboBox3.Text) || string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(comboBox2.Text))
                {
                    throw new AnExep();
                }
                else
                {
                    Patient pAdd;
                    if (comboBox5.SelectedItem.ToString() == "emergency")
                    {
                        pAdd = new emergency_patient();
                        pAdd.set(textBox1.Text, textBox3.Text, textBox4.Text, textBox2.Text, comboBox4.Text, textBox6.Text, "0", comboBox5.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text);
                    }
                    else
                    {
                        pAdd = new Normal_patient();
                        pAdd.set(textBox1.Text, textBox3.Text, textBox4.Text, textBox2.Text, comboBox4.Text, textBox6.Text, textBox5.Text, comboBox5.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text);

                    }
                    pAdd.addp();
                    Patient p = new Patient();
                    p.set_display(2);
                    dataGridView2.DataSource = p.get_display();
                }
            }
            catch (AnExep w)
            {
                w.get_msg();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: you must fill data correctly!");
            }
        }
      
    



        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Doctor d = new Doctor();
            d.set_display(2);
            dataGridView1.DataSource = d.get_display(); ;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Patient p = new Patient();
            p.set_display(2);
            dataGridView1.DataSource = p.get_display();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox5.SelectedItem.ToString() == "emergency")
                {
                    textBox5.Visible = false;
                    label8.Visible = false;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedItem.ToString() == "emergency")
            {
                textBox5.Visible = false;
                label8.Visible = false;


            }
            else if(comboBox5.SelectedItem.ToString() == "Normal")
            {
                textBox5.Visible = true;
                label8.Visible = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
