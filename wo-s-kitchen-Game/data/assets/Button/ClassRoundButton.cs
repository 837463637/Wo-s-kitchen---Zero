using System;
using System.Drawing;
using NAudio.Wave;
using NAudio.Vorbis;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using NVorbis;
using System.IO;
using wo_s_kitchen_Game.data.wo_s_kitchen.windows;
namespace wo_s_kitchen_Game.data.assets.RoundButton
{
    public class RoundButton : Button
    {

        private wo_s_kitchen_Game.data.wo_s_kitchen.windows.SettingsWindow.ControlCollection COTSEVBTrackBar;
        private Color _defaultColor;
        private Color _hoverColor;
        private bool _isHover;
        private Size _originalSize; // 存储原始大小，将在OnSizeChanged中更新
        private const float _scaleDownFactor = 0.9f; // 缩小比例
        private IWavePlayer waveOut;
        private VorbisWaveReader vorbisReader;
        string GameDirectory = Directory.GetCurrentDirectory();
        public RoundButton()
        {
            this.FlatStyle = FlatStyle.Flat; // 按钮为扁平化样式
            this.FlatAppearance.BorderSize = 0; // 不显示默认边框
            this.BackColor = Color.Transparent; // 背景透明

            _defaultColor = Color.Transparent; // 默认背景颜色设为透明
            _hoverColor = Color.FromArgb(30, 0, 0, 188); // 悬停时背景颜色设为较深的蓝色
            _isHover = false; // 初始状态

            // 初始化时设置原始大小为当前大小（如果此时已有大小）
            _originalSize = this.Size;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            // 更新原始大小为当前大小
            _originalSize = this.Size;
            base.OnSizeChanged(e);
        }
        private void PlayOgg(string filePath) // 定义播放 OGG 音频的函数
        {
            try
            {
                waveOut = new WaveOutEvent();
                vorbisReader = new VorbisWaveReader(filePath);
                waveOut.Init(vorbisReader);

                // 注册播放停止事件
                waveOut.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("播放错误: " + ex.Message);
            }
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            _isHover = true;
            Invalidate(); // 重新绘制按钮
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            _isHover = false;
            Invalidate(); // 重新绘制按钮
            base.OnMouseLeave(e);
        }

        private Size _pressedSize; // 新增变量以存储按下状态的原始大小

        protected override void OnMouseDown(MouseEventArgs mevent) // 新增方法以处理鼠标按下事件
        {
            // 保存按下时的原始大小
            _pressedSize = this.Size;
            
           if (mevent.Button == MouseButtons.Left)
           {
                
                // 左键按下时，按钮颜色变为绿色 播放音效
                PlayOgg($@"{GameDirectory}\data\assets\Characters\Audios\r7uyrutvjd7yn2x8u2avmb55vewfmd4tb2jh63n5.ogg"); // 播放按钮音效
                _defaultColor = Color.Transparent; // 默认背景颜色设为透明
                _hoverColor = Color.FromArgb(30, 0, 255, 0); // 悬停时背景颜色设为较深的蓝色
            }
           else if (mevent.Button == MouseButtons.Right)
           {
                // 右键按下时，按钮颜色变为红色 不播放音效
                _defaultColor = Color.Transparent; // 默认背景颜色设为透明
                _hoverColor = Color.FromArgb(30, 255, 0, 0); // 悬停时背景颜色设为较深的红色
            }
            // 将背景颜色设置为绿色


            Invalidate(); // 重新绘制按钮
            base.OnMouseDown(mevent); // 调用基类方法
        }

        protected override void OnMouseUp(MouseEventArgs mevent) // 新增方法以处理鼠标松开事件
        {
            // 还原默认背景颜色
            BackColor = Color.Transparent; // 或者定义其他默认颜色
            _hoverColor = Color.FromArgb(30, 0, 0, 188); // 悬停时背景颜色设为较深的蓝色
            this.Size = _pressedSize; // 可选：还原大小
            Invalidate(); // 重新绘制按钮
            base.OnMouseUp(mevent);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            OnPaintBackground(pevent);

            int borderWidth = 2; // 边框宽度
            int roundedRadius = 20; // 圆角半径

            // 设置平滑模式
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias; //抗锯齿

            // 创建圆角路径
            GraphicsPath path = new GraphicsPath(); 
            path.AddArc(borderWidth, borderWidth, roundedRadius, roundedRadius, 180, 90); //顺时针绘制
            path.AddArc(Width - roundedRadius - borderWidth, borderWidth, roundedRadius, roundedRadius, 270, 90); //顺时针绘制
            path.AddArc(Width - roundedRadius - borderWidth, Height - roundedRadius - borderWidth, roundedRadius, roundedRadius, 0, 90); //顺时针绘制
            path.AddArc(borderWidth, Height - roundedRadius - borderWidth, roundedRadius, roundedRadius, 90, 90); //顺时针绘制
            path.CloseFigure(); // 闭合路径

            // 绘制背景（根据是否悬停来选择颜色）
            Color backgroundColor = _isHover ? _hoverColor : _defaultColor;

            using (Brush brush = new SolidBrush(backgroundColor))
            {
                pevent.Graphics.FillPath(brush, path);
            }

            // 绘制边框
            using (Pen pen = new Pen(Color.Blue, borderWidth))
            {
                pevent.Graphics.DrawPath(pen, path);
            }

            // 文字绘制
            using (Brush brush = new SolidBrush(ForeColor))
            {
                using (StringFormat stringFormat = new StringFormat())
                {
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;
                    pevent.Graphics.DrawString(Text, Font, brush, new Rectangle(borderWidth, borderWidth, Width - 2 * borderWidth, Height - 2 * borderWidth), stringFormat);
                }
            }
        }
    }
}
