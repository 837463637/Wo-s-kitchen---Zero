using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wo_s_kitchen_Game.data.wo_s_kitchen.windows;

namespace wo_s_kitchen_Game
{
    public partial class WhatTutorialNo_ch : Form
    {
        private Tutorial_CMD tutorialCMD;
        public WhatTutorialNo_ch()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WhatTutorialYes_ch_Click(object sender, EventArgs e)
        {
            owl_Tutorial_what_1.Visible = false;
            WhatTutorialEnglish.Visible = false;
            WhatTutorial.Visible = false;
            WhatTutorialYes_ch.Visible = false;
            WhatTutorialYes_en.Visible = false;
            WhatTutorialNo_en.Visible = false;
            Tutorial_label_1.Visible = true;
            Tutorial_label_2.Visible = true;
            Tutorial_label_3.Visible = true;
            WhatTutorialNot.Visible = false;
            Tutorial_button_1.Visible = true;
        }

        private void WhatTutorialYes_en_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Tutorial_label_1_Click(object sender, EventArgs e)
        {

        }

        private void WhatTutorial_Click(object sender, EventArgs e)
        {

        }

        private void Tutorial_label_3_Click(object sender, EventArgs e)
        {

        }

        private void Tutorial_label_2_Click(object sender, EventArgs e)
        {

        }
        private void Open_Tutorail_CMD_Button_Click(object sender, EventArgs e)
        {
            tutorialCMD = new Tutorial_CMD();
            tutorialCMD.Show();
            this.Hide();
        }
    }
}
