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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            Doctor d = new Doctor();
            d.set_display(1);
            dataGridView1.DataSource = d.get_display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Doctor D;
                if (comboBox1.SelectedItem.ToString() == "General")
                {
                    if (string.IsNullOrWhiteSpace(textBox5.Text)||string.IsNullOrWhiteSpace(comboBox1.Text))
                    {
                        throw new AnExep();
                    }

                  Doctor  D = new Doctor();
                    
                    D.set_type(comboBox1.Text);
                    D.set_spichialest("General Doctor");
                    D.set_id(textBox5.Text);
                    D.Update();
                    Doctor P = new Doctor();
                    P.set_display(1);
                    dataGridView1.DataSource = P.get_display();


                }
                else if (comboBox1.SelectedItem.ToString() == "Specialist")
                {
                    if (string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
                    {
                        throw new AnExep();
                    }

                    Doctor D = new Doctor();
                    D.set_type(comboBox1.Text);
                    D.set_spichialest(textBox4.Text);
                    D.set_id(textBox5.Text);
                    D.Update();
                    Doctor P = new Doctor();
                    P.set_display(1);
                    dataGridView1.DataSource = P.get_display();
                }
            }
            catch(AnExep w)
            {
                w.get_msg();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: you must fill data correctly!");
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Specialist")
            {
                label4.Visible = true;
                textBox4.Visible = true;
            }

            else if (comboBox1.SelectedItem.ToString() == "General")
            {
                label4.Visible = false;
                textBox4.Visible = false;

            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
