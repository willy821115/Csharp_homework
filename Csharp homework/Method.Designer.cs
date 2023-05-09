namespace Csharp_homework
{
    partial class Method
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labnumber = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.labtitle = new System.Windows.Forms.Label();
            this.labresult = new System.Windows.Forms.Label();
            this.btnodd_even = new System.Windows.Forms.Button();
            this.btnarrayMinMax = new System.Windows.Forms.Button();
            this.btnarrayodd_even = new System.Windows.Forms.Button();
            this.btnstrLong = new System.Windows.Forms.Button();
            this.btn2D1_0 = new System.Windows.Forms.Button();
            this.btn2D0_1 = new System.Windows.Forms.Button();
            this.btn2D = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.labFrom = new System.Windows.Forms.Label();
            this.labTo = new System.Windows.Forms.Label();
            this.labStep = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.labRow = new System.Windows.Forms.Label();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.btnChris = new System.Windows.Forms.Button();
            this.btn99 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btnLottery = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labnumber
            // 
            this.labnumber.AutoSize = true;
            this.labnumber.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labnumber.Location = new System.Drawing.Point(12, 20);
            this.labnumber.Name = "labnumber";
            this.labnumber.Size = new System.Drawing.Size(95, 25);
            this.labnumber.TabIndex = 0;
            this.labnumber.Text = "Number:";
            // 
            // txtnumber
            // 
            this.txtnumber.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtnumber.Location = new System.Drawing.Point(102, 17);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(83, 34);
            this.txtnumber.TabIndex = 1;
            // 
            // labtitle
            // 
            this.labtitle.AutoSize = true;
            this.labtitle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labtitle.Location = new System.Drawing.Point(1, 335);
            this.labtitle.Name = "labtitle";
            this.labtitle.Size = new System.Drawing.Size(74, 25);
            this.labtitle.TabIndex = 2;
            this.labtitle.Text = "Result:";
            // 
            // labresult
            // 
            this.labresult.AutoSize = true;
            this.labresult.BackColor = System.Drawing.Color.Bisque;
            this.labresult.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labresult.ForeColor = System.Drawing.Color.Green;
            this.labresult.Location = new System.Drawing.Point(12, 360);
            this.labresult.Name = "labresult";
            this.labresult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labresult.Size = new System.Drawing.Size(58, 22);
            this.labresult.TabIndex = 3;
            this.labresult.Text = "結果";
            // 
            // btnodd_even
            // 
            this.btnodd_even.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnodd_even.Location = new System.Drawing.Point(17, 57);
            this.btnodd_even.Name = "btnodd_even";
            this.btnodd_even.Size = new System.Drawing.Size(168, 56);
            this.btnodd_even.TabIndex = 4;
            this.btnodd_even.Text = "輸入的數為奇數或偶數";
            this.btnodd_even.UseVisualStyleBackColor = true;
            this.btnodd_even.Click += new System.EventHandler(this.btnodd_even_Click);
            // 
            // btnarrayMinMax
            // 
            this.btnarrayMinMax.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnarrayMinMax.Location = new System.Drawing.Point(17, 119);
            this.btnarrayMinMax.Name = "btnarrayMinMax";
            this.btnarrayMinMax.Size = new System.Drawing.Size(168, 56);
            this.btnarrayMinMax.TabIndex = 5;
            this.btnarrayMinMax.Text = "陣列arr中的最大/小值";
            this.btnarrayMinMax.UseVisualStyleBackColor = true;
            this.btnarrayMinMax.Click += new System.EventHandler(this.btnarrayMinMax_Click);
            // 
            // btnarrayodd_even
            // 
            this.btnarrayodd_even.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnarrayodd_even.Location = new System.Drawing.Point(17, 181);
            this.btnarrayodd_even.Name = "btnarrayodd_even";
            this.btnarrayodd_even.Size = new System.Drawing.Size(168, 56);
            this.btnarrayodd_even.TabIndex = 6;
            this.btnarrayodd_even.Text = "陣列arr中的奇/偶數個數";
            this.btnarrayodd_even.UseVisualStyleBackColor = true;
            this.btnarrayodd_even.Click += new System.EventHandler(this.btnarrayodd_even_Click);
            // 
            // btnstrLong
            // 
            this.btnstrLong.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnstrLong.Location = new System.Drawing.Point(17, 243);
            this.btnstrLong.Name = "btnstrLong";
            this.btnstrLong.Size = new System.Drawing.Size(168, 56);
            this.btnstrLong.TabIndex = 7;
            this.btnstrLong.Text = "陣列arr_str中最長的名字";
            this.btnstrLong.UseVisualStyleBackColor = true;
            this.btnstrLong.Click += new System.EventHandler(this.btnstrLong_Click);
            // 
            // btn2D1_0
            // 
            this.btn2D1_0.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn2D1_0.Location = new System.Drawing.Point(368, 57);
            this.btn2D1_0.Name = "btn2D1_0";
            this.btn2D1_0.Size = new System.Drawing.Size(192, 56);
            this.btn2D1_0.TabIndex = 8;
            this.btn2D1_0.Text = "[10,10]二維陣列-邊1內0";
            this.btn2D1_0.UseVisualStyleBackColor = true;
            this.btn2D1_0.Click += new System.EventHandler(this.btn2D1_0_Click);
            // 
            // btn2D0_1
            // 
            this.btn2D0_1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn2D0_1.Location = new System.Drawing.Point(368, 119);
            this.btn2D0_1.Name = "btn2D0_1";
            this.btn2D0_1.Size = new System.Drawing.Size(192, 56);
            this.btn2D0_1.TabIndex = 9;
            this.btn2D0_1.Text = "[10,10]二維陣列-邊0內1";
            this.btn2D0_1.UseVisualStyleBackColor = true;
            this.btn2D0_1.Click += new System.EventHandler(this.btn2D0_1_Click);
            // 
            // btn2D
            // 
            this.btn2D.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn2D.Location = new System.Drawing.Point(368, 181);
            this.btn2D.Name = "btn2D";
            this.btn2D.Size = new System.Drawing.Size(192, 118);
            this.btn2D.TabIndex = 10;
            this.btn2D.Text = "[10,10]二維陣列\r\n1010101010\r\n0101010101\r\n...";
            this.btn2D.UseVisualStyleBackColor = true;
            this.btn2D.Click += new System.EventHandler(this.btn2D_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(194, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 56);
            this.button1.TabIndex = 11;
            this.button1.Text = "陣列arr_str中含有C或c的有幾個";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSwap.Location = new System.Drawing.Point(194, 126);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(168, 30);
            this.btnSwap.TabIndex = 13;
            this.btnSwap.Text = "Swap[int,int]";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSum.Location = new System.Drawing.Point(194, 168);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(168, 30);
            this.btnSum.TabIndex = 14;
            this.btnSum.Text = "Sum(arr[])";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnMax
            // 
            this.btnMax.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMax.Location = new System.Drawing.Point(194, 211);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(168, 30);
            this.btnMax.TabIndex = 15;
            this.btnMax.Text = "Max(arr[])";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMin.Location = new System.Drawing.Point(194, 256);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(168, 30);
            this.btnMin.TabIndex = 16;
            this.btnMin.Text = "Min(arr[])";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // labFrom
            // 
            this.labFrom.AutoSize = true;
            this.labFrom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labFrom.Location = new System.Drawing.Point(572, 53);
            this.labFrom.Name = "labFrom";
            this.labFrom.Size = new System.Drawing.Size(67, 25);
            this.labFrom.TabIndex = 17;
            this.labFrom.Text = "From:";
            // 
            // labTo
            // 
            this.labTo.AutoSize = true;
            this.labTo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTo.Location = new System.Drawing.Point(598, 88);
            this.labTo.Name = "labTo";
            this.labTo.Size = new System.Drawing.Size(41, 25);
            this.labTo.TabIndex = 18;
            this.labTo.Text = "To:";
            // 
            // labStep
            // 
            this.labStep.AutoSize = true;
            this.labStep.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStep.Location = new System.Drawing.Point(580, 119);
            this.labStep.Name = "labStep";
            this.labStep.Size = new System.Drawing.Size(59, 25);
            this.labStep.TabIndex = 19;
            this.labStep.Text = "Step:";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(645, 53);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(76, 25);
            this.txtFrom.TabIndex = 20;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(645, 88);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(76, 25);
            this.txtTo.TabIndex = 21;
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(645, 119);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(76, 25);
            this.txtStep.TabIndex = 22;
            // 
            // btnFor
            // 
            this.btnFor.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnFor.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFor.Location = new System.Drawing.Point(593, 159);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(128, 36);
            this.btnFor.TabIndex = 23;
            this.btnFor.Text = "For";
            this.btnFor.UseVisualStyleBackColor = false;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnWhile.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWhile.Location = new System.Drawing.Point(593, 211);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(128, 36);
            this.btnWhile.TabIndex = 24;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = false;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDo
            // 
            this.btnDo.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnDo.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDo.Location = new System.Drawing.Point(593, 263);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(128, 36);
            this.btnDo.TabIndex = 25;
            this.btnDo.Text = "Do";
            this.btnDo.UseVisualStyleBackColor = false;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // labRow
            // 
            this.labRow.AutoSize = true;
            this.labRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRow.Location = new System.Drawing.Point(757, 53);
            this.labRow.Name = "labRow";
            this.labRow.Size = new System.Drawing.Size(68, 25);
            this.labRow.TabIndex = 26;
            this.labRow.Text = "Rows:";
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(822, 53);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(76, 25);
            this.txtRow.TabIndex = 27;
            // 
            // btnChris
            // 
            this.btnChris.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnChris.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnChris.Location = new System.Drawing.Point(762, 88);
            this.btnChris.Name = "btnChris";
            this.btnChris.Size = new System.Drawing.Size(136, 56);
            this.btnChris.TabIndex = 28;
            this.btnChris.Text = "直角聖誕樹";
            this.btnChris.UseVisualStyleBackColor = false;
            this.btnChris.Click += new System.EventHandler(this.btnChris_Click);
            // 
            // btn99
            // 
            this.btn99.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn99.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn99.Location = new System.Drawing.Point(762, 155);
            this.btn99.Name = "btn99";
            this.btn99.Size = new System.Drawing.Size(136, 56);
            this.btn99.TabIndex = 29;
            this.btn99.Text = "九九乘法表";
            this.btn99.UseVisualStyleBackColor = false;
            this.btn99.Click += new System.EventHandler(this.btn99_Click);
            // 
            // btn100
            // 
            this.btn100.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn100.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn100.Location = new System.Drawing.Point(762, 222);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(136, 42);
            this.btn100.TabIndex = 30;
            this.btn100.Text = "100的二進位是?";
            this.btn100.UseVisualStyleBackColor = false;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // btnLottery
            // 
            this.btnLottery.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnLottery.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLottery.Location = new System.Drawing.Point(914, 169);
            this.btnLottery.Name = "btnLottery";
            this.btnLottery.Size = new System.Drawing.Size(136, 95);
            this.btnLottery.TabIndex = 31;
            this.btnLottery.Text = "樂透int[]號碼不重複";
            this.btnLottery.UseVisualStyleBackColor = false;
            this.btnLottery.Click += new System.EventHandler(this.btnLottery_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnclear.Location = new System.Drawing.Point(914, 49);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(141, 107);
            this.btnclear.TabIndex = 32;
            this.btnclear.Text = "清除結果欄位";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 696);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnLottery);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.btn99);
            this.Controls.Add(this.btnChris);
            this.Controls.Add(this.txtRow);
            this.Controls.Add(this.labRow);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.txtStep);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.labStep);
            this.Controls.Add(this.labTo);
            this.Controls.Add(this.labFrom);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn2D);
            this.Controls.Add(this.btn2D0_1);
            this.Controls.Add(this.btn2D1_0);
            this.Controls.Add(this.btnstrLong);
            this.Controls.Add(this.btnarrayodd_even);
            this.Controls.Add(this.btnarrayMinMax);
            this.Controls.Add(this.btnodd_even);
            this.Controls.Add(this.labresult);
            this.Controls.Add(this.labtitle);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.labnumber);
            this.Name = "Method";
            this.Text = "Method";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labnumber;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Label labtitle;
        private System.Windows.Forms.Label labresult;
        private System.Windows.Forms.Button btnodd_even;
        private System.Windows.Forms.Button btnarrayMinMax;
        private System.Windows.Forms.Button btnarrayodd_even;
        private System.Windows.Forms.Button btnstrLong;
        private System.Windows.Forms.Button btn2D1_0;
        private System.Windows.Forms.Button btn2D0_1;
        private System.Windows.Forms.Button btn2D;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label labFrom;
        private System.Windows.Forms.Label labTo;
        private System.Windows.Forms.Label labStep;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Label labRow;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.Button btnChris;
        private System.Windows.Forms.Button btn99;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btnLottery;
        private System.Windows.Forms.Button btnclear;
    }
}