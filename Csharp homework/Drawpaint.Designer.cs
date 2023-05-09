namespace Csharp_homework
{
    partial class Drawpaint
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
            this.btncolor = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labcolor = new System.Windows.Forms.Label();
            this.picPaint = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaint)).BeginInit();
            this.SuspendLayout();
            // 
            // btncolor
            // 
            this.btncolor.Location = new System.Drawing.Point(671, 41);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(70, 37);
            this.btncolor.TabIndex = 0;
            this.btncolor.Text = "顏色";
            this.btncolor.UseVisualStyleBackColor = true;
            this.btncolor.Click += new System.EventHandler(this.btncolor_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(696, 146);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 169);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labcolor
            // 
            this.labcolor.BackColor = System.Drawing.Color.Black;
            this.labcolor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labcolor.Location = new System.Drawing.Point(671, 96);
            this.labcolor.Name = "labcolor";
            this.labcolor.Size = new System.Drawing.Size(69, 33);
            this.labcolor.TabIndex = 2;
            // 
            // picPaint
            // 
            this.picPaint.Location = new System.Drawing.Point(-1, -1);
            this.picPaint.Name = "picPaint";
            this.picPaint.Size = new System.Drawing.Size(789, 469);
            this.picPaint.TabIndex = 3;
            this.picPaint.TabStop = false;
            this.picPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picPaint_MouseDown);
            this.picPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picPaint_MouseMove);
            // 
            // Drawpaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 470);
            this.Controls.Add(this.labcolor);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btncolor);
            this.Controls.Add(this.picPaint);
            this.Name = "Drawpaint";
            this.Text = "Drawpaint";
            this.Load += new System.EventHandler(this.Drawpaint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncolor;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labcolor;
        private System.Windows.Forms.PictureBox picPaint;
    }
}