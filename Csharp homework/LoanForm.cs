using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_homework
{
    public partial class LoanForm : Form
    {
        public LoanForm()
        {
            InitializeComponent();
        }
       
        private void btnpayMonth_Click(object sender, EventArgs e)
        {


           int monthPay = (int)Loan();
            MessageBox.Show("月付額：" + monthPay + "元");

        }
        public static double money;
        public static double year;
        public static double rate;
        public static double monthPay;
        public static int total;

        public double Loan()
            {
            
            money = double.Parse(txtMoney.Text);
            year = double.Parse(txtYear.Text);
            rate = double.Parse(txtRate.Text);
            double first = double.Parse(txtFirst.Text);
            double month = year * 12;                 //月
            double monthrate = rate / 12 / 100;//月利率
            //每月應付本息金額之平均攤還率 ＝{ [(1＋月利率)^月數]×月利率}÷{ [(1＋月利率)^月數]－1}
            double Forward = Math.Pow((1+monthrate),month)*monthrate;
            double Reverse = Math.Pow((1+monthrate), month)-1;
            double MonthMoneyRate = Forward/Reverse;
            monthPay = MonthMoneyRate*(money-first);  //月付本息
            return monthPay;
            }



            private void btntotal_Click(object sender, EventArgs e)
            {
            int year = int.Parse(txtYear.Text);
            int monthPay = (int)Loan();
            total = monthPay*year*12;
            MessageBox.Show("總付額：" + total + "元");
                
            }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Loan();
            int year = int.Parse(txtYear.Text);
            int monthPay = (int)Loan();
            total = monthPay * year * 12;
            LoanFormReport frm = new LoanFormReport();
            frm.Show();
        }
    }
}