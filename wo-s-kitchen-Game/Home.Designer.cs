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
            this.ExitGameButton = new wo_s_kitchen_Game.data.assets.RoundButton.RoundButton();
            this.SettingsButton = new wo_s_kitchen_Game.data.assets.RoundButton.RoundButton();
            this.GameStartButton = new wo_s_kitchen_Game.data.assets.RoundButton.RoundButton();
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
            // ExitGameButton
            // 
            this.ExitGameButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitGameButton.Font = new System.Drawing.Font("微软雅黑", 25F);
            this.ExitGameButton.Location = new System.Drawing.Point(21, 414);
            this.ExitGameButton.Name = "ExitGameButton";
            this.ExitGameButton.Size = new System.Drawing.Size(290, 76);
            this.ExitGameButton.TabIndex = 6;
            this.ExitGameButton.Text = "退出游戏";
            this.ExitGameButton.UseVisualStyleBackColor = true;
            this.ExitGameButton.Click += new System.EventHandler(this.ExitGame);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("微软雅黑", 25F);
            this.SettingsButton.Location = new System.Drawing.Point(22, 279);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(290, 76);
            this.SettingsButton.TabIndex = 5;
            this.SettingsButton.Text = "设置";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.OpenSettings);
            // 
            // GameStartButton
            // 
            this.GameStartButton.BackColor = System.Drawing.Color.Transparent;
            this.GameStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameStartButton.Font = new System.Drawing.Font("微软雅黑", 25F);
            this.GameStartButton.Location = new System.Drawing.Point(22, 147);
            this.GameStartButton.Name = "GameStartButton";
            this.GameStartButton.Size = new System.Drawing.Size(290, 76);
            this.GameStartButton.TabIndex = 4;
            this.GameStartButton.Text = "开始游戏";
            this.GameStartButton.UseVisualStyleBackColor = true;
            this.GameStartButton.Click += new System.EventHandler(this.StartGame);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1567, 815);
            this.Controls.Add(this.ExitGameButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.GameStartButton);
            this.Controls.Add(this.GameName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "沃的厨房 - 归零";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NoGame);
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameName;
        private data.assets.RoundButton.RoundButton GameStartButton;
        private data.assets.RoundButton.RoundButton SettingsButton;
        private data.assets.RoundButton.RoundButton ExitGameButton;
    }
}