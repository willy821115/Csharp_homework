using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Csharp_homework
{
    public partial class StudentsGrade : Form
    {
        public StudentsGrade()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int ch =0;
            int eng = 0;
            int math = 0;
            bool boolch = int.TryParse(txtChinese.Text,out ch);
            bool booleng = int.TryParse(txtEnglish.Text, out eng);
            bool boolmath = int.TryParse(txtMath.Text ,out math);
            if (txtName.Text != "" && boolch && booleng && boolmath)
            {
                Click += 1;
                string[] MyScore = ScoreAnalysis(txtName.Text, ch, eng, math);
                ListViewItem File = new ListViewItem(MyScore);
                this.listScore.Items.Add(File);
                btnanalysis.Enabled = true;
            }
            else if (txtName.Text == "") 
            {
                MessageBox.Show("請輸入姓名", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!boolch)
            {
                MessageBox.Show("請輸入國文成績", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!booleng)
            {
                MessageBox.Show("請輸入英文成績", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!boolmath)
            {
                MessageBox.Show("請輸入數學成績", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        int Click = 0;
        private void btnEnterRandom_Click(object sender, EventArgs e)
        {
            Click += 1;

            Random RandomScore = new Random();
            
            int radCH = RandomScore.Next(0, 100);
            int radEng= RandomScore.Next(0, 100);
            int radMath= RandomScore.Next(0, 100);
            string[] MyScore = ScoreAnalysis(Click.ToString(),radCH, radEng, radMath);
            ListViewItem File = new ListViewItem(MyScore);
            this.listScore.Items.Add(File);
            btnanalysis.Enabled = true;

        }
        string[] ScoreAnalysis(string Name,int Chinese, int English, int Math) 
        {
            int[] StudentScore = { Chinese, English, Math };
            Array.Sort(StudentScore);
            int Max = 0;
            int Min = 0;
            string MaxSubject = "";
            string MinSubject = "";
            double avage = 0;
            double sum = 0;
            for (int i = 0; i < StudentScore.Length; i++)
            {
                sum += StudentScore[i];
                avage = sum / StudentScore.Length;

            }
            if (StudentScore[2] == Chinese)
            {
                Max = Chinese;
                MaxSubject = "國文";
            }
            else if (StudentScore[2] == English)
            {
                Max = English;
                MaxSubject = "英文";
            }
            else if (StudentScore[2] == Math)
            {
                Max = Math;
                MaxSubject = "數學";
            }
            if (StudentScore[0] == Chinese)
            {
                Min = Chinese;
                MinSubject = "國文";
            }
            else if (StudentScore[0] == English)
            {
                Min = English;
                MinSubject = "英文";
            }
            else if (StudentScore[0] == Math)
            {
                Min = Math;
                MinSubject = "數學";
            }
            string[] file = { Name, Chinese.ToString(), English.ToString(), Math.ToString(), sum.ToString(), avage.ToString(), MinSubject + Min, MaxSubject + Max };
            return file;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            this.listScore.Items.Clear();
            this.listAanalysis.Items.Clear();
            Click = 0;
            btnanalysis.Enabled = false;
        }

        private void btnRandom20_Click(object sender, EventArgs e)
        {
            
            Random RandomScore = new Random();
            for (int i = 0; i < 20; ++i)
            {   Click += 1;
            int radCH = RandomScore.Next(0, 100);
            int radEng = RandomScore.Next(0, 100);
            int radMath = RandomScore.Next(0, 100);
            
            
                string[] MyScore = ScoreAnalysis(Click.ToString(), radCH, radEng, radMath);
                ListViewItem File = new ListViewItem(MyScore);
                this.listScore.Items.Add(File);
                btnanalysis.Enabled = true;
            }
            
            
        }

        private void btnanalysis_Click(object sender, EventArgs e)
        {
            listAanalysis.Items.Clear();
            ListViewItem File1 = new ListViewItem(Analysis(1));
            this.listAanalysis.Items.Add(File1);
            ListViewItem File2 = new ListViewItem(Analysis(2));
            this.listAanalysis.Items.Add(File2);
            ListViewItem File3 = new ListViewItem(Analysis(3));
            this.listAanalysis.Items.Add(File3);

        }
        string[] Analysis(int i)
        {

            int Total = 0;
            double Average = 0;
            int Max = 0;
            int Min = 100;

            foreach (ListViewItem item in listScore.Items)
            {
                string valueString = item.SubItems[i].Text;
                int value = int.Parse(valueString);
                Total += value;
                Average = Total / Click;
            }


            foreach (ListViewItem item in listScore.Items)
            {
                string stringvalue = item.SubItems[i].Text;
                int maxvalue = int.Parse(stringvalue);
                int minvalue = int.Parse(stringvalue);

                if (maxvalue > Max)
                {
                    Max = maxvalue;
                }

                if (minvalue < Min)
                {
                    Min = minvalue;
                }

            }

            string[] file = { listScore.Columns[i].Text, Total.ToString(), Average.ToString(), Min.ToString(), Max.ToString() };
            return file;
        }








    }
}
