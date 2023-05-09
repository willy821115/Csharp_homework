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
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string ENname = txtENname.Text;
            string sex = txtsex.Text;
            string star = txtstar.Text;
            MessageBox.Show("Hello,我是" + name + "\n英文名字是:" + ENname + "\n性別是:" + sex + "\n星座是:" + star + "\n很高興認識你");
        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string ENname = txtENname.Text;
            string sex = txtsex.Text;
            string star = txtstar.Text;
            MessageBox.Show("Hi,我是" + name + "\n英文名字是:" + ENname + "\n性別是:" + sex + "\n星座是:" + star + "\n很高興認識你");
        }
    }
    
    
    
     

    
}
