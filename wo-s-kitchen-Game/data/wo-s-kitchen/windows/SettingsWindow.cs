using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace wo_s_kitchen_Game.data.wo_s_kitchen.windows
{
    public partial class SettingsWindow : Form
    {
        private string settingsFilePath;

        public SettingsWindow()
        {
            string GameDirectory = Directory.GetCurrentDirectory();
            InitializeComponent();
            settingsFilePath = $@"{GameDirectory}\data\assets\Settings\SettingsConfig.json";

        }
        private void COTSEVBTrackBar_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void MVTrackBar_DragDrop(object sender, DragEventArgs e)
        {

        }
    }
}
