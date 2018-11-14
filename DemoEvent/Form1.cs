using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEvent
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        Form2 subWindow = new Form2();

        int progressDir = 1;

        public Form1()
        {
            InitializeComponent();

            subWindow.SetText("Hello!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            subWindow.ShowDialog();

            textBox1.
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //label1.SetBounds(rand.Next(0, 100), rand.Next(0, 100), rand.Next(20, 100), rand.Next(20, 50));
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //button1.SetBounds(rand.Next(0, 100), rand.Next(0, 100), rand.Next(20, 100), rand.Next(20, 50));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += progressDir;

            if(progressBar1.Value >= progressBar1.Maximum ||
                progressBar1.Value <= 0)
            {
                progressDir *= -1;
            }
        }
    }
}
