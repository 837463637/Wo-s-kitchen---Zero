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
    public partial class Tutoral_Evaluate : Form
    {
        private Home Home;
        public Tutoral_Evaluate()
        {
            InitializeComponent();
            this.MaximizeBox = false; // 禁止最大化
        }

        private void Tutorial_evaluate_1_Click(object sender, EventArgs e)
        {

        }
        private void Tutrial_evaluate_back_1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home = new Home();
            Home.Show();
        }
    }
}
