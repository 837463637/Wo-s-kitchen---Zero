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
    public partial class Tutorial_FoodMarket : Form
    {
        private Tutorial_kitchen_1 tutorial_kitchen;
        public Tutorial_FoodMarket()
        {
            InitializeComponent();
            this.MaximizeBox = false; // 禁止最大化
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void buy_grape_Click(object sender, EventArgs e)
        {
            MessageBox.Show("购买葡萄x9！");
            this.Hide();
            tutorial_kitchen = new Tutorial_kitchen_1();
            tutorial_kitchen.Show();
        }
    }
}
