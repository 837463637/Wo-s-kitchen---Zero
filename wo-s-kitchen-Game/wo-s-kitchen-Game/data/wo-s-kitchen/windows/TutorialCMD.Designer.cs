namespace wo_s_kitchen_Game.data.wo_s_kitchen.windows
{
    partial class TutorialCMD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutorialCMD));
            this.Tutorial_What_code = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.其他ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.无ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.WhatCode_Fa = new System.Windows.Forms.ComboBox();
            this.Tutorial_CMD_Button_OK = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tutorial_What_code
            // 
            this.Tutorial_What_code.AutoSize = true;
            this.Tutorial_What_code.Location = new System.Drawing.Point(128, 167);
            this.Tutorial_What_code.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tutorial_What_code.Name = "Tutorial_What_code";
            this.Tutorial_What_code.Size = new System.Drawing.Size(80, 17);
            this.Tutorial_What_code.TabIndex = 0;
            this.Tutorial_What_code.Text = "请输入指令：";
            this.Tutorial_What_code.Click += new System.EventHandler(this.Tutorial_What_code_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem,
            this.其他ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(751, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.帮助ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.帮助ToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItem2.Text = "1.FoodMarket";
            // 
            // 其他ToolStripMenuItem
            // 
            this.其他ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.无ToolStripMenuItem});
            this.其他ToolStripMenuItem.Name = "其他ToolStripMenuItem";
            this.其他ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.其他ToolStripMenuItem.Text = "其他";
            // 
            // 无ToolStripMenuItem
            // 
            this.无ToolStripMenuItem.Name = "无ToolStripMenuItem";
            this.无ToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.无ToolStripMenuItem.Text = "无";
            // 
            // WhatCode_Fa
            // 
            this.WhatCode_Fa.FormattingEnabled = true;
            this.WhatCode_Fa.Items.AddRange(new object[] {
            "FoodMarket",
            "Not"});
            this.WhatCode_Fa.Location = new System.Drawing.Point(246, 163);
            this.WhatCode_Fa.Margin = new System.Windows.Forms.Padding(4);
            this.WhatCode_Fa.Name = "WhatCode_Fa";
            this.WhatCode_Fa.Size = new System.Drawing.Size(266, 25);
            this.WhatCode_Fa.TabIndex = 2;
            // 
            // Tutorial_CMD_Button_OK
            // 
            this.Tutorial_CMD_Button_OK.Location = new System.Drawing.Point(264, 262);
            this.Tutorial_CMD_Button_OK.Margin = new System.Windows.Forms.Padding(4);
            this.Tutorial_CMD_Button_OK.Name = "Tutorial_CMD_Button_OK";
            this.Tutorial_CMD_Button_OK.Size = new System.Drawing.Size(195, 55);
            this.Tutorial_CMD_Button_OK.TabIndex = 3;
            this.Tutorial_CMD_Button_OK.Text = "OK";
            this.Tutorial_CMD_Button_OK.UseVisualStyleBackColor = true;
            this.Tutorial_CMD_Button_OK.Click += new System.EventHandler(this.Tutorial_CMD_Buttton_OK_Click);
            // 
            // TutorialCMD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 499);
            this.Controls.Add(this.Tutorial_CMD_Button_OK);
            this.Controls.Add(this.WhatCode_Fa);
            this.Controls.Add(this.Tutorial_What_code);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TutorialCMD";
            this.Text = "提示符";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tutorial_What_code;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 其他ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 无ToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ComboBox WhatCode_Fa;
        private System.Windows.Forms.Button Tutorial_CMD_Button_OK;
    }
}