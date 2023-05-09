using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_homework
{
    public partial class Picture_Viewer : Form
    {
        public Picture_Viewer()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Open(pictureBox1.BackgroundImage);
        }
        void Open(Image pic) 
        {
            Form frm = new Form();
            frm.BackgroundImage = pic;
            frm.BackgroundImageLayout = ImageLayout.Zoom;
            frm.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Open(pictureBox2.BackgroundImage);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Open(pictureBox3.BackgroundImage);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Open(pictureBox4.BackgroundImage);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Open(pictureBox5.BackgroundImage);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Open(pictureBox6.BackgroundImage);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Open(pictureBox7.BackgroundImage);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Open(pictureBox8.BackgroundImage);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Open(pictureBox9.BackgroundImage);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Open(pictureBox10.BackgroundImage);
        }
    }
}
