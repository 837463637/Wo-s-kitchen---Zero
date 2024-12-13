namespace wo_s_kitchen_Game.data.wo_s_kitchen.windows
{
    partial class Tutorial_FoodMarket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutorial_FoodMarket));
            this.Tutorial_FoodMarket_bird_01 = new System.Windows.Forms.Label();
            this.Tutorial_FoodMarket_buy_Grape_1 = new System.Windows.Forms.Button();
            this.Tutorial_FoodMarket_Grape = new System.Windows.Forms.Label();
            this.Tutorial_FoodMarket_Money = new System.Windows.Forms.Label();
            this.Tutorial_FoodMarket_grape_buy_Button = new wo_s_kitchen_Game.data.assets.RoundButton.RoundButton();
            this.SuspendLayout();
            // 
            // Tutorial_FoodMarket_bird_01
            // 
            this.Tutorial_FoodMarket_bird_01.AutoSize = true;
            this.Tutorial_FoodMarket_bird_01.BackColor = System.Drawing.Color.Transparent;
            this.Tutorial_FoodMarket_bird_01.Font = new System.Drawing.Font("微软雅黑", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tutorial_FoodMarket_bird_01.Location = new System.Drawing.Point(424, 25);
            this.Tutorial_FoodMarket_bird_01.Name = "Tutorial_FoodMarket_bird_01";
            this.Tutorial_FoodMarket_bird_01.Size = new System.Drawing.Size(230, 156);
            this.Tutorial_FoodMarket_bird_01.TabIndex = 0;
            this.Tutorial_FoodMarket_bird_01.Text = "🐦️";
            this.Tutorial_FoodMarket_bird_01.Click += new System.EventHandler(this.label1_Click);
            // 
            // Tutorial_FoodMarket_buy_Grape_1
            // 
            this.Tutorial_FoodMarket_buy_Grape_1.Font = new System.Drawing.Font("微软雅黑", 30F);
            this.Tutorial_FoodMarket_buy_Grape_1.Location = new System.Drawing.Point(375, 329);
            this.Tutorial_FoodMarket_buy_Grape_1.Name = "Tutorial_FoodMarket_buy_Grape_1";
            this.Tutorial_FoodMarket_buy_Grape_1.Size = new System.Drawing.Size(279, 91);
            this.Tutorial_FoodMarket_buy_Grape_1.TabIndex = 1;
            this.Tutorial_FoodMarket_buy_Grape_1.Text = "购买🍇x9";
            this.Tutorial_FoodMarket_buy_Grape_1.UseVisualStyleBackColor = true;
            this.Tutorial_FoodMarket_buy_Grape_1.Click += new System.EventHandler(this.buy_grape_Click);
            // 
            // Tutorial_FoodMarket_Grape
            // 
            this.Tutorial_FoodMarket_Grape.AutoSize = true;
            this.Tutorial_FoodMarket_Grape.Font = new System.Drawing.Font("微软雅黑", 70F);
            this.Tutorial_FoodMarket_Grape.Location = new System.Drawing.Point(429, 194);
            this.Tutorial_FoodMarket_Grape.Name = "Tutorial_FoodMarket_Grape";
            this.Tutorial_FoodMarket_Grape.Size = new System.Drawing.Size(176, 121);
            this.Tutorial_FoodMarket_Grape.TabIndex = 2;
            this.Tutorial_FoodMarket_Grape.Text = "🍇";
            // 
            // Tutorial_FoodMarket_Money
            // 
            this.Tutorial_FoodMarket_Money.AutoSize = true;
            this.Tutorial_FoodMarket_Money.Location = new System.Drawing.Point(918, 9);
            this.Tutorial_FoodMarket_Money.Name = "Tutorial_FoodMarket_Money";
            this.Tutorial_FoodMarket_Money.Size = new System.Drawing.Size(88, 17);
            this.Tutorial_FoodMarket_Money.TabIndex = 3;
            this.Tutorial_FoodMarket_Money.Text = "💰︎:999999999";
            // 
            // Tutorial_FoodMarket_grape_buy_Button
            // 
            this.Tutorial_FoodMarket_grape_buy_Button.BackColor = System.Drawing.Color.Transparent;
            this.Tutorial_FoodMarket_grape_buy_Button.FlatAppearance.BorderSize = 0;
            this.Tutorial_FoodMarket_grape_buy_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tutorial_FoodMarket_grape_buy_Button.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tutorial_FoodMarket_grape_buy_Button.Location = new System.Drawing.Point(375, 329);
            this.Tutorial_FoodMarket_grape_buy_Button.Name = "Tutorial_FoodMarket_grape_buy_Button";
            this.Tutorial_FoodMarket_grape_buy_Button.Size = new System.Drawing.Size(279, 91);
            this.Tutorial_FoodMarket_grape_buy_Button.TabIndex = 4;
            this.Tutorial_FoodMarket_grape_buy_Button.Text = "购买葡萄x9";
            this.Tutorial_FoodMarket_grape_buy_Button.UseVisualStyleBackColor = false;
            this.Tutorial_FoodMarket_grape_buy_Button.Click += new System.EventHandler(this.buy_grape_Click);
            // 
            // Tutorial_FoodMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 639);
            this.Controls.Add(this.Tutorial_FoodMarket_grape_buy_Button);
            this.Controls.Add(this.Tutorial_FoodMarket_Money);
            this.Controls.Add(this.Tutorial_FoodMarket_Grape);
            this.Controls.Add(this.Tutorial_FoodMarket_buy_Grape_1);
            this.Controls.Add(this.Tutorial_FoodMarket_bird_01);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tutorial_FoodMarket";
            this.Text = "菜市场";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tutorial_FoodMarket_bird_01;
        private System.Windows.Forms.Button Tutorial_FoodMarket_buy_Grape_1;
        private System.Windows.Forms.Label Tutorial_FoodMarket_Grape;
        private System.Windows.Forms.Label Tutorial_FoodMarket_Money;
        private assets.RoundButton.RoundButton Tutorial_FoodMarket_grape_buy_Button;
    }
}