using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Csharp_homework
{
    public partial class XOgame : Form
    {
        public XOgame()
        {
            InitializeComponent();
            
        }
        int[,] XOGame = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        bool player = true;
        int Click = 0;
        string Player(int i,int j) 
        {
             if (player)
            {
                XOGame[i, j] += 1;
                player = !player;
                return "O";
            }
            else 
            {
                 XOGame[i, j] -= 1;
                player = !player;
                return "X";
            }
        }
        void Rule()
        {
            Click += 1;
            for (int i = 0; i < 3; i++)
            {
                int count = 0;
                for (int j = 0; j < 3; j++)
                {
                    count += XOGame[i, j];
                    if (count == 3)
                    {
                        MessageBox.Show("O 贏了");
                        break;
                    }
                    if (count == -3)
                    {
                        MessageBox.Show("X 贏了");
                        break;
                    }
                }
            }
            for (int j = 0; j < 3; j++)
            {
                int count = 0;
                for (int i = 0; i < 3; i++)
                {
                    count += XOGame[i, j];
                    if (count == 3)
                    {
                        MessageBox.Show("O 贏了");
                        break;
                    }
                    if (count == -3)
                    {
                        MessageBox.Show("X 贏了");
                        break;
                    }
                }
            }
            if (Math.Abs(XOGame[0, 0] + XOGame[1, 1] + XOGame[2,2])==3)
            {
                
                if (XOGame[0, 0] + XOGame[1, 1] + XOGame[2, 2] == 3)
                {
                    MessageBox.Show("O 贏了");
                     }
                if (XOGame[0, 0] + XOGame[1, 1] + XOGame[2, 2] == -3)
                {
                    MessageBox.Show("X 贏了");

                }
            }
            if (Math.Abs(XOGame[0, 2] + XOGame[1, 1] + XOGame[2, 0]) == 3)
            {

                if (XOGame[0, 2] + XOGame[1, 1] + XOGame[2, 0] == 3)
                {
                    MessageBox.Show("O 贏了");

                }
                if (XOGame[0, 2] + XOGame[1, 1] + XOGame[2, 0] == -3)
                {
                    MessageBox.Show("X 贏了");

                }
            }
            if (Click == 9) 
            {
                MessageBox.Show("平手");
                Reset();
            }
         
        }

        private void btn1_1_Click(object sender, EventArgs e)
        {
            btn1_1.Text = Player(0,0);
            btn1_1.BackColor = Color.Honeydew;
            btn1_1.Enabled = false;
            Rule();
        }

        private void btn1_2_Click(object sender, EventArgs e)
        {
            btn1_2.Text = Player(0, 1);
            btn1_2.BackColor = Color.Honeydew;
            btn1_2.Enabled = false;
            Rule();
        }

        private void btn1_3_Click(object sender, EventArgs e)
        {
            btn1_3.Text = Player(0, 2);
            btn1_3.BackColor = Color.Honeydew;
            btn1_3.Enabled = false;
            Rule();
        }

        private void btn2_1_Click(object sender, EventArgs e)
        {
            btn2_1.Text = Player(1,0);
            btn2_1.BackColor = Color.Honeydew;
            btn2_1.Enabled = false;
            Rule();
        }

        private void btn2_2_Click(object sender, EventArgs e)
        {
            btn2_2.Text = Player(1,1);
            btn2_2.BackColor = Color.Honeydew;
            btn2_2.Enabled = false;
            Rule();
        }

        private void btn2_6_Click(object sender, EventArgs e)
        {
            btn2_6.Text = Player(1,2);
            btn2_6.BackColor = Color.Honeydew;
            btn2_6.Enabled = false;
            Rule();
        }

        private void btn3_1_Click(object sender, EventArgs e)
        {
            btn3_1.Text = Player(2,0);
            btn3_1.BackColor = Color.Honeydew;
            btn3_1.Enabled = false;
            Rule();
        }

        private void btn3_2_Click(object sender, EventArgs e)
        {
            btn3_2.Text = Player(2,1);
            btn3_2.BackColor = Color.Honeydew;
            btn3_2.Enabled = false;
            Rule();
        }

        private void btn3_3_Click(object sender, EventArgs e)
        {
            btn3_3.Text = Player(2,2);
            btn3_3.BackColor = Color.Honeydew;
            btn3_3.Enabled = false;
            Rule();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Reset();

            
            foreach (Control x in Controls) 
            {
                 x.Enabled = true;
                x.Text = "";
                x.BackColor = Color.WhiteSmoke;
                   }
            btnReset.Text = "Reset(R)";
            btnExit.Text = "Exit(E)";
            label1.Text = "X O GAME";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        
        private void btnReset_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'r'|| e.KeyChar =='R')
            {
                btnReset.PerformClick();
            }
        }

        private void btnExit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'e' || e.KeyChar == 'E')
            {
                btnExit.PerformClick();
            }
        }
        void Reset()
        {
            for (int i = 0; i < XOGame.GetLength(0); i++)
            {
                for (int j = 0; j < XOGame.GetLength(1); j++)
                {
                    XOGame[i, j] = 0;
                }
            }
            Click = 0;
        }
    }
}