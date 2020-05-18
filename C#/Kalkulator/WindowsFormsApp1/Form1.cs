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
        }
        
        string FirstNumber;
        string SecondNumber;
        char action = ' ';

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            action = '/';
            richTextBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            action = '*';
            richTextBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            action = '-';
            richTextBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            action = '+';
            richTextBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch (action)
            {
                case ('+'):
                    richTextBox1.Text = (int.Parse(FirstNumber) + int.Parse(SecondNumber)).ToString();
                    break;
                case ('-'):
                    richTextBox1.Text = (int.Parse(FirstNumber) - int.Parse(SecondNumber)).ToString();
                    break;
                case ('*'):
                    richTextBox1.Text = (int.Parse(FirstNumber) * int.Parse(SecondNumber)).ToString();
                    break;
                case ('/'):
                    richTextBox1.Text = (int.Parse(FirstNumber) / int.Parse(SecondNumber)).ToString();
                    break;

            }

            FirstNumber = "";
            SecondNumber = "";
            action = ' ';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Dzialanie(9);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Dzialanie(8);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Dzialanie(7);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dzialanie(6);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dzialanie(5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dzialanie(4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dzialanie(3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dzialanie(2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dzialanie(1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Dzialanie(0);

        }
        private void Dzialanie(int number)
        {
            if (action == ' ')
            {


                FirstNumber += number;
                richTextBox1.Text = FirstNumber;
            }
            else
            {
                SecondNumber += number;
                richTextBox1.Text = SecondNumber;
            }
        }
    }



}
