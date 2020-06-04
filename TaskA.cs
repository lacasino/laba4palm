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
    public partial class TaskA : Form
    {
        public TaskA()
        {
            InitializeComponent();
            DrawArc();
        }
        private void DrawArc()
        {
            Bitmap bmp = new Bitmap(800, 450);
            Graphics graph = Graphics.FromImage(bmp);
            Pen blackPen = new Pen(Color.Black, 3);
            graph.DrawPie(blackPen, 140, 65, 215, 115, 90, 160);
            graph.DrawPie(blackPen, 240, 65, 200, 100, 0, 45);
            graph.DrawRectangle(blackPen, 140, 220, 100, 100);
            graph.DrawLine(blackPen, 440, 270, 505, 355);
            graph.DrawLine(blackPen, 375, 355, 505, 355);
            graph.DrawLine(blackPen, 375, 355, 440, 270);
            Rectangle reg = new Rectangle();
            PaintEventArgs e = new PaintEventArgs(graph, reg);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            Point point1 = new Point(440, 270);
            Point point2 = new Point(505, 355);
            Point point3 = new Point(375, 355);
            Point point4 = new Point(505, 355);
            Point point5 = new Point(375, 355);
            Point point6 = new Point(440, 270);
            Point[] curvePoints = { point1, point2, point3, point4, point5, point6 };
            e.Graphics.FillPolygon(blueBrush, curvePoints);
            pictureBox1.Image = bmp;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
