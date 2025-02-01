namespace wo_s_kitchen_Game.data.wo_s_kitchen.windows
{
    partial class SettingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.TotalVolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.COTSEVBTrackBar = new System.Windows.Forms.TrackBar();
            this.MVTrackBar = new System.Windows.Forms.TrackBar();
            this.TotalVolume = new System.Windows.Forms.Label();
            this.COTSEVB = new System.Windows.Forms.Label();
            this.MV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TotalVolumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COTSEVBTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MVTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalVolumeTrackBar
            // 
            this.TotalVolumeTrackBar.Location = new System.Drawing.Point(352, 72);
            this.TotalVolumeTrackBar.Maximum = 100;
            this.TotalVolumeTrackBar.Name = "TotalVolumeTrackBar";
            this.TotalVolumeTrackBar.Size = new System.Drawing.Size(437, 45);
            this.TotalVolumeTrackBar.TabIndex = 0;
            this.TotalVolumeTrackBar.Value = 100;
            this.TotalVolumeTrackBar.DragDrop += new System.Windows.Forms.DragEventHandler(this.TotalVolumeTrackBar_DragDrop);
            // 
            // COTSEVBTrackBar
            // 
            this.COTSEVBTrackBar.Location = new System.Drawing.Point(352, 188);
            this.COTSEVBTrackBar.Maximum = 100;
            this.COTSEVBTrackBar.Name = "COTSEVBTrackBar";
            this.COTSEVBTrackBar.Size = new System.Drawing.Size(437, 45);
            this.COTSEVBTrackBar.TabIndex = 1;
            this.COTSEVBTrackBar.Value = 100;
            this.COTSEVBTrackBar.DragDrop += new System.Windows.Forms.DragEventHandler(this.COTSEVBTrackBar_DragDrop);
            // 
            // MVTrackBar
            // 
            this.MVTrackBar.Location = new System.Drawing.Point(352, 332);
            this.MVTrackBar.Maximum = 100;
            this.MVTrackBar.Name = "MVTrackBar";
            this.MVTrackBar.Size = new System.Drawing.Size(437, 45);
            this.MVTrackBar.TabIndex = 2;
            this.MVTrackBar.Value = 100;
            this.MVTrackBar.DragDrop += new System.Windows.Forms.DragEventHandler(this.MVTrackBar_DragDrop);
            // 
            // TotalVolume
            // 
            this.TotalVolume.AutoSize = true;
            this.TotalVolume.Font = new System.Drawing.Font("微软雅黑", 19F);
            this.TotalVolume.Location = new System.Drawing.Point(128, 72);
            this.TotalVolume.Name = "TotalVolume";
            this.TotalVolume.Size = new System.Drawing.Size(119, 35);
            this.TotalVolume.TabIndex = 3;
            this.TotalVolume.Text = "总音量：";
            // 
            // COTSEVB
            // 
            this.COTSEVB.AutoSize = true;
            this.COTSEVB.Font = new System.Drawing.Font("微软雅黑", 19F);
            this.COTSEVB.Location = new System.Drawing.Point(61, 188);
            this.COTSEVB.Name = "COTSEVB";
            this.COTSEVB.Size = new System.Drawing.Size(249, 35);
            this.COTSEVB.TabIndex = 4;
            this.COTSEVB.Text = "按钮点击音效音量：";
            this.COTSEVB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MV
            // 
            this.MV.AutoSize = true;
            this.MV.Font = new System.Drawing.Font("微软雅黑", 19F);
            this.MV.Location = new System.Drawing.Point(115, 332);
            this.MV.Name = "MV";
            this.MV.Size = new System.Drawing.Size(145, 35);
            this.MV.TabIndex = 5;
            this.MV.Text = "音乐音量：";
            this.MV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 490);
            this.Controls.Add(this.MV);
            this.Controls.Add(this.COTSEVB);
            this.Controls.Add(this.TotalVolume);
            this.Controls.Add(this.MVTrackBar);
            this.Controls.Add(this.COTSEVBTrackBar);
            this.Controls.Add(this.TotalVolumeTrackBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsWindow";
            this.Text = "设置";
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TotalVolumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COTSEVBTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MVTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar TotalVolumeTrackBar;
        private System.Windows.Forms.TrackBar COTSEVBTrackBar;
        private System.Windows.Forms.TrackBar MVTrackBar;
        private System.Windows.Forms.Label TotalVolume;
        private System.Windows.Forms.Label COTSEVB;
        private System.Windows.Forms.Label MV;
    }
}