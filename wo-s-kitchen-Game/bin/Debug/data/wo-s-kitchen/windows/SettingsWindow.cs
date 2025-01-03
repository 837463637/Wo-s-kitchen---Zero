using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace wo_s_kitchen_Game.data.wo_s_kitchen.windows
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
            this.MaximizeBox = false; // 禁止最大化
        }
    }
}
