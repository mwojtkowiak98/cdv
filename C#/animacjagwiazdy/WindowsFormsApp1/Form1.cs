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
        public int wd;
        public int he;
        float xx, yy;

        Star[] stars = new Star[100];

        public Form1()
        {
            InitializeComponent();

            Random los = new Random();

            for(int i=0; i<stars.Length-1;i++)
            {
                stars[i] = new Star(los.Next(632), los.Next(494), los.Next(632));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics ob = panel1.CreateGraphics();

            SolidBrush pend = new SolidBrush(Color.White);

            for(int i=0; i<stars.Length-1; i++)
            {
                xx = (float)Math.Round(stars[i].map(stars[i].x / stars[i].z, 0, 3, 0, 632));
                yy = (float)Math.Round(stars[i].map(stars[i].y / stars[i].z, 0, 3, 0, 494));

                ob.FillEllipse(pend, xx, yy, 4, 4);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            draw();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        void draw()
        {
            Graphics ob = panel1.CreateGraphics();

            SolidBrush pend = new SolidBrush(Color.White);
            SolidBrush pend2 = new SolidBrush(Color.Black);

            ob.FillRectangle(pend2, 0, 0, 632, 494);

            for (int i = 0; i < stars.Length - 1; i++)
            {

                stars[i].update();

                {

                    xx = (float)Math.Round(stars[i].map(stars[i].x / stars[i].z, 0, 3, 0, 632));
                    yy = (float)Math.Round(stars[i].map(stars[i].y / stars[i].z, 0, 3, 0, 494));

                    ob.FillEllipse(pend, xx, yy, 4, 4);
                }
            }
        }

    }
}
