using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace _16._10._22
{
    public partial class Form1 : Form
    {
        int num1, num2;
        int count;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }
        private void b2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }
        private void b3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }
        private void b4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }
        private void b7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }
        private void b0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void bplus_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = num1.ToString() + "+";
        }
        private void bminus_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = num1.ToString() + "-";
        }
       
        private void bmulti_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = num1.ToString() + "*";
        }

        private void bdivide_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = num1.ToString() + "/";
        }
        private void bequal_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void bclear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
        }

        private void calculate()
        {
            switch(count)
            {
                case 1:
                    num2 = num1 + int.Parse(textBox1.Text);
                    textBox1.Text = num2.ToString();
                    break;
                case 2:
                    num2 = num1 - int.Parse(textBox1.Text);
                    textBox1.Text = num2.ToString();
                    break;
                case 3:
                    num2 = num1 * int.Parse(textBox1.Text);
                    textBox1.Text = num2.ToString();
                    break;
                case 4:
                    num2 = num1 / int.Parse(textBox1.Text);
                    textBox1.Text = num2.ToString();
                    break;
                default:
                    break;
            }
        }
        

    }
}
