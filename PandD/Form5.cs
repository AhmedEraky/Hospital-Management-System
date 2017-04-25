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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            Doctor d = new Doctor();
            d.set_display(2);
            dataGridView1.DataSource = d.get_display();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Doctor D;
                
                    if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(comboBox4.Text) || string.IsNullOrWhiteSpace(comboBox5.Text))
                    {
                        MessageBox.Show("fill all data please");
                    }
                
                else if (comboBox5.SelectedItem.ToString() == "Specialist")
                {
                    D = new Doctor();
                    D.set(textBox1.Text, textBox3.Text, textBox2.Text, comboBox4.Text, comboBox5.Text, textBox4.Text);
                    D.insert();
                }
                else if(comboBox5.SelectedItem.ToString() =="General")
                {
                    D = new Doctor();
                    D.set(textBox1.Text, textBox3.Text, textBox2.Text, comboBox4.Text, comboBox5.Text, "General Doctor");
                    D.insert();
                }
                    
                
                Doctor D2 = new Doctor();

                D2.set_display(2);
                dataGridView1.DataSource = D2.get_display();

            }
            catch (Exception)
            {
                MessageBox.Show("Error: you must fill data correctly!");
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedItem.ToString() == "Specialist")
            {
                label4.Visible = true;
                textBox4.Visible = true;
            }

            else if (comboBox5.SelectedItem.ToString() == "General")
            {
                label4.Visible = false;
                textBox4.Visible = false;

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        //    try
        //    {
        //        if (comboBox5.SelectedItem.ToString() == "emergency")
        //        {
        //            textBox4.Visible = false;
        //            label4.Visible = false;
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("error");
        //    }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
