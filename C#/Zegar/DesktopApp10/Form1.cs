using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp10
{
    public partial class Form1 : Form
    {

        DateTime aktualny;

        public string RzymskieZamiana(int arabska)
        {
            char[] tab = new char[10];
            int i = 0;

            while (arabska >= 50)
            {        
                tab[i] = 'L';
                arabska -= 50;
                i++;
            }

            while (arabska >= 10)
            {
                tab[i] = 'X';
                arabska -= 10;
                i++;
            }

            while (arabska >= 9)
            {
                arabska -= 9;
                tab[i] = 'I';
                i++;
                tab[i] = 'X';
                i++;
            }

            while (arabska >= 5)
            {
                tab[i] = 'V';
                arabska -= 5;
                i++;
            }

            while (arabska >= 4)
            {
                tab[i] = 'I';
                arabska -= 4;
                i++;
                tab[i] = 'V';
                i++;
            }

            while (arabska >= 1)
            {
                tab[i] = 'I';
                arabska -= 1;
                i++;
            }

            string zmieniona = new string(tab);
            return zmieniona;

        }



        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            aktualny = DateTime.Now;         
            int sekunda = aktualny.Second;
            int minuta = aktualny.Minute;
            int godzina = aktualny.Hour;
            

            richTextBox5.Text =RzymskieZamiana(sekunda).ToString();
            if (aktualny.Second % 2 == 0)
                richTextBox4.Text = "";
            else
               richTextBox4.Text = ":";

            richTextBox3.Text = RzymskieZamiana(minuta).ToString();
            if (aktualny.Second > 58)
                richTextBox2.Text = "";
            else
                richTextBox2.Text = ":";

            richTextBox1.Text = RzymskieZamiana(godzina).ToString();
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
