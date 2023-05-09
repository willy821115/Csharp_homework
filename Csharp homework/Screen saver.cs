using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace Csharp_homework
{
    public partial class Screen_saver : Form
    {


        public Screen_saver()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Cursor.Hide();


        }
        bool reflectionX = true;
        bool reflectionY = true;
        private Point initialMousePosition;


        private void timer1_Tick(object sender, EventArgs e)
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            initialMousePosition = Cursor.Position;
            if (reflectionX)
            {
                if (picCat.Left < screenWidth - 360)
                    picCat.Left += 5;
                else
                    reflectionX = !reflectionX;
            }
            else
            {
                if (picCat.Left > 0)
                    picCat.Left -= 5;
                else
                    reflectionX = !reflectionX;
            }
            if (reflectionY)
            {
                if (picCat.Top < screenHeight - 360)
                    picCat.Top += 5;
                else
                    reflectionY = !reflectionY;
            }
            else
            {
                if (picCat.Top > 0)
                    picCat.Top -= 5;
                else
                    reflectionY = !reflectionY;
            }
            if (initialMousePosition != Cursor.Position) 
            {
                Cursor.Show();
                Close();
            }


        }
        
    }
}
