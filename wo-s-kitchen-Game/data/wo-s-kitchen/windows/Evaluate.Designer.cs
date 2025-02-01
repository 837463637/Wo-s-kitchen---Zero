namespace wo_s_kitchen_Game.data.wo_s_kitchen.windows
{
    partial class Tutoral_Evaluate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutoral_Evaluate));
            this.Tutorial_evaluate_1 = new System.Windows.Forms.Label();
            this.image_owl_Tutorial = new System.Windows.Forms.PictureBox();
            this.Tutorial_Evakuate_back_1 = new wo_s_kitchen_Game.data.assets.RoundButton.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.image_owl_Tutorial)).BeginInit();
            this.SuspendLayout();
            // 
            // Tutorial_evaluate_1
            // 
            this.Tutorial_evaluate_1.AutoSize = true;
            this.Tutorial_evaluate_1.BackColor = System.Drawing.SystemColors.Control;
            this.Tutorial_evaluate_1.Font = new System.Drawing.Font("微软雅黑", 23F);
            this.Tutorial_evaluate_1.Location = new System.Drawing.Point(179, 228);
            this.Tutorial_evaluate_1.Name = "Tutorial_evaluate_1";
            this.Tutorial_evaluate_1.Size = new System.Drawing.Size(646, 40);
            this.Tutorial_evaluate_1.TabIndex = 0;
            this.Tutorial_evaluate_1.Text = "好喝！唇齿留香 像是有海水打进了我的嘴里！";
            this.Tutorial_evaluate_1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Tutorial_evaluate_1.Click += new System.EventHandler(this.Tutorial_evaluate_1_Click);
            // 
            // image_owl_Tutorial
            // 
            this.image_owl_Tutorial.Image = global::wo_s_kitchen_Game.Properties.Resources.owl_small;
            this.image_owl_Tutorial.Location = new System.Drawing.Point(393, 51);
            this.image_owl_Tutorial.Name = "image_owl_Tutorial";
            this.image_owl_Tutorial.Size = new System.Drawing.Size(127, 138);
            this.image_owl_Tutorial.TabIndex = 0;
            this.image_owl_Tutorial.TabStop = false;
            // 
            // Tutorial_Evakuate_back_1
            // 
            this.Tutorial_Evakuate_back_1.BackColor = System.Drawing.Color.Transparent;
            this.Tutorial_Evakuate_back_1.FlatAppearance.BorderSize = 0;
            this.Tutorial_Evakuate_back_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tutorial_Evakuate_back_1.Location = new System.Drawing.Point(359, 383);
            this.Tutorial_Evakuate_back_1.Name = "Tutorial_Evakuate_back_1";
            this.Tutorial_Evakuate_back_1.Size = new System.Drawing.Size(215, 72);
            this.Tutorial_Evakuate_back_1.TabIndex = 2;
            this.Tutorial_Evakuate_back_1.Text = "返回";
            this.Tutorial_Evakuate_back_1.UseVisualStyleBackColor = false;
            this.Tutorial_Evakuate_back_1.Click += new System.EventHandler(this.Tutrial_evaluate_back_1_Click);
            // 
            // Tutoral_Evaluate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 599);
            this.Controls.Add(this.Tutorial_Evakuate_back_1);
            this.Controls.Add(this.image_owl_Tutorial);
            this.Controls.Add(this.Tutorial_evaluate_1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tutoral_Evaluate";
            this.Text = "顾客评价";
            ((System.ComponentModel.ISupportInitialize)(this.image_owl_Tutorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tutorial_evaluate_1;
        private System.Windows.Forms.PictureBox image_owl_Tutorial;
        private assets.RoundButton.RoundButton Tutorial_Evakuate_back_1;
    }
}