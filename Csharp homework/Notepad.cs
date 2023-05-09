using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Csharp_homework
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
            timer1.Tick += new EventHandler(timer1_Tick); 
            timer1.Start(); 

        }
        string address = "";
        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog();
            if (File.ShowDialog() == DialogResult.OK) 
            {
            StreamReader Read = new StreamReader(File.FileName,Encoding.Default);
                txtnote.Text = Read.ReadToEnd();
                address = File.FileName;
                Read.Close();
            }
        }

        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog();
            FileStream fs = new FileStream(address, FileMode.Create);
            StreamWriter write = new StreamWriter(fs,Encoding.Default);
            write.Write(txtnote.Text);
            write.Close();
            fs.Close();
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnote.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnote.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnote.Paste();
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnote.SelectAll();
        }

        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
              txtnote.ForeColor = colorDialog.Color;
            }
        }

        private void 字型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                txtnote.Font= fontDialog.Font;
            }
        }

        private void toUpperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tmp = txtnote.Text;
            string upper = tmp.ToUpper();
            txtnote.Text = upper;
           
        }

        private void toLowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tmp = txtnote.Text;
            string lower = tmp.ToLower();
            txtnote.Text = lower;
        }

        private void 自動換行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtnote.WordWrap == false)
            txtnote.WordWrap = true;
            else
                txtnote.WordWrap = false;
        }

        private void 紅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnote.ForeColor = Color.Red;
        }

        private void 綠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnote.ForeColor = Color.Green;
        }

        private void 藍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnote.ForeColor = Color.Blue;
        }

        private void 黑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnote.ForeColor = Color.Black;
        }

        private void 關於AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此版本為尤冠景用於繳交作業用\n不嫌棄的話請用", "關於");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString();
            labTime.Text = date;
            labTime.Refresh();
        }
    }
}
