using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wisielec2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        string[] slowa = {
            "ANAKONDA",
            "FIBONACCI",
            "OKON"
        };
        string podana, haslo;
        int i, ilosc, los;
        static char[] tab;
        int blad = 0;

        private void button1_Click(object sender, EventArgs e) //losuj
        {
            label2.Text = "";
            los = random.Next(0, 3);
            haslo = slowa[los];

            ilosc = haslo.Length;
            tab = new char[ilosc];

            for (i = 0; i < ilosc; i++)
            {
                tab[i] = '_';
            }

            for (i = 0; i < ilosc; i++)
            {
                label2.Text += " " + tab[i] + " ";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //sprawdz
        {
            
            podana = textBox1.Text;
            label2.Text = "";
            textBox1.Text = "";

            for (i=0; i<ilosc; i++)
            {
                if (podana[0] == haslo[i])
                {
                    tab[i] = podana[0];
                }
                if (podana[0] != haslo[i])
                {
                    blad++;
                }
            }
            blad = blad - ilosc + 1;


            for (i = 0; i < ilosc; i++)
            {
                label2.Text += " " + tab[i] + " ";
            }


            if (blad==1)
            {
                label5.Text = "//\\";
            }
            if (blad == 2)
            {
                label6.Text = " || ";
            }
            if (blad == 3)
            {
                label7.Text = " || ";
            }
            if (blad == 4)
            {
                label8.Text = "  //";
            }
            if (blad == 5)
            {
                label9.Text = "==";
            }
            if (blad == 6)
            {
                label10.Text = " | ";
            }
            if (blad == 7)
            {
                label11.Text = " O ";
            }
            if (blad == 8)
            {
                label12.Text = " /|/";
            }
            if (blad == 9)
            {
                label13.Text = " //";
            }
            if (blad == 10)
            {
                richTextBox1.Text = "PRZEGRALES";
            }

            label4.Text += podana[0] + " ";

        }

        private void label5_Click(object sender, EventArgs e) //5-12
        {

        }

        Random random = new Random();

    }
}
