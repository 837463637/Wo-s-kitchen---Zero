namespace wo_s_kitchen_Game
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.GameName = new System.Windows.Forms.Label();
            this.roundButton3 = new wo_s_kitchen_Game.data.assets.RoundButton.RoundButton();
            this.roundButton2 = new wo_s_kitchen_Game.data.assets.RoundButton.RoundButton();
            this.roundButton1 = new wo_s_kitchen_Game.data.assets.RoundButton.RoundButton();
            this.SuspendLayout();
            // 
            // GameName
            // 
            this.GameName.AutoSize = true;
            this.GameName.BackColor = System.Drawing.SystemColors.Control;
            this.GameName.Font = new System.Drawing.Font("微软雅黑", 35F);
            this.GameName.Location = new System.Drawing.Point(-4, 33);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(355, 60);
            this.GameName.TabIndex = 0;
            this.GameName.Text = "沃的厨房 - 归零";
            this.GameName.Click += new System.EventHandler(this.GameName_Click);
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.Transparent;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.Font = new System.Drawing.Font("微软雅黑", 25F);
            this.roundButton3.Location = new System.Drawing.Point(22, 414);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(290, 76);
            this.roundButton3.TabIndex = 6;
            this.roundButton3.Text = "退出游戏";
            this.roundButton3.UseVisualStyleBackColor = true;
            this.roundButton3.Click += new System.EventHandler(this.ExitGame);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.Transparent;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Font = new System.Drawing.Font("微软雅黑", 25F);
            this.roundButton2.Location = new System.Drawing.Point(22, 279);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(290, 76);
            this.roundButton2.TabIndex = 5;
            this.roundButton2.Text = "设置";
            this.roundButton2.UseVisualStyleBackColor = true;
            this.roundButton2.Click += new System.EventHandler(this.OpenSettings);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.Transparent;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("微软雅黑", 25F);
            this.roundButton1.Location = new System.Drawing.Point(22, 147);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(290, 76);
            this.roundButton1.TabIndex = 4;
            this.roundButton1.Text = "开始游戏";
            this.roundButton1.UseVisualStyleBackColor = true;
            this.roundButton1.Click += new System.EventHandler(this.StartGame);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1567, 815);
            this.Controls.Add(this.roundButton3);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.GameName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "沃的厨房 - 归零";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameName;
        private data.assets.RoundButton.RoundButton roundButton1;
        private data.assets.RoundButton.RoundButton roundButton2;
        private data.assets.RoundButton.RoundButton roundButton3;
    }
}