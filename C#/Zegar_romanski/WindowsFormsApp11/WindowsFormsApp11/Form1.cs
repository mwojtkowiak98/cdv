using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zegarek

{
    public partial class Form1 : Form
    {
        
        DateTime aktualny;
        public Form1()
        {
            InitializeComponent();

            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox17.Hide();
            textBox19.Hide();
            textBox21.Hide();
            button2.Hide();
        }
        public static string Rzymskie(int liczba)
        {
            if (liczba < 0) return " ";
            if (liczba < 1) return String.Empty;
            if (liczba >= 1000) return "M" + Rzymskie(liczba - 1000);
            if (liczba >= 900) return "CM" + Rzymskie(liczba - 900);
            if (liczba >= 500) return "D" + Rzymskie(liczba - 500);
            if (liczba >= 400) return "CD" + Rzymskie(liczba - 400);
            if (liczba >= 100) return "C" + Rzymskie(liczba - 100);
            if (liczba >= 90) return "XC" + Rzymskie(liczba - 90);
            if (liczba >= 50) return "L" + Rzymskie(liczba - 50);
            if (liczba >= 40) return "XL" + Rzymskie(liczba - 40);
            if (liczba >= 10) return "X" + Rzymskie(liczba - 10);
            if (liczba >= 9) return "IX" + Rzymskie(liczba - 9);
            if (liczba >= 5) return "V" + Rzymskie(liczba - 5);
            if (liczba >= 4) return "IV" + Rzymskie(liczba - 4);
            if (liczba >= 1) return "I" + Rzymskie(liczba - 1);
            throw new ArgumentOutOfRangeException("???");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Czas.Stop();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aktualny = DateTime.Now;
            Czas.Start();
            button1.Hide();

            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();
            textBox5.Show();
            textBox11.Show();
            textBox12.Show();
            textBox13.Show();
            textBox17.Show();
            textBox19.Show();
            textBox21.Show();

            button2.Show(); 
            textBox11.Text = aktualny.Day.ToString();
            textBox12.Text = aktualny.Month.ToString();
            textBox13.Text = aktualny.Year.ToString();



            textBox17.Text = aktualny.DayOfWeek.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            aktualny = DateTime.Now;
            textBox5.Text = aktualny.Second.ToString();
            textBox3.Text = aktualny.Minute.ToString();
            textBox1.Text = aktualny.Hour.ToString();

 
           





        }

        private void Form1_Load(object sender, EventArgs e)
        {











        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
