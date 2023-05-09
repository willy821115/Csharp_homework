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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnHello_home_Click(object sender, EventArgs e)
        {
            HelloForm frm1 = new HelloForm();
            frm1.Show();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            LoanForm frm2 = new LoanForm();
            frm2.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MENU frm3 = new MENU();
            frm3.Show();
        }

        private void btnStudentstructform_Click(object sender, EventArgs e)
        {
            Student_structform frm4 = new Student_structform();
            frm4.Show();
        }

        private void btnStudentGradeList_Click(object sender, EventArgs e)
        {
            StudentGradeList frm5 = new StudentGradeList();
            frm5.Show();
        }

        private void btnXOGame_Click(object sender, EventArgs e)
        {
            XOgame frm6 = new XOgame();
            frm6.Show();
        }

        private void btnMycalculator_Click(object sender, EventArgs e)
        {
            Mycalculator frm7 = new Mycalculator();
            frm7.Show();
        }

        private void btnScreen_saver_Click(object sender, EventArgs e)
        {
            Screen_saver frm8 = new Screen_saver();
            frm8.Show();
            
        }

        private void btnDrawpaint_Click(object sender, EventArgs e)
        {
            Drawpaint frm9 = new Drawpaint();
            frm9.Show();
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            Alarm frm10 = new Alarm();
            frm10.Show();
        }

        private void btnStudentGrade_Click(object sender, EventArgs e)
        {
            StudentsGrade frm11 = new StudentsGrade();
            frm11.Show();
        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            Method frm12 = new Method();
            frm12.Show();
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            Notepad frm13 = new Notepad();
            frm13.Show();
        }

        private void btnPicture_viewer_Click(object sender, EventArgs e)
        {
            Picture_Viewer frm14 = new Picture_Viewer();
            frm14.Show();
        }

        private void btnguess_Click(object sender, EventArgs e)
        {
            Guess frm15 = new Guess();
            frm15.Show();
        }

        
    }
}
