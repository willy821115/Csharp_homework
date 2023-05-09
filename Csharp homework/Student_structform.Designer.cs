namespace Csharp_homework
{
    partial class Student_structform
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
            this.labname = new System.Windows.Forms.Label();
            this.labChinese = new System.Windows.Forms.Label();
            this.labEnglish = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labMaxMin = new System.Windows.Forms.Label();
            this.labScore = new System.Windows.Forms.Label();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labname.Location = new System.Drawing.Point(61, 67);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(57, 21);
            this.labname.TabIndex = 0;
            this.labname.Text = "姓名:";
            // 
            // labChinese
            // 
            this.labChinese.AutoSize = true;
            this.labChinese.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChinese.Location = new System.Drawing.Point(61, 127);
            this.labChinese.Name = "labChinese";
            this.labChinese.Size = new System.Drawing.Size(57, 21);
            this.labChinese.TabIndex = 1;
            this.labChinese.Text = "國文:";
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnglish.Location = new System.Drawing.Point(61, 185);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(57, 21);
            this.labEnglish.TabIndex = 2;
            this.labEnglish.Text = "英文:";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(61, 245);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(57, 21);
            this.labMath.TabIndex = 3;
            this.labMath.Text = "數學:";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtname.Location = new System.Drawing.Point(124, 60);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(126, 35);
            this.txtname.TabIndex = 4;
            // 
            // txtChinese
            // 
            this.txtChinese.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChinese.Location = new System.Drawing.Point(124, 120);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(126, 35);
            this.txtChinese.TabIndex = 5;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnglish.Location = new System.Drawing.Point(124, 178);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(126, 35);
            this.txtEnglish.TabIndex = 6;
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(124, 238);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(126, 35);
            this.txtMath.TabIndex = 7;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnsave.Location = new System.Drawing.Point(50, 314);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(114, 45);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "儲存";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShow.Location = new System.Drawing.Point(195, 314);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(114, 45);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "顯示儲存內容";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labMaxMin);
            this.groupBox1.Controls.Add(this.labScore);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(401, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 333);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // labMaxMin
            // 
            this.labMaxMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labMaxMin.Location = new System.Drawing.Point(14, 219);
            this.labMaxMin.Name = "labMaxMin";
            this.labMaxMin.Size = new System.Drawing.Size(331, 105);
            this.labMaxMin.TabIndex = 1;
            // 
            // labScore
            // 
            this.labScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labScore.Location = new System.Drawing.Point(14, 29);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(331, 180);
            this.labScore.TabIndex = 0;
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMaxMin.Location = new System.Drawing.Point(554, 365);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(203, 45);
            this.btnMaxMin.TabIndex = 11;
            this.btnMaxMin.Text = "最高分/最低分科目";
            this.btnMaxMin.UseVisualStyleBackColor = true;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // Student_structform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMaxMin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.labChinese);
            this.Controls.Add(this.labname);
            this.Name = "Student_structform";
            this.Text = "Student_structform";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.Label labChinese;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labMaxMin;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Button btnMaxMin;
    }
}