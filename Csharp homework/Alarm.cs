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
    public partial class Alarm : Form
    {
        public Alarm()
        {
            InitializeComponent();
            timerNowTime.Start();
        }
        int close = 0;
        
        private void timerNowTime_Tick(object sender, EventArgs e)
        {
            labNowTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void checkSet_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSet.Checked == true)
            {
                timerSet.Start();
            }
            else 
            {
                
                this.BackColor = Color.White;
                timerSet.Stop();
                close = 0;

            }
        }

        private void timerSet_Tick(object sender, EventArgs e)
        {
            DateTime inputTime = DateTime.Parse(masktxtSetTime.Text);
            DateTime now = DateTime.Now;
            if (inputTime <= now)
            {
                
                close += 1;
                if (this.BackColor != Color.Pink)
                {
                    this.BackColor = Color.Pink;
                }
                else if (this.BackColor == Color.Pink)
                {
                    this.BackColor = Color.Black;
                }
                if (close == 30)
                {
                    timerSet.Stop();
                }
            }
        }
    }
}
