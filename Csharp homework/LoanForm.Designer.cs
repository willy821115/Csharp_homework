namespace Csharp_homework
{
    partial class LoanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanForm));
            this.labMoney = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.labRate = new System.Windows.Forms.Label();
            this.labFirst = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.btnpayMonth = new System.Windows.Forms.Button();
            this.btntotal = new System.Windows.Forms.Button();
            this.btntest = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labMoney
            // 
            this.labMoney.AutoSize = true;
            this.labMoney.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMoney.Location = new System.Drawing.Point(171, 81);
            this.labMoney.Name = "labMoney";
            this.labMoney.Size = new System.Drawing.Size(123, 34);
            this.labMoney.TabIndex = 0;
            this.labMoney.Text = "貸款金額";
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labYear.Location = new System.Drawing.Point(180, 140);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(114, 34);
            this.labYear.TabIndex = 1;
            this.labYear.Text = "期限(年)";
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRate.Location = new System.Drawing.Point(180, 205);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(111, 34);
            this.labRate.TabIndex = 2;
            this.labRate.Text = "利率(%)";
            // 
            // labFirst
            // 
            this.labFirst.AutoSize = true;
            this.labFirst.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labFirst.Location = new System.Drawing.Point(195, 263);
            this.labFirst.Name = "labFirst";
            this.labFirst.Size = new System.Drawing.Size(96, 34);
            this.labFirst.TabIndex = 3;
            this.labFirst.Text = "頭期款";
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMoney.Location = new System.Drawing.Point(325, 77);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(199, 43);
            this.txtMoney.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtYear.Location = new System.Drawing.Point(325, 135);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(199, 43);
            this.txtYear.TabIndex = 6;
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRate.Location = new System.Drawing.Point(325, 200);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(199, 43);
            this.txtRate.TabIndex = 7;
            // 
            // txtFirst
            // 
            this.txtFirst.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFirst.Location = new System.Drawing.Point(325, 260);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(199, 43);
            this.txtFirst.TabIndex = 8;
            // 
            // btnpayMonth
            // 
            this.btnpayMonth.BackColor = System.Drawing.SystemColors.Info;
            this.btnpayMonth.Location = new System.Drawing.Point(325, 334);
            this.btnpayMonth.Name = "btnpayMonth";
            this.btnpayMonth.Size = new System.Drawing.Size(103, 53);
            this.btnpayMonth.TabIndex = 9;
            this.btnpayMonth.Text = "月付額";
            this.btnpayMonth.UseVisualStyleBackColor = false;
            this.btnpayMonth.Click += new System.EventHandler(this.btnpayMonth_Click);
            // 
            // btntotal
            // 
            this.btntotal.BackColor = System.Drawing.SystemColors.Info;
            this.btntotal.Location = new System.Drawing.Point(449, 334);
            this.btntotal.Name = "btntotal";
            this.btntotal.Size = new System.Drawing.Size(103, 53);
            this.btntotal.TabIndex = 10;
            this.btntotal.Text = "總付額";
            this.btntotal.UseVisualStyleBackColor = false;
            this.btntotal.Click += new System.EventHandler(this.btntotal_Click);
            // 
            // btntest
            // 
            this.btntest.Location = new System.Drawing.Point(0, 0);
            this.btntest.Name = "btntest";
            this.btntest.Size = new System.Drawing.Size(75, 23);
            this.btntest.TabIndex = 13;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.Info;
            this.btnReport.Location = new System.Drawing.Point(575, 334);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(103, 53);
            this.btnReport.TabIndex = 12;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btntest);
            this.Controls.Add(this.btntotal);
            this.Controls.Add(this.btnpayMonth);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.labFirst);
            this.Controls.Add(this.labRate);
            this.Controls.Add(this.labYear);
            this.Controls.Add(this.labMoney);
            this.Name = "LoanForm";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labMoney;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Label labRate;
        private System.Windows.Forms.Label labFirst;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Button btnpayMonth;
        private System.Windows.Forms.Button btntotal;
        private System.Windows.Forms.Button btntest;
        private System.Windows.Forms.Button btnReport;
    }
}