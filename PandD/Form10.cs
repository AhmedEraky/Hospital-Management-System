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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            Patient p = new Patient();
            p.set_display(1);
            dataGridView1.DataSource = p.get_display();
            Doctor d = new Doctor();
            d.set_display(1);
            dataGridView2.DataSource = d.get_display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Patient p = new Patient();

                if (comboBox1.SelectedItem.ToString() == "emergency")
                {
                    if (string.IsNullOrWhiteSpace(textBox3.Text) ||  string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
                    {
                        throw new AnExep();
                    }
                   
                    textBox6.Visible = false;
                    label4.Visible = false;
                    p.set_dd(textBox3.Text);
                    p.set_DN(textBox2.Text);
                    p.set_room("0");
                    p.set_type(comboBox1.Text);
                    p.set_id(textBox4.Text);
                    p.update();

                }
                else
                {
                    if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
                    {
                        throw new AnExep();
                    }
                    p.set_dd(textBox3.Text);
                    p.set_DN(textBox2.Text);
                    p.set_room(textBox6.Text);
                    p.set_type(comboBox1.Text);
                    p.set_id(textBox4.Text);
                    p.update();
                }
                Patient p2 = new Patient();
                p2.set_display(1);
                dataGridView1.DataSource = p2.get_display();
                Doctor d = new Doctor();
                d.set_display(1);
                dataGridView2.DataSource = d.get_display();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem.ToString() == "emergency")
            {
                textBox6.Visible = false;
                label4.Visible = false;
            }
            else
            {
                textBox6.Visible = true;
                label4.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
