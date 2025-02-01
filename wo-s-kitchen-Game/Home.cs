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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace wo_s_kitchen_Game
{
    public partial class Home : Form
    {
        string GameDirectory = Directory.GetCurrentDirectory();
        // 声明 GameWindow 窗体的实例
        private WhatTutorialNo_ch tutorialWindow;
        // 声明 SettingsWindow 窗体的实例
        private SettingsWindow settingsWindow;
        private IWavePlayer waveOut;
        private VorbisWaveReader vorbisReader;
        bool mim_stop = false; // 标记是否停止播放

        public Home()
        {
            BtnPlay_Click(); // 调用播放函数
            InitializeComponent(); // 初始化组件
            this.MaximizeBox = false;
        }
        private void PlayOgg(string filePath) // 定义播放 OGG 音频的函数
        {
            try
            {
                waveOut = new WaveOutEvent();
                vorbisReader = new VorbisWaveReader(filePath);
                waveOut.Init(vorbisReader);

                // 注册播放停止事件
                waveOut.PlaybackStopped += OnPlaybackStopped;
                waveOut.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("播放错误: " + ex.Message);
            }
        }

           
        private void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {
            // 重置音频文件并重新播放
            if (vorbisReader != null)
            {
                if (mim_stop == true)
                {
                    waveOut.Stop();
                    waveOut.Dispose();
                }
                else
                {
                    vorbisReader.Position = 0;
                    waveOut.Init(vorbisReader);
                    waveOut.Play();
                }

            }
        }
        private void OnPlaybackStopped(object sender, EventArgs e)
        {
            // 资源清理
            waveOut.Dispose();
            vorbisReader.Dispose();
        }

        private void BtnPlay_Click()
        {
            // 替换为实际 OGG 文件路径
            PlayOgg($@"{GameDirectory}\data\assets\Characters\Audios\8ntn78bubp8ua585m3mwy848yxdz5kkxtm6hcvvs.ogg");
        }

        private void BtnStop_Click()
        {
                Stop(); // 停止音乐的逻辑
        }

        private void Stop()
        {
            if (waveOut!= null)
            {
                waveOut.Stop(); // 停止播放
                mim_stop = true; // 标记停止播放
            }
        }
        private void NoGame(object sender, FormClosedEventArgs e)
        {
            try
            {
                BtnStop_Click();
            }

            catch (Exception)
            {
                // 忽略错误
            }
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
            this.Hide(); // 隐藏 Home 窗体
            Stop(); // 停止音乐的逻辑
            tutorialWindow = new WhatTutorialNo_ch(); // 在构造函数中初始化 GameWindow
            tutorialWindow.Show(); // 显示 GameWindow
        }
        private void OpenSettings(object sender, EventArgs e)
        {
            settingsWindow = new SettingsWindow(); // 在构造函数中初始化 SettingsWindow
            settingsWindow.Show(); // 显示 SettingsWindow
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}