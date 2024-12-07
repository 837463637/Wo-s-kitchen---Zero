﻿namespace wo_s_kitchen_Game
{
    partial class TutorialWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutorialWindow));
            this.WhatTutorial = new System.Windows.Forms.Label();
            this.WhatTutorialEnglish = new System.Windows.Forms.Label();
            this.WhatTutorialYes_ch = new System.Windows.Forms.Button();
            this.WhatTutorialNo_ch = new System.Windows.Forms.Button();
            this.WhatTutorialYes_en = new System.Windows.Forms.Label();
            this.WhatTutorialNo_en = new System.Windows.Forms.Label();
            this.Tutorial_label_1 = new System.Windows.Forms.Label();
            this.Tutorial_label_2 = new System.Windows.Forms.Label();
            this.Tutorial_label_3 = new System.Windows.Forms.Label();
            this.Tutorial_button_1 = new System.Windows.Forms.Button();
            this.owl_Tutorial_what_1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.owl_Tutorial_what_1)).BeginInit();
            this.SuspendLayout();
            // 
            // WhatTutorial
            // 
            this.WhatTutorial.AutoSize = true;
            this.WhatTutorial.Location = new System.Drawing.Point(761, 185);
            this.WhatTutorial.Name = "WhatTutorial";
            this.WhatTutorial.Size = new System.Drawing.Size(164, 17);
            this.WhatTutorial.TabIndex = 1;
            this.WhatTutorial.Text = "你是否已经玩过了新手教程？";
            this.WhatTutorial.Click += new System.EventHandler(this.WhatTutorial_Click);
            // 
            // WhatTutorialEnglish
            // 
            this.WhatTutorialEnglish.AutoSize = true;
            this.WhatTutorialEnglish.Location = new System.Drawing.Point(710, 168);
            this.WhatTutorialEnglish.Name = "WhatTutorialEnglish";
            this.WhatTutorialEnglish.Size = new System.Drawing.Size(281, 17);
            this.WhatTutorialEnglish.TabIndex = 2;
            this.WhatTutorialEnglish.Text = "Have you already played the beginner tutorial?";
            this.WhatTutorialEnglish.Click += new System.EventHandler(this.label1_Click);
            // 
            // WhatTutorialYes_ch
            // 
            this.WhatTutorialYes_ch.Location = new System.Drawing.Point(664, 325);
            this.WhatTutorialYes_ch.Name = "WhatTutorialYes_ch";
            this.WhatTutorialYes_ch.Size = new System.Drawing.Size(144, 50);
            this.WhatTutorialYes_ch.TabIndex = 3;
            this.WhatTutorialYes_ch.Text = "是";
            this.WhatTutorialYes_ch.UseVisualStyleBackColor = true;
            // 
            // WhatTutorialNo_ch
            // 
            this.WhatTutorialNo_ch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.WhatTutorialNo_ch.Location = new System.Drawing.Point(895, 325);
            this.WhatTutorialNo_ch.Name = "WhatTutorialNo_ch";
            this.WhatTutorialNo_ch.Size = new System.Drawing.Size(144, 50);
            this.WhatTutorialNo_ch.TabIndex = 4;
            this.WhatTutorialNo_ch.Text = "否";
            this.WhatTutorialNo_ch.UseVisualStyleBackColor = true;
            this.WhatTutorialNo_ch.Click += new System.EventHandler(this.WhatTutorialYes_ch_Click);
            // 
            // WhatTutorialYes_en
            // 
            this.WhatTutorialYes_en.AutoSize = true;
            this.WhatTutorialYes_en.BackColor = System.Drawing.Color.Transparent;
            this.WhatTutorialYes_en.Location = new System.Drawing.Point(722, 378);
            this.WhatTutorialYes_en.Name = "WhatTutorialYes_en";
            this.WhatTutorialYes_en.Size = new System.Drawing.Size(28, 17);
            this.WhatTutorialYes_en.TabIndex = 5;
            this.WhatTutorialYes_en.Text = "Yes";
            this.WhatTutorialYes_en.Click += new System.EventHandler(this.WhatTutorialYes_en_Click);
            // 
            // WhatTutorialNo_en
            // 
            this.WhatTutorialNo_en.AutoSize = true;
            this.WhatTutorialNo_en.BackColor = System.Drawing.Color.Transparent;
            this.WhatTutorialNo_en.Location = new System.Drawing.Point(953, 378);
            this.WhatTutorialNo_en.Name = "WhatTutorialNo_en";
            this.WhatTutorialNo_en.Size = new System.Drawing.Size(26, 17);
            this.WhatTutorialNo_en.TabIndex = 6;
            this.WhatTutorialNo_en.Text = "No";
            // 
            // Tutorial_label_1
            // 
            this.Tutorial_label_1.AutoSize = true;
            this.Tutorial_label_1.Location = new System.Drawing.Point(563, 9);
            this.Tutorial_label_1.Name = "Tutorial_label_1";
            this.Tutorial_label_1.Size = new System.Drawing.Size(176, 17);
            this.Tutorial_label_1.TabIndex = 8;
            this.Tutorial_label_1.Text = "有客人来了，是谁呢？是猫头鹰";
            this.Tutorial_label_1.Visible = false;
            this.Tutorial_label_1.Click += new System.EventHandler(this.Tutorial_label_1_Click);
            // 
            // Tutorial_label_2
            // 
            this.Tutorial_label_2.AutoSize = true;
            this.Tutorial_label_2.Location = new System.Drawing.Point(531, 26);
            this.Tutorial_label_2.Name = "Tutorial_label_2";
            this.Tutorial_label_2.Size = new System.Drawing.Size(248, 17);
            this.Tutorial_label_2.TabIndex = 9;
            this.Tutorial_label_2.Text = "他要一份葡萄九，先去菜市场买一些葡萄吧！";
            this.Tutorial_label_2.Visible = false;
            this.Tutorial_label_2.Click += new System.EventHandler(this.Tutorial_label_2_Click);
            // 
            // Tutorial_label_3
            // 
            this.Tutorial_label_3.AutoSize = true;
            this.Tutorial_label_3.Location = new System.Drawing.Point(509, 43);
            this.Tutorial_label_3.Name = "Tutorial_label_3";
            this.Tutorial_label_3.Size = new System.Drawing.Size(312, 17);
            this.Tutorial_label_3.TabIndex = 10;
            this.Tutorial_label_3.Text = "（在提示符里输入：FoodMarket 即可打开菜市场窗口）";
            this.Tutorial_label_3.Visible = false;
            this.Tutorial_label_3.Click += new System.EventHandler(this.Tutorial_label_3_Click);
            // 
            // Tutorial_button_1
            // 
            this.Tutorial_button_1.Location = new System.Drawing.Point(566, 255);
            this.Tutorial_button_1.Name = "Tutorial_button_1";
            this.Tutorial_button_1.Size = new System.Drawing.Size(168, 64);
            this.Tutorial_button_1.TabIndex = 11;
            this.Tutorial_button_1.Text = "启动提示符";
            this.Tutorial_button_1.UseVisualStyleBackColor = true;
            this.Tutorial_button_1.Visible = false;
            this.Tutorial_button_1.Click += new System.EventHandler(this.Open_Tutorail_CMD_Button_Click);
            // 
            // owl_Tutorial_what_1
            // 
            this.owl_Tutorial_what_1.Image = ((System.Drawing.Image)(resources.GetObject("owl_Tutorial_what_1.Image")));
            this.owl_Tutorial_what_1.Location = new System.Drawing.Point(175, 152);
            this.owl_Tutorial_what_1.Name = "owl_Tutorial_what_1";
            this.owl_Tutorial_what_1.Size = new System.Drawing.Size(259, 277);
            this.owl_Tutorial_what_1.TabIndex = 7;
            this.owl_Tutorial_what_1.TabStop = false;
            this.owl_Tutorial_what_1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TutorialWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 653);
            this.Controls.Add(this.Tutorial_button_1);
            this.Controls.Add(this.Tutorial_label_3);
            this.Controls.Add(this.Tutorial_label_2);
            this.Controls.Add(this.Tutorial_label_1);
            this.Controls.Add(this.owl_Tutorial_what_1);
            this.Controls.Add(this.WhatTutorialNo_en);
            this.Controls.Add(this.WhatTutorialYes_en);
            this.Controls.Add(this.WhatTutorialNo_ch);
            this.Controls.Add(this.WhatTutorialYes_ch);
            this.Controls.Add(this.WhatTutorialEnglish);
            this.Controls.Add(this.WhatTutorial);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TutorialWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "沃的厨房 - 归零";
            ((System.ComponentModel.ISupportInitialize)(this.owl_Tutorial_what_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WhatTutorial;
        private System.Windows.Forms.Label WhatTutorialEnglish;
        private System.Windows.Forms.Button WhatTutorialYes_ch;
        private System.Windows.Forms.Button WhatTutorialNo_ch;
        private System.Windows.Forms.Label WhatTutorialYes_en;
        private System.Windows.Forms.Label WhatTutorialNo_en;
        private System.Windows.Forms.PictureBox owl_Tutorial_what_1;
        private System.Windows.Forms.Label Tutorial_label_1;
        private System.Windows.Forms.Label Tutorial_label_2;
        private System.Windows.Forms.Label Tutorial_label_3;
        private System.Windows.Forms.Button Tutorial_button_1;
    }
}