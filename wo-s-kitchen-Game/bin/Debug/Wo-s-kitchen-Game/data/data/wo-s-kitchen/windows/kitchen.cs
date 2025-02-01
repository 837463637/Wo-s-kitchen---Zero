using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;
using NAudio.Wave;
using NAudio.Vorbis;
using wo_s_kitchen_Game.data.wo_s_kitchen.windows;
using NVorbis;
using System.Windows.Controls;

namespace wo_s_kitchen_Game.data.wo_s_kitchen.windows
{
    public partial class Tutorial_kitchen_1 : Form
    {
        private Tutoral_Evaluate Tutoral_Evaluate;
        public Tutorial_kitchen_1()
        {
            InitializeComponent();
            this.MaximizeBox = false; // 禁止最大化
        }

        private async void grape_nine_make_button_Click(object sender, EventArgs e)
        {
            int Tutorial_Grape_nine_make_Value = 0;
            Tutorial_kitchen_make_1.Visible = false;
            Tutorial_kitchen_make_1.Enabled = false;
            Tutorial_Grape_nine_make.Location = new System.Drawing.Point(357, 255);
            // 在循环中更新值到 100 为止
            while (Tutorial_Grape_nine_make_Value < 100)
            {
                Tutorial_Grape_nine_make_Value++; // 增加值
                Tutorial_Grape_nine_make.Value = Tutorial_Grape_nine_make_Value; // 假定这是一个进度条或类似控件
                await Task.Delay(200); // 等待 200 毫秒
                this.Invalidate(); // 刷新界面
            }

            MessageBox.Show("制作成功！");
            this.Close();
            Tutoral_Evaluate = new Tutoral_Evaluate();
            Tutoral_Evaluate.Show();
        }
    }
}
