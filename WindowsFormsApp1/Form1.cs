using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            List<string> TestList = new List<string> { "12", "15", "18", "21", "24" };
            listBox1.DataSource = TestList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Index = listBox1.SelectedIndex;
            if (Index.Equals(0))
            {
                var nums = Program.F12(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text));
                label3.Text = "X= " + nums[0] + " Y= " + nums[1];
            } 
            else if (Index.Equals(1))
            {
                var nums = Program.F15(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text));
                label3.Text = "X= " + nums[0] + " Y= " + nums[1];
            } 
            else if (Index.Equals(2))
            {
                var nums = Program.F18(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text), Convert.ToInt16(textBox3.Text),
                    Convert.ToInt16(textBox4.Text), Convert.ToInt16(textBox5.Text), Convert.ToInt16(textBox6.Text));
                label3.Text = "X=" + nums[0] + " Y= " + nums[1];
            } 
            else if (Index.Equals(3))
            {
                var num = Program.F21(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text), Convert.ToInt16(textBox3.Text));
                label3.Text = "MAX= " + num;
            }
            else if (Index.Equals(4))
            {
                label3.Text = Program.f24(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Index = listBox1.SelectedIndex;
            if (Index.Equals(2))
            {
                label4.Text = "X*";
                label5.Text = "Y*";
                label6.Text = "=";
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                textBox3.Show();
                textBox4.Show();
                textBox5.Show();
                textBox6.Show();
            }
            else if (Index.Equals(3))
            {
                label6.Show();
                textBox3.Show();
                label4.Text = "X=";
                label5.Text = "Y=";
                label6.Text = "Z=";
                label7.Hide();
                label8.Hide();
                label9.Hide();
                textBox4.Hide();
                textBox5.Hide();
                textBox6.Hide();
            }
            else
            {
                label4.Text = "X=";
                label5.Text = "Y=";
                label6.Text = "Z=";
                label6.Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                textBox3.Hide();
                textBox4.Hide();
                textBox5.Hide();
                textBox6.Hide();
            }
        }
    }
}
