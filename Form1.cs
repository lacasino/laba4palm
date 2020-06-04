using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var taska = new TaskA();
            taska.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var taskc = new TaskC();
            taskc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var taskd = new TaskD();
            taskd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var taskb = new TaskB();
            taskb.Show();
        }
    }
}
