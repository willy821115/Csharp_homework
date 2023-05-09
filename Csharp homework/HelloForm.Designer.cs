namespace Csharp_homework
{
    partial class HelloForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelloForm));
            this.labname = new System.Windows.Forms.Label();
            this.labENname = new System.Windows.Forms.Label();
            this.labsex = new System.Windows.Forms.Label();
            this.labstar = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtENname = new System.Windows.Forms.TextBox();
            this.txtsex = new System.Windows.Forms.TextBox();
            this.txtstar = new System.Windows.Forms.TextBox();
            this.btnHello = new System.Windows.Forms.Button();
            this.btnHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labname.Location = new System.Drawing.Point(201, 99);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(75, 34);
            this.labname.TabIndex = 0;
            this.labname.Text = "姓名:";
            // 
            // labENname
            // 
            this.labENname.AutoSize = true;
            this.labENname.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labENname.Location = new System.Drawing.Point(81, 152);
            this.labENname.Name = "labENname";
            this.labENname.Size = new System.Drawing.Size(195, 34);
            this.labENname.TabIndex = 1;
            this.labENname.Text = "English Name:";
            // 
            // labsex
            // 
            this.labsex.AutoSize = true;
            this.labsex.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labsex.Location = new System.Drawing.Point(201, 204);
            this.labsex.Name = "labsex";
            this.labsex.Size = new System.Drawing.Size(75, 34);
            this.labsex.TabIndex = 2;
            this.labsex.Text = "性別:";
            // 
            // labstar
            // 
            this.labstar.AutoSize = true;
            this.labstar.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labstar.Location = new System.Drawing.Point(201, 257);
            this.labstar.Name = "labstar";
            this.labstar.Size = new System.Drawing.Size(75, 34);
            this.labstar.TabIndex = 3;
            this.labstar.Text = "星座:";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtname.Location = new System.Drawing.Point(302, 94);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(199, 43);
            this.txtname.TabIndex = 4;
            // 
            // txtENname
            // 
            this.txtENname.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtENname.Location = new System.Drawing.Point(302, 147);
            this.txtENname.Name = "txtENname";
            this.txtENname.Size = new System.Drawing.Size(199, 43);
            this.txtENname.TabIndex = 5;
            // 
            // txtsex
            // 
            this.txtsex.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtsex.Location = new System.Drawing.Point(302, 199);
            this.txtsex.Name = "txtsex";
            this.txtsex.Size = new System.Drawing.Size(199, 43);
            this.txtsex.TabIndex = 6;
            // 
            // txtstar
            // 
            this.txtstar.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtstar.Location = new System.Drawing.Point(302, 252);
            this.txtstar.Name = "txtstar";
            this.txtstar.Size = new System.Drawing.Size(199, 43);
            this.txtstar.TabIndex = 7;
            // 
            // btnHello
            // 
            this.btnHello.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHello.Location = new System.Drawing.Point(304, 335);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(97, 56);
            this.btnHello.TabIndex = 8;
            this.btnHello.Text = "Say Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnHi
            // 
            this.btnHi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHi.Location = new System.Drawing.Point(439, 335);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(97, 56);
            this.btnHi.TabIndex = 9;
            this.btnHi.Text = "Say Hi";
            this.btnHi.UseVisualStyleBackColor = true;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.txtstar);
            this.Controls.Add(this.txtsex);
            this.Controls.Add(this.txtENname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.labstar);
            this.Controls.Add(this.labsex);
            this.Controls.Add(this.labENname);
            this.Controls.Add(this.labname);
            this.Name = "HelloForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.Label labENname;
        private System.Windows.Forms.Label labsex;
        private System.Windows.Forms.Label labstar;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtENname;
        private System.Windows.Forms.TextBox txtsex;
        private System.Windows.Forms.TextBox txtstar;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnHi;
    }
}