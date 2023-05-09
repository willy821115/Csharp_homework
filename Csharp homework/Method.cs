using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_homework
{
    public partial class Method : Form
    {
        public Method()
        {
            InitializeComponent();
        }

        private void btnodd_even_Click(object sender, EventArgs e)
        {
            int number;
            bool check;
            check = int.TryParse(txtnumber.Text, out number);
            if (check)
            {
                if (number % 2 == 0)
                {
                    labresult.Text = $"輸入的數為 {number} 為偶數";
                }
                else
                {
                    labresult.Text = $"輸入的數為 {number} 為奇數";
                }
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void btnarrayMinMax_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            Array.Sort(arr);
            labresult.Text = $"int陣列arr[ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 ]\n最小值為{arr[0]}\n最大值為{arr[arr.Length - 1]}";
        }

        private void btnarrayodd_even_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int odd = 0;
            int even = 0;
            foreach (int i in arr)
            {
                if (i % 2 == 0)
                    even += 1;
                else
                    odd += 1;
            }
            labresult.Text = $"int陣列arr[ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 ]\n奇數共{odd}\n偶數共{even}";
        }

        private void btnstrLong_Click(object sender, EventArgs e)
        {
            string[] arr_str = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "MotherFucker" };
            int Max = 0;
            int MaxIndex = 0;
            for (int i = 0; i < arr_str.Length; i++)
            {
                int currentLength = arr_str[i].Length;
                if (currentLength > Max)
                {
                    Max = currentLength;
                    MaxIndex = i;
                }
            }
            labresult.Text = $"int陣列arr[ mother張, emma, 迪克蕭, J40, Candy, Cindy, Coconut, MotherFucker ]\n最長的名字為{arr_str[MaxIndex]}";
        }

        private void btn2D1_0_Click(object sender, EventArgs e)
        {
            int rows = 10;
            int cols = 10;
            int[,] array = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == 0 || i == rows - 1 || j == 0 || j == cols - 1)
                    {
                        array[i, j] = 1;
                    }
                }
            }
            string labelContent = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    labelContent += array[i, j] + " ";
                }
                labelContent += "\n";
            }
            labresult.Text = labelContent;
        }

        private void btn2D0_1_Click(object sender, EventArgs e)
        {
            int rows = 10;
            int cols = 10;
            int[,] array = new int[rows, cols];
            for (int i = 1; i < rows - 1; i++)
            {
                for (int j = 1; j < cols - 1; j++)
                {
                    array[i, j] = 1;
                }
            }
            string labelContent = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    labelContent += array[i, j] + " ";
                }
                labelContent += "\n";
            }
            labresult.Text = labelContent;
        }

        private void btn2D_Click(object sender, EventArgs e)
        {
            int rows = 10;
            int cols = 10;
            int[,] array = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        array[i, j] = 1;
                    }
                }
            }
            string labelContent = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    labelContent += array[i, j] + " ";
                }
                labelContent += "\n";
            }
            labresult.Text = labelContent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr_str = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "MotherFucker" };
            int count = 0;
            foreach (string str in arr_str)
            {
                if (str.Contains("C") || str.Contains("c"))
                {
                    count++;
                }
            }
            labresult.Text = $"int陣列arr[ mother張, emma, 迪克蕭, J40, Candy, Cindy, Coconut, MotherFucker ]\n有C或c的名字有{count}個";
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            int n1 = 100;
            int n2 = 200;
            int temp;
            labresult.Text = "";
            labresult.Text += $"換位前n1={n1} , n2={n2}\n";
            temp = n1;
            n1 = n2;
            n2 = temp;
            labresult.Text += $"換位後n1={n1} , n2={n2}\n";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int total = 0;
            foreach (int i in arr)
            {
                total += i;
            }
            labresult.Text = $"int陣列arr[ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 ]\n加總為 {total}";
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            Array.Sort(arr);
            labresult.Text = $"int陣列arr[ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 ]\n最大值為 {arr[arr.Length - 1]}";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            Array.Sort(arr);
            labresult.Text = $"int陣列arr[ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 ]\n最小值為 {arr[0]}";
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int from, to, step;
            bool blfrom, blto, blstep;
            blfrom = int.TryParse(txtFrom.Text, out from);
            blto = int.TryParse(txtTo.Text, out to);
            blstep = int.TryParse(txtStep.Text, out step);
            int apart = 0;
            int total = 0;
            if (blfrom && blto && blstep)
            {
                for (int i = from; i < to; i += step)
                {
                    apart += 1;
                    total += i;
                }
                labresult.Text = $"{from}到{to} 相隔{apart}\n加總為 {total}";
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int from, to, step;
            bool blfrom, blto, blstep;
            blfrom = int.TryParse(txtFrom.Text, out from);
            blto = int.TryParse(txtTo.Text, out to);
            blstep = int.TryParse(txtStep.Text, out step);
            int apart = 0;
            int total = 0;
            if (blfrom && blto && blstep)
            {
                int i = from;
                while (i < to)
                {
                    apart += 1;
                    total += i;
                    i += step;
                }
                labresult.Text = $"{from}到{to} 相隔{apart}\n加總為 {total}";
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            int from, to, step;
            bool blfrom, blto, blstep;
            blfrom = int.TryParse(txtFrom.Text, out from);
            blto = int.TryParse(txtTo.Text, out to);
            blstep = int.TryParse(txtStep.Text, out step);
            int apart = 0;
            int total = 0;
            if (blfrom && blto && blstep)
            {
                int i = from;
                do
                {
                    apart += 1;
                    total += i;
                    i += step;
                } while (i < to);
                labresult.Text = $"{from}到{to} 相隔{apart}\n加總為 {total}";
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void btnChris_Click(object sender, EventArgs e)
        {
            labresult.Text = "";
            int Row;
            bool check;
            check = int.TryParse(txtRow.Text, out Row);
            if (check)
            {
                for (int i = 0; i < Row; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        labresult.Text += "*";
                    }
                    labresult.Text += "\n";
                }
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }

        }

        private void btn99_Click(object sender, EventArgs e)
        {
            labresult.Text = "";
            int i, j;
            for (i = 1; i <= 9; i++)
            {
                for (j = 2; j <= 9; j++)
                {
                    int ans = j * i;
                    string ans_str = ans.ToString()/*.PadLeft(2)*/;
                    labresult.Text += $"{j}x {i}={ans_str}|";
                }
                labresult.Text += "\n";
            }
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            int num = 100;
            string result = "";
            while (num > 0)
            {
                int remainder = num % 2;
                result = remainder.ToString() + result;
                num = num / 2;
            }
            labresult.Text = result;
        }

        private void btnLottery_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int[] lottery = new int[6];
            int index = 0;
            labresult.Text = "";
            while (index < 6)
            {
                int number = random.Next(1, 49);
                if (!lottery.Contains(number))
                {
                    lottery[index] = number;
                    index++;
                }
            }
            foreach (int number in lottery)
            {
                labresult.Text += number.ToString()+" ";
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            labresult.Text = "結果";
        }
    }
}
