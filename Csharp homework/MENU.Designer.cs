namespace Csharp_homework
{
    partial class MENU
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
            System.Windows.Forms.Button btnWhiskey;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MENU));
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.btnTower = new System.Windows.Forms.Button();
            this.btnTea = new System.Windows.Forms.Button();
            this.btnVodka = new System.Windows.Forms.Button();
            this.grpPay = new System.Windows.Forms.GroupBox();
            this.labPay = new System.Windows.Forms.Label();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.labList = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpPayWay = new System.Windows.Forms.GroupBox();
            this.btnCash = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            btnWhiskey = new System.Windows.Forms.Button();
            this.grpMenu.SuspendLayout();
            this.grpPay.SuspendLayout();
            this.grpList.SuspendLayout();
            this.grpPayWay.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWhiskey
            // 
            btnWhiskey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWhiskey.BackgroundImage")));
            btnWhiskey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnWhiskey.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            btnWhiskey.ForeColor = System.Drawing.Color.Black;
            btnWhiskey.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            btnWhiskey.Location = new System.Drawing.Point(6, 30);
            btnWhiskey.Name = "btnWhiskey";
            btnWhiskey.Size = new System.Drawing.Size(130, 167);
            btnWhiskey.TabIndex = 3;
            btnWhiskey.Text = "威士忌 NT600";
            btnWhiskey.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            btnWhiskey.UseVisualStyleBackColor = true;
            btnWhiskey.Click += new System.EventHandler(this.btnWhiskey_Click);
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnTower);
            this.grpMenu.Controls.Add(this.btnTea);
            this.grpMenu.Controls.Add(this.btnVodka);
            this.grpMenu.Controls.Add(btnWhiskey);
            this.grpMenu.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpMenu.Location = new System.Drawing.Point(12, 24);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(281, 373);
            this.grpMenu.TabIndex = 0;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "菜單 MENU";
            // 
            // btnTower
            // 
            this.btnTower.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTower.BackgroundImage")));
            this.btnTower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTower.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTower.ForeColor = System.Drawing.SystemColors.Info;
            this.btnTower.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTower.Location = new System.Drawing.Point(145, 200);
            this.btnTower.Name = "btnTower";
            this.btnTower.Size = new System.Drawing.Size(130, 167);
            this.btnTower.TabIndex = 5;
            this.btnTower.Text = "香檳塔NT10000";
            this.btnTower.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTower.UseVisualStyleBackColor = true;
            this.btnTower.Click += new System.EventHandler(this.btnTower_Click);
            // 
            // btnTea
            // 
            this.btnTea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTea.BackgroundImage")));
            this.btnTea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTea.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTea.ForeColor = System.Drawing.Color.Black;
            this.btnTea.Location = new System.Drawing.Point(6, 200);
            this.btnTea.Name = "btnTea";
            this.btnTea.Size = new System.Drawing.Size(130, 167);
            this.btnTea.TabIndex = 6;
            this.btnTea.Text = "烏龍茶(可燃)NT550";
            this.btnTea.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTea.UseVisualStyleBackColor = true;
            this.btnTea.Click += new System.EventHandler(this.btnTea_Click);
            // 
            // btnVodka
            // 
            this.btnVodka.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVodka.BackgroundImage")));
            this.btnVodka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVodka.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVodka.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVodka.Location = new System.Drawing.Point(145, 30);
            this.btnVodka.Name = "btnVodka";
            this.btnVodka.Size = new System.Drawing.Size(130, 167);
            this.btnVodka.TabIndex = 4;
            this.btnVodka.Text = "伏特加  NT500";
            this.btnVodka.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVodka.UseVisualStyleBackColor = true;
            this.btnVodka.Click += new System.EventHandler(this.btnVodka_Click);
            // 
            // grpPay
            // 
            this.grpPay.Controls.Add(this.labPay);
            this.grpPay.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpPay.Location = new System.Drawing.Point(310, 34);
            this.grpPay.Name = "grpPay";
            this.grpPay.Size = new System.Drawing.Size(216, 84);
            this.grpPay.TabIndex = 1;
            this.grpPay.TabStop = false;
            this.grpPay.Text = "總金額 Total Price";
            // 
            // labPay
            // 
            this.labPay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labPay.ForeColor = System.Drawing.Color.Snow;
            this.labPay.Location = new System.Drawing.Point(7, 31);
            this.labPay.Name = "labPay";
            this.labPay.Size = new System.Drawing.Size(203, 44);
            this.labPay.TabIndex = 0;
            this.labPay.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.btnClear);
            this.grpList.Controls.Add(this.labList);
            this.grpList.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpList.Location = new System.Drawing.Point(542, 34);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(247, 362);
            this.grpList.TabIndex = 2;
            this.grpList.TabStop = false;
            this.grpList.Text = "清單 List";
            // 
            // labList
            // 
            this.labList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labList.ForeColor = System.Drawing.Color.Black;
            this.labList.Location = new System.Drawing.Point(13, 35);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(228, 253);
            this.labList.TabIndex = 0;
            this.labList.Text = "尚未點餐";
            this.labList.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(112, 302);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 52);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "清除清單";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpPayWay
            // 
            this.grpPayWay.Controls.Add(this.label1);
            this.grpPayWay.Controls.Add(this.button1);
            this.grpPayWay.Controls.Add(this.btnCash);
            this.grpPayWay.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpPayWay.Location = new System.Drawing.Point(316, 146);
            this.grpPayWay.Name = "grpPayWay";
            this.grpPayWay.Size = new System.Drawing.Size(209, 162);
            this.grpPayWay.TabIndex = 3;
            this.grpPayWay.TabStop = false;
            this.grpPayWay.Text = "付款方式";
            // 
            // btnCash
            // 
            this.btnCash.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCash.ForeColor = System.Drawing.Color.Black;
            this.btnCash.Location = new System.Drawing.Point(9, 73);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(90, 56);
            this.btnCash.TabIndex = 0;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(113, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "信用卡";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(101, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "信用卡享九折";
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpPayWay);
            this.Controls.Add(this.grpList);
            this.Controls.Add(this.grpPay);
            this.Controls.Add(this.grpMenu);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "MENU";
            this.Text = "MENU";
            this.grpMenu.ResumeLayout(false);
            this.grpPay.ResumeLayout(false);
            this.grpList.ResumeLayout(false);
            this.grpPayWay.ResumeLayout(false);
            this.grpPayWay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Button btnTower;
        private System.Windows.Forms.Button btnTea;
        private System.Windows.Forms.Button btnVodka;
        private System.Windows.Forms.GroupBox grpPay;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.Label labPay;
        private System.Windows.Forms.Label labList;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpPayWay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Label label1;
    }
}