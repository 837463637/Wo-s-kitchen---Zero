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
            string GameDirectory = Directory.GetCurrentDirectory();
            InitializeComponent();
            JObject SettingsConfig = JObject.Parse(File.ReadAllText($@"{GameDirectory}\data\assets\Settings\SettingsConfig.json"));
            TotalVolumeTrackBar.Value = SettingsConfig.Value<int>("TotalVolume");
            MVTrackBar.Value = SettingsConfig.Value<int>("MusicVolume");
            COTSEVBTrackBar.Value = SettingsConfig.Value<int>("COTSEVB");
            this.MaximizeBox = false; // 禁止最大化
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {

        }

        private void TotalVolumeTrackBar_DragDrop(object sender, DragEventArgs e)
        {
            string GameDirectory = Directory.GetCurrentDirectory();
            string settingsFilePath = $@"{GameDirectory}\data\assets\Settings\SettingsConfig.json";

            // 读取配置文件
            JObject SettingsConfig = JObject.Parse(File.ReadAllText(settingsFilePath));

            // 修改总音量的值
            SettingsConfig["TotalVolume"] = TotalVolumeTrackBar.Value;

            // 将修改后的配置写回到文件中
            File.WriteAllText(settingsFilePath, SettingsConfig.ToString());
        }

        private void COTSEVBTrackBar_DragDrop(object sender, DragEventArgs e)
        {
            string GameDirectory = Directory.GetCurrentDirectory();
            string settingsFilePath = $@"{GameDirectory}\data\assets\Settings\SettingsConfig.json";

            // 读取配置文件
            JObject SettingsConfig = JObject.Parse(File.ReadAllText(settingsFilePath));

            // 修改总音量的值
            SettingsConfig["COTSEVB"] = COTSEVBTrackBar.Value;

            // 将修改后的配置写回到文件中
            File.WriteAllText(settingsFilePath, SettingsConfig.ToString());
        }

        private void MVTrackBar_DragDrop(object sender, DragEventArgs e)
        {
            string GameDirectory = Directory.GetCurrentDirectory();
            string settingsFilePath = $@"{GameDirectory}\data\assets\Settings\SettingsConfig.json";

            // 读取配置文件
            JObject SettingsConfig = JObject.Parse(File.ReadAllText(settingsFilePath));

            // 修改总音量的值
            SettingsConfig["MusicVolume"] = MVTrackBar.Value;

            // 将修改后的配置写回到文件中
            File.WriteAllText(settingsFilePath, SettingsConfig.ToString());
        }
    }
}
