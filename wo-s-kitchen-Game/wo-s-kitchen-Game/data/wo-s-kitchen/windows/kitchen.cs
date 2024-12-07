using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wo_s_kitchen_Game.data.wo_s_kitchen.windows
{
    public partial class Tutorial_kitchen_1 : Form
    {
        private Tutoral_Evaluate Tutoral_Evaluate;
        public Tutorial_kitchen_1()
        {
            InitializeComponent();
        }

        private async void grape_nine_make_button_Click(object sender, EventArgs e)
        {
            int Tutorial_Grape_nine_make_Value = 0;

            // 在循环中更新值到 100 为止
            while (Tutorial_Grape_nine_make_Value < 100)
            {
                Tutorial_Grape_nine_make_Value++; // 增加值
                Tutorial_Grape_nine_make.Value = Tutorial_Grape_nine_make_Value; // 假定这是一个进度条或类似控件
                await Task.Delay(200); // 等待 200 毫秒
                this.Invalidate(); // 刷新界面
            }

            MessageBox.Show("制作成功！");
            this.Close();
            Tutoral_Evaluate = new Tutoral_Evaluate();
            Tutoral_Evaluate.Show();
        }
    }
}
