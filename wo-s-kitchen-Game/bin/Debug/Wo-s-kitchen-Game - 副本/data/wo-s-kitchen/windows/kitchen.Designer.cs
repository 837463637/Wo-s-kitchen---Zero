namespace wo_s_kitchen_Game.data.wo_s_kitchen.windows
{
    partial class Tutorial_kitchen_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutorial_kitchen_1));
            this.Tutorial_Grape_nine_make = new System.Windows.Forms.ProgressBar();
            this.Tutorial_kitchen_make_1 = new wo_s_kitchen_Game.data.assets.RoundButton.RoundButton();
            this.SuspendLayout();
            // 
            // Tutorial_Grape_nine_make
            // 
            this.Tutorial_Grape_nine_make.Location = new System.Drawing.Point(318, 169);
            this.Tutorial_Grape_nine_make.Name = "Tutorial_Grape_nine_make";
            this.Tutorial_Grape_nine_make.Size = new System.Drawing.Size(367, 27);
            this.Tutorial_Grape_nine_make.TabIndex = 1;
            // 
            // Tutorial_kitchen_make_1
            // 
            this.Tutorial_kitchen_make_1.BackColor = System.Drawing.Color.Transparent;
            this.Tutorial_kitchen_make_1.FlatAppearance.BorderSize = 0;
            this.Tutorial_kitchen_make_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tutorial_kitchen_make_1.Location = new System.Drawing.Point(342, 310);
            this.Tutorial_kitchen_make_1.Name = "Tutorial_kitchen_make_1";
            this.Tutorial_kitchen_make_1.Size = new System.Drawing.Size(323, 99);
            this.Tutorial_kitchen_make_1.TabIndex = 2;
            this.Tutorial_kitchen_make_1.Text = "制作";
            this.Tutorial_kitchen_make_1.UseVisualStyleBackColor = false;
            this.Tutorial_kitchen_make_1.Click += new System.EventHandler(this.grape_nine_make_button_Click);
            // 
            // Tutorial_kitchen_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1025, 605);
            this.Controls.Add(this.Tutorial_kitchen_make_1);
            this.Controls.Add(this.Tutorial_Grape_nine_make);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tutorial_kitchen_1";
            this.Text = "我的厨房";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar Tutorial_Grape_nine_make;
        private assets.RoundButton.RoundButton Tutorial_kitchen_make_1;
    }
}