namespace Csharp_homework
{
    partial class LoanFormReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanFormReport));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMoneyre = new System.Windows.Forms.TextBox();
            this.txtYearre = new System.Windows.Forms.TextBox();
            this.txtRatere = new System.Windows.Forms.TextBox();
            this.txtMonthMoneyre = new System.Windows.Forms.TextBox();
            this.txtTotalre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(61, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "貸款金額:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(73, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "期限(年):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(73, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 43);
            this.label3.TabIndex = 2;
            this.label3.Text = "利率(%):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(93, 314);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 43);
            this.label4.TabIndex = 3;
            this.label4.Text = "月付款:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(93, 391);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 43);
            this.label5.TabIndex = 4;
            this.label5.Text = "總付款:";
            // 
            // txtMoneyre
            // 
            this.txtMoneyre.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMoneyre.Location = new System.Drawing.Point(281, 60);
            this.txtMoneyre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMoneyre.Name = "txtMoneyre";
            this.txtMoneyre.ReadOnly = true;
            this.txtMoneyre.Size = new System.Drawing.Size(159, 52);
            this.txtMoneyre.TabIndex = 5;
            this.txtMoneyre.TextChanged += new System.EventHandler(this.txtMoney_TextChanged);
            // 
            // txtYearre
            // 
            this.txtYearre.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtYearre.Location = new System.Drawing.Point(281, 144);
            this.txtYearre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYearre.Name = "txtYearre";
            this.txtYearre.ReadOnly = true;
            this.txtYearre.Size = new System.Drawing.Size(159, 52);
            this.txtYearre.TabIndex = 6;
            // 
            // txtRatere
            // 
            this.txtRatere.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRatere.Location = new System.Drawing.Point(281, 228);
            this.txtRatere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRatere.Name = "txtRatere";
            this.txtRatere.ReadOnly = true;
            this.txtRatere.Size = new System.Drawing.Size(159, 52);
            this.txtRatere.TabIndex = 7;
            // 
            // txtMonthMoneyre
            // 
            this.txtMonthMoneyre.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMonthMoneyre.Location = new System.Drawing.Point(281, 310);
            this.txtMonthMoneyre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMonthMoneyre.Name = "txtMonthMoneyre";
            this.txtMonthMoneyre.ReadOnly = true;
            this.txtMonthMoneyre.Size = new System.Drawing.Size(159, 52);
            this.txtMonthMoneyre.TabIndex = 8;
            // 
            // txtTotalre
            // 
            this.txtTotalre.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalre.Location = new System.Drawing.Point(281, 388);
            this.txtTotalre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalre.Name = "txtTotalre";
            this.txtTotalre.ReadOnly = true;
            this.txtTotalre.Size = new System.Drawing.Size(159, 52);
            this.txtTotalre.TabIndex = 9;
            // 
            // LoanFormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(509, 562);
            this.Controls.Add(this.txtTotalre);
            this.Controls.Add(this.txtMonthMoneyre);
            this.Controls.Add(this.txtRatere);
            this.Controls.Add(this.txtYearre);
            this.Controls.Add(this.txtMoneyre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoanFormReport";
            this.Text = "LoanFormReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMoneyre;
        private System.Windows.Forms.TextBox txtYearre;
        private System.Windows.Forms.TextBox txtRatere;
        private System.Windows.Forms.TextBox txtMonthMoneyre;
        private System.Windows.Forms.TextBox txtTotalre;
    }
}