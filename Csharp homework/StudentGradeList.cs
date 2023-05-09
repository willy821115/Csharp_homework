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
    public partial class StudentGradeList : Form
    {
        public StudentGradeList()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int ch = 0;
            int eng = 0;
            int math = 0;
            bool boolch = int.TryParse(txtChinese.Text, out ch);
            bool booleng = int.TryParse(txtEnglish.Text, out eng);
            bool boolmath = int.TryParse(txtMath.Text, out math);
            int Max = 0;
            int Min = 100;
            int Total = 0;
            double Average = 0;
            int[] students = { ch, eng, math };
            if (txtName.Text != "" && boolch && booleng && boolmath)
            {
                btnRemove.Enabled = true;
                btnanalysis.Enabled = true;
                foreach (int item in students)
                {
                    if (Max < item)
                        Max = item;

                    if (Min > item)
                        Min = item;
                }
                foreach (int item in students)
                {
                    Total += item;
                }
                Average = Total / students.Length;
                string[] enter = { txtName.Text, txtChinese.Text, txtEnglish.Text, txtMath.Text, Total.ToString(), Average.ToString(), Min.ToString(), Max.ToString() };
                ListViewItem listViewItem = new ListViewItem(enter);
                listScore.Items.Add(listViewItem);
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
            btnRemove.Enabled = true;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            int ch = 0;
            int eng = 0;
            int math = 0;
            bool boolch = int.TryParse(txtChinese.Text, out ch);
            bool booleng = int.TryParse(txtEnglish.Text, out eng);
            bool boolmath = int.TryParse(txtMath.Text, out math);
            int Max = 0;
            int Min = 100;
            int Total = 0;
            double Average = 0;
            int[] students = { ch, eng, math };
            if (txtName.Text != "" && boolch && booleng && boolmath)
            {
                btnRemove.Enabled = true;
                btnanalysis.Enabled = true;
                foreach (int item in students)
                {
                    if (Max < item)
                        Max = item;

                    if (Min > item)
                        Min = item;
                }
                foreach (int item in students)
                {
                    Total += item;
                }
                Average = Total / students.Length;
                string[] enter = { txtName.Text, txtChinese.Text, txtEnglish.Text, txtMath.Text, Total.ToString(), Average.ToString(), Min.ToString(), Max.ToString() };
                ListViewItem listViewItem = new ListViewItem(enter);
                listScore.Items.Insert(0, listViewItem);
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            listScore.Items.RemoveAt(listScore.Items.Count - 1);
            if (listScore.Items.Count == 0)
            {
                btnRemove.Enabled = false;
                btnanalysis.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listScore.Items.Clear();
            listAanalysis.Items.Clear();
            btnRemove.Enabled = false;
            btnanalysis.Enabled = false;
            btnSave.Enabled = true;
            btninsert.Enabled = true;
        }

        private void btnanalysis_Click(object sender, EventArgs e)
        {
            btnRemove.Enabled = false;
            btninsert.Enabled = false;
            btnSave.Enabled = false;

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
                Average = Total / listScore.Items.Count;
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

        private void btnSerch_Click(object sender, EventArgs e)
        {
            List<ListViewItem> result = new List<ListViewItem>();
            bool Boolmin = int.TryParse(txtLow.Text, out int minValue);
            bool Boolmax = int.TryParse(txtHigh.Text, out int maxValue);
            if (Boolmin && Boolmax)
            {
                List<ListViewItem> filteredData = new List<ListViewItem>();
                foreach (ListViewItem item in listScore.Items)
                {
                    int score = Convert.ToInt32(item.SubItems[1].Text);
                    if (score < Convert.ToInt32(txtHigh.Text) && score > Convert.ToInt32(txtLow.Text))
                    {
                        filteredData.Add(item);
                    }
                }

                listScore.Items.Clear();

                foreach (ListViewItem item in filteredData)
                {
                    listScore.Items.Add(item);
                }
            }
            else 
            {
                MessageBox.Show("數字格式錯誤");
            }



        }


    }
}