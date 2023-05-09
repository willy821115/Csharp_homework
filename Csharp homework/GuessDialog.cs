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
    public partial class GuessDialog : Form
    {
        
        public GuessDialog()
        {
            InitializeComponent();
           
        }

         int min=1;
        int max=100;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool check = int.TryParse(txtGuess.Text, out int myAnswer);
            if (check&&myAnswer>min&&myAnswer<max)
            {

                if (myAnswer == Guess.Answer)
                {
                    MessageBox.Show($"恭喜你，答案是{Guess.Answer}");
                }
                else if (myAnswer > Guess.Answer)
                {
                    max = myAnswer;
                    Guess guess = (Guess)this.Owner;
                    Label label1 = (Label)guess.Controls["labTile"];
                    label1.Text = $"太大，小一點\n{min}~{max}";


                }
                else if (myAnswer < Guess.Answer)
                {
                    min = myAnswer;
                    Guess guess = (Guess)this.Owner;
                    Label label1 = (Label)guess.Controls["labTile"];
                    label1.Text = $"太小，大一點\n{min}~{max}";

                }
                
            }
            else
            {
                MessageBox.Show($"請輸入{min}~{max}的數值");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            min = 1; max = 100;
            Close();
        }
    }
}
