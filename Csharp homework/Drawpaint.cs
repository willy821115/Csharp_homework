using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Csharp_homework
{
    public partial class Drawpaint : Form
    {
        public Drawpaint()
        {
            InitializeComponent();
            
        }
        int oldX, oldY;
        int PenPixel;
        Bitmap bmp;
        Color PenColor;
        
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            PenPixel = (int)trackBar1.Value;
        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                PenColor = colorDialog.Color;
                labcolor.BackColor = colorDialog.Color;
            }
        }

        private void Drawpaint_Load(object sender, EventArgs e)
        {
           picPaint.Cursor= Cursors.Cross;
            Drawpaint drawpaint = new Drawpaint();
            bmp = new Bitmap(drawpaint.Size.Width, drawpaint.Size.Height);
            Graphics g = Graphics.FromImage(bmp);
            picPaint.Size = new Size(drawpaint.Size.Width, drawpaint.Size.Height);
            PenColor = Color.Black;
            PenPixel = 3;
            g.Clear(Color.White);
            picPaint.Image = bmp;
            picPaint.Refresh();
        }

        private void picPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(bmp);
                Pen p = new Pen(PenColor, PenPixel);
                g.DrawLine(p, oldX, oldY, e.X, e.Y);
                picPaint.Image = bmp;
                oldX = e.X;
                oldY = e.Y;
                
                
            }
        }
        private void picPaint_MouseDown(object sender, MouseEventArgs e)
        {
              oldX = e.X;
            oldY = e.Y;
        }
              
        
    }
}
