using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_homework
{
    public partial class Guess : Form
    {
        //public Label label1;
        public Guess()
        {
            InitializeComponent();
           

        }
        public static int Answer;
       


        private void btnGuess_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Answer = random.Next(1,100);
            GuessDialog guessDialog = new GuessDialog();
            guessDialog.Owner = this;
            guessDialog.ShowDialog();
            
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Answer : {Answer}");
        }
    }
}
