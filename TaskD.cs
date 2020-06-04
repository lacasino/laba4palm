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
    public partial class TaskD : Form
    {
        int x = 0;
        Bitmap bmp;
        Pen pen1;
        Pen pen;
        Graphics graph;
        public TaskD()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void TaskD_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            bmp = new Bitmap(1500, 820);
            pen1 = new Pen(Color.SaddleBrown, 5);
            pen = new Pen(Color.Black, 3);
            graph = Graphics.FromImage(bmp);
            graph.Clear(Color.Transparent);
            graph.DrawLine(pen1, 1, 512, 1022, 512);
            graph.DrawLine(pen1, 1, 542, 1022, 542);
            graph.DrawEllipse(pen, x + 75, 340, 122, 130);
            graph.DrawEllipse(pen, x + 127, 395, 17, 17);
            graph.DrawLine(pen, x + 196, 446, x + 400, 446);
            graph.DrawLine(pen, x + 400, 315, x + 400, 512);
            graph.DrawLine(pen, x + 194, 428, x + 400, 429);
            graph.DrawLine(pen, x + 400, 428, x + 455, 512);
            graph.DrawLine(pen, x + 407, 460, x + 408, 506);
            graph.DrawLine(pen, x + 407, 460, x + 424, 506);
            graph.DrawLine(pen, x + 424, 506, x + 408, 506);
            graph.DrawLine(pen, x + 409, 451, x + 433, 506);
            graph.DrawLine(pen, x + 409, 451, x + 444, 506);
            graph.DrawLine(pen, x + 444, 506, x + 433, 506);
            graph.DrawLine(pen, x + 400, 512, x + 455, 512);
            graph.DrawEllipse(pen, x + 260, 406, 60, 60);
            graph.DrawEllipse(pen, x + 332, 406, 60, 60);
            graph.DrawEllipse(pen, x + 282, 428, 17, 17);
            graph.DrawEllipse(pen, x + 353, 429, 17, 17);
            graph.DrawLine(pen, x + 196, 212, x + 196, 427);
            graph.DrawLine(pen, x + 196, 314, x + 399, 314);
            graph.DrawLine(pen, x + 399, 314, x + 438, 375);
            graph.DrawLine(pen, x + 400, 428, x + 438, 375);
            graph.DrawLine(pen, x + 75, 446, x + 56, 446);
            graph.DrawLine(pen, x + 56, 446, x + 55, 338);
            graph.DrawLine(pen, x + 81, 212, x + 220, 212);
            graph.DrawLine(pen, x + 82, 315, x + 82, 191);
            graph.DrawLine(pen, x + 82, 191, x + 220, 191);
            graph.DrawLine(pen, x + 220, 212, x + 82, 212);
            graph.DrawRectangle(pen, x + 100, 228, 80, 67);
            graph.DrawRectangle(pen, x + 385, 248, 33, 68);
            graph.DrawRectangle(pen, x + 397, 240, 13, 9);
            graph.DrawRectangle(pen, x + 305, 226, 42, 89);
            graph.DrawLine(pen, x + 305, 226, x + 275, 171);
            graph.DrawLine(pen, x + 275, 171, x + 386, 171);
            graph.DrawLine(pen, x + 347, 226, x + 386, 171);
            graph.DrawLine(pen, x + 82, 315, x + 56, 338);
            graph.DrawLine(pen, x + 227, 202, x + 220, 191);
            graph.DrawLine(pen, x + 227, 202, x + 220, 212);
            graph.DrawArc(pen, x + 223, 292, 67, 41, 180, 180);
            graph.DrawBezier(Pens.Black, new Point(x + 295, 145), new Point(x + 225, 165), new Point(x + 160, 180), new Point(x + 110, 160));
            graph.DrawBezier(Pens.Black, new Point(x + 260, 150), new Point(x + 195, 170), new Point(x + 125, 200), new Point(x + 100, 145));
            graph.DrawBezier(Pens.Black, new Point(x + 240, 160), new Point(x + 175, 155), new Point(x + 145, 170), new Point(x + 130, 150));
            pictureBox1.Image = bmp;
            x += 10;
        }
    }
}

