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

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "!";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label1.SetBounds(rand.Next(0, 100), rand.Next(0, 100), rand.Next(20, 100), rand.Next(20, 50));
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.SetBounds(rand.Next(0, 100), rand.Next(0, 100), rand.Next(20, 100), rand.Next(20, 50));
        }
    }
}
