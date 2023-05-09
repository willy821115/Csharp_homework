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
    public partial class LoanFormReport : Form
    {
        
        

        public LoanFormReport()
        {
            InitializeComponent();
            txtMoneyre.Text = Convert.ToString(LoanForm.money);
            txtRatere.Text = Convert.ToString(LoanForm.rate);
            txtYearre.Text = Convert.ToString(LoanForm.year);
            int moneyPayre = Convert.ToInt32(LoanForm.monthPay);
            int totalre = Convert.ToInt32(LoanForm.total);
            txtMonthMoneyre.Text = Convert.ToString(moneyPayre);
            txtTotalre.Text = Convert.ToString(totalre);
            
            
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
