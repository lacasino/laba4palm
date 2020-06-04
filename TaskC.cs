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
    public partial class TaskC : Form
    {

        Pen pen;
        Graphics graph;
        public TaskC()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pen = new Pen(Color.Black, 3);
           // graph.DrawRectangle(pen, 100, 228, 80, 67);
        }
    }
}
