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
    public partial class Form2 : Form
    {
        public String Label1
        {
            set
            {
                label1.Text = value;
            }
            get
            {
                return label1.Text;
            }
        }

        public Form2()
        {
            InitializeComponent();
        }

        public void SetText(string text)
        {
            label1.Text = text;
        }
    }
}
