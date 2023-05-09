using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_homework
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
            labPay.Text = TotalPrice.ToString("c0");

        }
        int TotalPrice = 0;
        int CountWiskey = 0;
        int CountVoka = 0;
        int CountTea = 0;
        int CountTower = 0;
        int TotalWiskey = 0;
        int TotalVoka = 0;
        int TotalTea = 0;
        int TotalTower = 0;
    



        private void btnWhiskey_Click(object sender, EventArgs e)
        {
           
            Pay(600,ref CountWiskey, ref TotalWiskey, "威士忌");



        }

        private void btnVodka_Click(object sender, EventArgs e)
        {
           
            Pay(500, ref CountVoka, ref TotalVoka, "伏特加");
        }

        private void btnTea_Click(object sender, EventArgs e)
        {
            
            Pay(500, ref CountTea, ref TotalTea, "烏龍茶");
        }

        private void btnTower_Click(object sender, EventArgs e)
        {
            
            Pay(500, ref CountTower, ref TotalTower, "香檳塔");
        }
        void Pay(int Price, ref int Count,ref int ItemCost,string Item) 
        {
            int tempCost = ItemCost;
            int tempCount = Count;
            TotalPrice += Price;
           Count += 1;
            
            
            if (ItemCost==0 )
            {
                labList.Text = labList.Text.Replace("尚未點餐","");
                ItemCost += Price;
                labPay.Text = TotalPrice.ToString("c0");
                labList.Text += $"{Item} x{Count} 共{ItemCost.ToString("c0")}\n";
            }
            else 
            {
                ItemCost += Price;
                labPay.Text = TotalPrice.ToString("c0");
                labList.Text = labList.Text.Replace($"{Item} x{tempCount} 共{tempCost.ToString("c0")}", $"{Item} x{Count} 共{ItemCost.ToString("c0")}");
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TotalPrice = 0;
            CountWiskey = 0;
            CountVoka = 0;
            CountTea = 0;
            CountTower = 0;
            TotalWiskey = 0;
            TotalVoka = 0;
            TotalTea = 0;
            TotalTower = 0;
            labPay.Text = TotalPrice.ToString("c0");
            labList.Text = "尚未點餐";
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if (TotalPrice == 0) 
            {
                MessageBox.Show("尚未點餐", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                MessageBox.Show($"總金額:{TotalPrice}元");
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TotalPrice == 0)
            {
                MessageBox.Show("尚未點餐","確認付款",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                double creditcard = TotalPrice * 0.9;
                MessageBox.Show($"總金額:{Convert.ToInt32(creditcard)}元");

            }
        }
    }
}
