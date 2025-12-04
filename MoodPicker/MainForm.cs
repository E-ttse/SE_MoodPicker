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
        private Mode2_ChooseRandom mode2_choose_random;
        private Mode2_Result mode2_result;
        private Mode2_CoinScreen mode2_coin_screen;
        private Mode2_DiceScreen mode2_dice_screen;
        private Mode2_SpinWheelScreen mode2_spinwheel_screen;

        public MainForm()
        {
            InitializeComponent();
            //設定視窗起始位置
            this.StartPosition = FormStartPosition.CenterScreen;
            // this.WindowState = FormWindowState.Maximized;
            panel1.Dock = DockStyle.Fill;

            // 初始化各視窗
            start = new Start();
            mainpage = new MainPage();
            mode1_choose_mode = new Mode1_ChooseMode();
            mode1_each_mode = new Mode1_EachMode();
            mode2_add_list = new Mode2_AddList();
            mode2_choose_random = new Mode2_ChooseRandom();
            mode2_result = new Mode2_Result();
            mode2_coin_screen = new Mode2_CoinScreen();
            mode2_dice_screen = new Mode2_DiceScreen();
            mode2_spinwheel_screen = new Mode2_SpinWheelScreen();

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

            mode2_add_list.Switch_to_MainPage += () => ShowControl(mainpage);
            mode2_add_list.Switch_to_ChooseRandom += (categoryName, itemsList) =>
            {
                // 將資料傳給目標頁面
                mode2_choose_random.SetData(categoryName, itemsList);
                ShowControl(mode2_choose_random);
            };

            mode2_choose_random.Switch_to_AddList += () => ShowControl(mode2_add_list);
            mode2_choose_random.Switch_to_Result += () => ShowControl(mode2_result);
            mode2_choose_random.Switch_to_CoinScreen += (categoryName, itemsList) =>
            {
                mode2_coin_screen.SetData(categoryName, itemsList);
                ShowControl(mode2_coin_screen);
            };
            mode2_choose_random.Switch_to_DiceScreen += (categoryName, itemsList) =>
            {
                mode2_dice_screen.SetData(categoryName, itemsList);
                ShowControl(mode2_dice_screen);
            };
            mode2_choose_random.Switch_to_SpinWheelScreen += (categoryName, itemsList) =>
            {
                mode2_spinwheel_screen.SetData(categoryName, itemsList);
                ShowControl(mode2_spinwheel_screen);
            };

            mode2_result.Switch_to_MainPage += () => ShowControl(mainpage);
            mode2_coin_screen.Switch_to_MainPage += () => ShowControl(mainpage);
            mode2_coin_screen.Switch_to_ChooseRandom += () => ShowControl(mode2_choose_random);
            mode2_dice_screen.Switch_to_MainPage += () => ShowControl(mainpage);
            mode2_dice_screen.Switch_to_ChooseRandom += () => ShowControl(mode2_choose_random);
            mode2_spinwheel_screen.Switch_to_MainPage += () => ShowControl(mainpage);
            mode2_spinwheel_screen.Switch_to_ChooseRandom += () => ShowControl(mode2_choose_random);

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
