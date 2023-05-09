namespace Csharp_homework
{
    partial class Alarm
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
            this.labNowTime = new System.Windows.Forms.Label();
            this.grpSelet = new System.Windows.Forms.GroupBox();
            this.checkSet = new System.Windows.Forms.CheckBox();
            this.masktxtSetTime = new System.Windows.Forms.MaskedTextBox();
            this.labAlarmTime = new System.Windows.Forms.Label();
            this.timerNowTime = new System.Windows.Forms.Timer(this.components);
            this.timerSet = new System.Windows.Forms.Timer(this.components);
            this.grpSelet.SuspendLayout();
            this.SuspendLayout();
            // 
            // labNowTime
            // 
            this.labNowTime.AutoSize = true;
            this.labNowTime.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNowTime.Location = new System.Drawing.Point(48, 50);
            this.labNowTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labNowTime.Name = "labNowTime";
            this.labNowTime.Size = new System.Drawing.Size(92, 35);
            this.labNowTime.TabIndex = 0;
            this.labNowTime.Text = "label1";
            // 
            // grpSelet
            // 
            this.grpSelet.Controls.Add(this.checkSet);
            this.grpSelet.Controls.Add(this.masktxtSetTime);
            this.grpSelet.Controls.Add(this.labAlarmTime);
            this.grpSelet.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpSelet.Location = new System.Drawing.Point(176, 106);
            this.grpSelet.Margin = new System.Windows.Forms.Padding(2);
            this.grpSelet.Name = "grpSelet";
            this.grpSelet.Padding = new System.Windows.Forms.Padding(2);
            this.grpSelet.Size = new System.Drawing.Size(386, 271);
            this.grpSelet.TabIndex = 1;
            this.grpSelet.TabStop = false;
            this.grpSelet.Text = "Select Time";
            // 
            // checkSet
            // 
            this.checkSet.AutoSize = true;
            this.checkSet.Location = new System.Drawing.Point(155, 171);
            this.checkSet.Margin = new System.Windows.Forms.Padding(2);
            this.checkSet.Name = "checkSet";
            this.checkSet.Size = new System.Drawing.Size(131, 32);
            this.checkSet.TabIndex = 2;
            this.checkSet.Text = "Set Alarm";
            this.checkSet.UseVisualStyleBackColor = true;
            this.checkSet.CheckedChanged += new System.EventHandler(this.checkSet_CheckedChanged);
            // 
            // masktxtSetTime
            // 
            this.masktxtSetTime.Location = new System.Drawing.Point(155, 113);
            this.masktxtSetTime.Margin = new System.Windows.Forms.Padding(2);
            this.masktxtSetTime.Mask = "90時90分90秒";
            this.masktxtSetTime.Name = "masktxtSetTime";
            this.masktxtSetTime.Size = new System.Drawing.Size(156, 36);
            this.masktxtSetTime.TabIndex = 1;
            this.masktxtSetTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labAlarmTime
            // 
            this.labAlarmTime.AutoSize = true;
            this.labAlarmTime.Location = new System.Drawing.Point(15, 114);
            this.labAlarmTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labAlarmTime.Name = "labAlarmTime";
            this.labAlarmTime.Size = new System.Drawing.Size(134, 28);
            this.labAlarmTime.TabIndex = 0;
            this.labAlarmTime.Text = "Alarm Time:";
            // 
            // timerNowTime
            // 
            this.timerNowTime.Tick += new System.EventHandler(this.timerNowTime_Tick);
            // 
            // timerSet
            // 
            this.timerSet.Tick += new System.EventHandler(this.timerSet_Tick);
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(648, 406);
            this.Controls.Add(this.grpSelet);
            this.Controls.Add(this.labNowTime);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Alarm";
            this.Text = "Alarm";
            this.grpSelet.ResumeLayout(false);
            this.grpSelet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNowTime;
        private System.Windows.Forms.GroupBox grpSelet;
        private System.Windows.Forms.MaskedTextBox masktxtSetTime;
        private System.Windows.Forms.Label labAlarmTime;
        private System.Windows.Forms.CheckBox checkSet;
        private System.Windows.Forms.Timer timerNowTime;
        private System.Windows.Forms.Timer timerSet;
    }
}