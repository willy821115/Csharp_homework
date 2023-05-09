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
    public partial class Student_structform : Form
    {
        public Student_structform()
        {
            InitializeComponent();
        }

        int saveChineseScore;
        int saveEnglishScore;
        int saveMathScore;
        string saveName;
        private void btnsave_Click(object sender, EventArgs e)
        {

            saveChineseScore = Convert.ToInt32(txtChinese.Text);
            saveEnglishScore = Convert.ToInt32(txtEnglish.Text);
            saveMathScore = Convert.ToInt32(txtMath.Text);
            saveName = txtname.Text;
           



        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            
            labScore.Text = $"姓名:{saveName}\n國文:{saveChineseScore}\n英文:{saveEnglishScore}\n數學:{saveMathScore}";
            

        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            int Max=0;
            int Min=0;
            string MaxSubject="";
            string MinSubject="";
            int[] score = new int[3] { saveChineseScore, saveEnglishScore, saveMathScore };
           Array.Sort(score);
            if (score[2] == saveChineseScore)
            {
                Max = saveChineseScore;
                MaxSubject = "國文";
            }
            else if (score[2] == saveEnglishScore) 
            {
                Max = saveEnglishScore;
                MaxSubject = "英文";
            }
            else if (score[2] == saveMathScore)
            {
                Max = saveMathScore;
                MaxSubject = "數學";
            }
            if (score[0] == saveChineseScore)
            {
                Min = saveChineseScore;
                MinSubject = "國文";
            }
            else if (score[0] == saveEnglishScore)
            {
                Min = saveEnglishScore;
                MinSubject = "英文";
            }
            else if (score[0] == saveMathScore)
            {
                Min = saveMathScore;
                MinSubject = "數學";
            }
            labMaxMin.Text = $"最高科目成績為:{MaxSubject}{Max}分\n最低科目成績為:{MinSubject}{Min}分";
                

        }
        

        

        
    }
    
}
