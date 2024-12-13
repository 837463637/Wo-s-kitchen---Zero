using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace wo_s_kitchen_Game.data.assets.RoundButton
{
    public class RoundButton : Button
    {
        private Color _defaultColor;
        private Color _hoverColor;
        private bool _isHover;
        private Size _originalSize; // 存储原始大小，将在OnSizeChanged中更新
        private const float _scaleDownFactor = 0.9f; // 缩小比例

        public RoundButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0; // 不显示默认边框
            this.BackColor = Color.Transparent; // 背景透明

            _defaultColor = Color.Transparent; // 默认背景颜色设为灰色
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

        private float _originalFontSize; // 存储原始字体大小


        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            // 保存按下时的原始大小
            _pressedSize = this.Size;
            base.OnMouseDown(mevent);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            // 还原大小
            this.Size = _pressedSize;
            Invalidate(); // 重新绘制按钮
            base.OnMouseUp(mevent);
        }


        protected override void OnPaint(PaintEventArgs pevent)
        {
            OnPaintBackground(pevent);

            int borderWidth = 2; // 边框宽度
            int roundedRadius = 20; // 圆角半径

            // 设置平滑模式
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // 创建圆角路径
            GraphicsPath path = new GraphicsPath();
            path.AddArc(borderWidth, borderWidth, roundedRadius, roundedRadius, 180, 90);
            path.AddArc(Width - roundedRadius - borderWidth, borderWidth, roundedRadius, roundedRadius, 270, 90);
            path.AddArc(Width - roundedRadius - borderWidth, Height - roundedRadius - borderWidth, roundedRadius, roundedRadius, 0, 90);
            path.AddArc(borderWidth, Height - roundedRadius - borderWidth, roundedRadius, roundedRadius, 90, 90);
            path.CloseFigure();

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
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                pevent.Graphics.DrawString(Text, Font, brush, new Rectangle(borderWidth, borderWidth, Width - 2 * borderWidth, Height - 2 * borderWidth), stringFormat);
            }
        }
    }
}
