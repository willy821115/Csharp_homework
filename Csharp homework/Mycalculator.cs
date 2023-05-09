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
    public partial class Mycalculator : Form
    {
        public Mycalculator()
        {
            InitializeComponent();
        }
        double num1;
        double num2;
        private void btnPlus_Click(object sender, EventArgs e)
        {
            bool check1 = double.TryParse(txtNum1.Text, out num1);
            bool check2 = double.TryParse(txtNum2.Text, out num2);
            if (check1 && check2)
            {
                txtAnswer.Text = (num1 + num2).ToString();
            }
            else 
            {
                MessageBox.Show("請輸入數值", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            bool check1 = double.TryParse(txtNum1.Text, out num1);
            bool check2 = double.TryParse(txtNum2.Text, out num2);
            if (check1 && check2)
            {
                txtAnswer.Text = (num1 - num2).ToString();
            }
            else
            {
                MessageBox.Show("請輸入數值", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            bool check1 = double.TryParse(txtNum1.Text, out num1);
            bool check2 = double.TryParse(txtNum2.Text, out num2);
            if (check1 && check2)
            {
                txtAnswer.Text = (num1 * num2).ToString();
            }
            else
            {
                MessageBox.Show("請輸入數值", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            bool check1 = double.TryParse(txtNum1.Text, out num1);
            bool check2 = double.TryParse(txtNum2.Text, out num2);
            if (check1 && check2)
            {
                txtAnswer.Text = (num1 / num2).ToString();
            }
            else
            {
                MessageBox.Show("請輸入數值", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
