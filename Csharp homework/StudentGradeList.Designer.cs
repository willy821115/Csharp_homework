namespace Csharp_homework
{
    partial class StudentGradeList
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
            this.listAanalysis = new System.Windows.Forms.ListView();
            this.colnsub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colnTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colnAvage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colnMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colnMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listScore = new System.Windows.Forms.ListView();
            this.colmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmChinese = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmEnglish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmMath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmAvage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnanalysis = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSerch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listAanalysis
            // 
            this.listAanalysis.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listAanalysis.BackColor = System.Drawing.SystemColors.Menu;
            this.listAanalysis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colnsub,
            this.colnTotal,
            this.colnAvage,
            this.colnMin,
            this.colnMax});
            this.listAanalysis.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listAanalysis.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listAanalysis.HideSelection = false;
            this.listAanalysis.HoverSelection = true;
            this.listAanalysis.Location = new System.Drawing.Point(158, 315);
            this.listAanalysis.Name = "listAanalysis";
            this.listAanalysis.Size = new System.Drawing.Size(311, 123);
            this.listAanalysis.TabIndex = 25;
            this.listAanalysis.UseCompatibleStateImageBehavior = false;
            this.listAanalysis.View = System.Windows.Forms.View.Details;
            // 
            // colnsub
            // 
            this.colnsub.Text = "科目";
            // 
            // colnTotal
            // 
            this.colnTotal.Text = "總分";
            // 
            // colnAvage
            // 
            this.colnAvage.Text = "平均";
            // 
            // colnMin
            // 
            this.colnMin.Text = "最低";
            this.colnMin.Width = 63;
            // 
            // colnMax
            // 
            this.colnMax.Text = "最高";
            // 
            // listScore
            // 
            this.listScore.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listScore.BackColor = System.Drawing.SystemColors.Menu;
            this.listScore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colmName,
            this.colmChinese,
            this.colmEnglish,
            this.colmMath,
            this.colmTotal,
            this.colmAvage,
            this.colmMin,
            this.colmMax});
            this.listScore.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listScore.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listScore.HideSelection = false;
            this.listScore.HoverSelection = true;
            this.listScore.Location = new System.Drawing.Point(158, 12);
            this.listScore.Name = "listScore";
            this.listScore.Size = new System.Drawing.Size(487, 297);
            this.listScore.TabIndex = 24;
            this.listScore.UseCompatibleStateImageBehavior = false;
            this.listScore.View = System.Windows.Forms.View.Details;
            // 
            // colmName
            // 
            this.colmName.Text = "姓名";
            // 
            // colmChinese
            // 
            this.colmChinese.Text = "國文";
            // 
            // colmEnglish
            // 
            this.colmEnglish.Text = "英文";
            // 
            // colmMath
            // 
            this.colmMath.Text = "數學";
            // 
            // colmTotal
            // 
            this.colmTotal.Text = "總分";
            // 
            // colmAvage
            // 
            this.colmAvage.Text = "平均";
            // 
            // colmMin
            // 
            this.colmMin.Text = "最低";
            this.colmMin.Width = 63;
            // 
            // colmMax
            // 
            this.colmMax.Text = "最高";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(7, 180);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 30);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "加入學生資料";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(72, 138);
            this.txtMath.Margin = new System.Windows.Forms.Padding(2);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(67, 29);
            this.txtMath.TabIndex = 22;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnglish.Location = new System.Drawing.Point(72, 98);
            this.txtEnglish.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(67, 29);
            this.txtEnglish.TabIndex = 21;
            // 
            // txtChinese
            // 
            this.txtChinese.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChinese.Location = new System.Drawing.Point(72, 57);
            this.txtChinese.Margin = new System.Windows.Forms.Padding(2);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(67, 29);
            this.txtChinese.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(72, 15);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(67, 29);
            this.txtName.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(15, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "數學:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(15, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "英文:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "國文:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "姓名:";
            // 
            // btninsert
            // 
            this.btninsert.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btninsert.Location = new System.Drawing.Point(7, 214);
            this.btninsert.Margin = new System.Windows.Forms.Padding(2);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(130, 30);
            this.btninsert.TabIndex = 26;
            this.btninsert.Text = "插入學生資料";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemove.Location = new System.Drawing.Point(7, 248);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(130, 30);
            this.btnRemove.TabIndex = 27;
            this.btnRemove.Text = "移除資料";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(7, 282);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 30);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "清除所有資料";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnanalysis
            // 
            this.btnanalysis.Enabled = false;
            this.btnanalysis.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnanalysis.Location = new System.Drawing.Point(496, 363);
            this.btnanalysis.Margin = new System.Windows.Forms.Padding(2);
            this.btnanalysis.Name = "btnanalysis";
            this.btnanalysis.Size = new System.Drawing.Size(130, 30);
            this.btnanalysis.TabIndex = 29;
            this.btnanalysis.Text = "各科統計";
            this.btnanalysis.UseVisualStyleBackColor = true;
            this.btnanalysis.Click += new System.EventHandler(this.btnanalysis_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(12, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "搜尋國文成績範圍";
            // 
            // txtLow
            // 
            this.txtLow.Location = new System.Drawing.Point(8, 371);
            this.txtLow.Name = "txtLow";
            this.txtLow.Size = new System.Drawing.Size(50, 22);
            this.txtLow.TabIndex = 31;
            // 
            // txtHigh
            // 
            this.txtHigh.Location = new System.Drawing.Point(86, 371);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.Size = new System.Drawing.Size(50, 22);
            this.txtHigh.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(65, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "~";
            // 
            // btnSerch
            // 
            this.btnSerch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSerch.Location = new System.Drawing.Point(7, 408);
            this.btnSerch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(130, 30);
            this.btnSerch.TabIndex = 34;
            this.btnSerch.Text = "Search";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // StudentGradeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 451);
            this.Controls.Add(this.btnSerch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHigh);
            this.Controls.Add(this.txtLow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnanalysis);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.listAanalysis);
            this.Controls.Add(this.listScore);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentGradeList";
            this.Text = "StudentGradeList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listAanalysis;
        public System.Windows.Forms.ColumnHeader colnsub;
        private System.Windows.Forms.ColumnHeader colnTotal;
        private System.Windows.Forms.ColumnHeader colnAvage;
        private System.Windows.Forms.ColumnHeader colnMin;
        private System.Windows.Forms.ColumnHeader colnMax;
        private System.Windows.Forms.ListView listScore;
        public System.Windows.Forms.ColumnHeader colmName;
        private System.Windows.Forms.ColumnHeader colmChinese;
        private System.Windows.Forms.ColumnHeader colmEnglish;
        private System.Windows.Forms.ColumnHeader colmMath;
        private System.Windows.Forms.ColumnHeader colmTotal;
        private System.Windows.Forms.ColumnHeader colmAvage;
        private System.Windows.Forms.ColumnHeader colmMin;
        public System.Windows.Forms.ColumnHeader colmMax;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnanalysis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSerch;
    }
}