using System;
using System.Windows.Forms;
using wo_s_kitchen_Game.data.wo_s_kitchen.windows;
namespace wo_s_kitchen_Game
{
    public partial class Home : Form
    {
        // 声明 GameWindow 窗体的实例
        private WhatTutorialNo_ch tutorialWindow;
        // 声明 SettingsWindow 窗体的实例
        private SettingsWindow settingsWindow;

        public Home()
        {
            InitializeComponent();
            tutorialWindow = new WhatTutorialNo_ch(); // 在构造函数中初始化 GameWindow
        }

        private void GameName_Click(object sender, EventArgs e) // 事件处理函数
        {
            MessageBox.Show("Welcome to wo's Kitchen Game!"); // 弹出消息框
        }

        private void ExitGame(object sender, EventArgs e)
        {
            Application.Exit(); // 退出应用程序
        }

        private void StartGame(object sender, EventArgs e)
        {
            this.Hide(); // 隐藏当前窗体（Home）
            tutorialWindow.Show(); // 显示 GameWindow
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
        private void OpenSettings(object sender, EventArgs e)
        {
            settingsWindow = new SettingsWindow(); // 在构造函数中初始化 SettingsWindow
            settingsWindow.Show(); // 显示 SettingsWindow
        }
    }
}