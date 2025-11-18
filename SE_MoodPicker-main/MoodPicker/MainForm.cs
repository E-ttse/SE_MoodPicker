using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoodPicker
{
    public partial class MainForm: Form
    {
        // 宣告各視窗
        private Start start;
        private MainPage mainpage;
        private Mode1_ChooseMode mode1_choose_mode;
        private Mode1_EachMode mode1_each_mode;
        private Mode2_AddList mode2_add_list;

        public MainForm()
        {
            InitializeComponent();
            //設定視窗起始位置
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            panel1.Dock = DockStyle.Fill;

            // 初始化各視窗
            start = new Start();
            mainpage = new MainPage();
            mode1_choose_mode = new Mode1_ChooseMode();
            mode1_each_mode = new Mode1_EachMode();
            mode2_add_list = new Mode2_AddList();

            // 監測各頁面的invoke，觸發後切換頁面
            start.Switch_to_MainPage += () => ShowControl(mainpage);

            mainpage.Switch_to_Mode1 += () => ShowControl(mode1_choose_mode);
            mainpage.Switch_to_Mode2 += () => ShowControl(mode2_add_list);

            mode1_choose_mode.Switch_to_MainPage += () => ShowControl(mainpage);
            mode1_choose_mode.Switch_to_EachMood += (moodId) =>
            {
                // 傳 moodId 給下一個畫面
                mode1_each_mode.SetMood(moodId);
                ShowControl(mode1_each_mode);
            };

            mode1_each_mode.Switch_to_MainPage += () => ShowControl(mainpage);

            // 顯示初始視窗 - Start
            ShowControl(start);
        }

        //顯示視窗
        private void ShowControl(UserControl UC)
        {
            panel1.Controls.Clear();
            UC.Dock = DockStyle.Fill;
            panel1.Controls.Add(UC);
        }

    }
}
