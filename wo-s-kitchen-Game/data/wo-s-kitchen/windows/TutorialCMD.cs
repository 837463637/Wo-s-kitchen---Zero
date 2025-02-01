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
    public partial class Tutorial_CMD : Form
    {
        private Tutorial_FoodMarket Tutorial_FoodMarket;
        public Tutorial_CMD()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // 窗口无边框
            this.MaximizeBox = false; // 禁止最大化
        }

        private void Tutorial_What_code_Click(object sender, EventArgs e)
        {

        }
        private void Tutorial_CMD_Buttton_OK_Click(object sender, EventArgs e)
        {
            string code = WhatCode_Fa.Text;
            if (code == "FoodMarket")
            {
                MessageBox.Show("指令输入成功！正在跳转到菜市场界面");
                Tutorial_FoodMarket = new Tutorial_FoodMarket();
                this.Close();
                Tutorial_FoodMarket.Show();
            }
            else
            {
                MessageBox.Show("请输入正确的指令！");
            }
        }
    }
}
