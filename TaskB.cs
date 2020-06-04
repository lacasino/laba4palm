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
    public partial class TaskB : Form
    {
        public TaskB()
        {
            InitializeComponent();
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(picture1.Width, picture1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.White, 6);
            graph.DrawLine(pen, 300, 60, 185, 330);
            graph.DrawLine(pen, 250, 200, 185, 330);
            graph.DrawLine(pen, 300, 60, 250, 200);
            graph.DrawLine(pen, 180, 200, 185, 330);
            graph.DrawLine(pen, 300, 60, 180, 200);
            graph.DrawLine(pen, 185, 330, 100, 350);
            graph.DrawLine(pen, 180, 205, 100, 350);
            graph.DrawLine(pen, 185, 520, 105, 350);
            graph.DrawLine(pen, 185, 520, 300, 445);
            graph.DrawLine(pen, 205, 536, 300, 445);
            graph.DrawLine(pen, 205, 536, 185, 520);
            graph.DrawLine(pen, 185, 330, 300, 445);
            graph.DrawLine(pen, 455, 465, 300, 445);
            graph.DrawLine(pen, 455, 465, 465, 440);
            graph.DrawLine(pen, 455, 465, 495, 437);
            graph.DrawLine(pen, 465, 440, 185, 330);
            graph.DrawLine(pen, 360, 338, 185, 330);
            graph.DrawLine(pen, 465, 437, 494, 438);
            graph.DrawLine(pen, 465, 440, 359, 337); 
            graph.DrawLine(pen, 494, 438, 392, 340); 
            graph.DrawLine(pen, 362, 337, 392, 340);
            graph.DrawLine(pen, 352, 297, 185, 330);
            graph.DrawLine(pen, 352, 297, 362, 337);
            graph.DrawLine(pen, 352, 297, 397, 303);
            graph.DrawLine(pen, 392, 340, 397, 303);
            graph.DrawLine(pen, 250, 200, 352, 297);
            graph.DrawLine(pen, 250, 200, 298, 208);
            graph.DrawLine(pen, 298, 208, 407, 100);
            graph.DrawLine(pen, 407, 100, 250, 200);
            graph.DrawLine(pen, 350, 260, 407, 100);
            graph.DrawLine(pen, 295, 210, 397, 303);
            picture1.Image = bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
