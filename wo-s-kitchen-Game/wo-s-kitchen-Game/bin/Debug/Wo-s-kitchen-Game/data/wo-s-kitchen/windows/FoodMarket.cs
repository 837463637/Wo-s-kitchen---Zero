using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wo_s_kitchen_Game.data.wo_s_kitchen.windows
{
    public partial class Tutorial_FoodMarket : Form
    {
        private Tutorial_kitchen_1 tutorial_kitchen;
        public Tutorial_FoodMarket()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void buy_grape_Click(object sender, EventArgs e)
        {
            MessageBox.Show("成功购买9个葡萄！");
            this.Hide();
            tutorial_kitchen = new Tutorial_kitchen_1();
            tutorial_kitchen.Show();
        }
    }
}
