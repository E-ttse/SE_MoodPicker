using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoodPicker
{
    public partial class Mode2_SpinWheelScreen: UserControl
    {
        public event Action Switch_to_MainPage;
        public event Action Switch_to_ChooseRandom;

        private string _listName; // Variable to store the list name / 用於儲存列表名稱的變數
        private List<string> _items; // List of items for the wheel / 轉盤上的項目列表
        public Mode2_SpinWheelScreen()
        {
            InitializeComponent();
            //lblInfo.Text = "請轉輪盤來決定";

            // Subscribe to the SpinCompleted event / 訂閱 SpinCompleted 事件
            spinWheelControl1.SpinCompleted += WheelControl1_SpinCompleted;
        }

        public void SetData(string selectedList, List<string> selectedItems)
        {
            this._listName = selectedList;
            this._items = selectedItems;

            lblInfo.Text = "請轉輪盤來決定";
            lblTitle.Text = $"清單：{_listName}"; // Set the title label / 設置標題標籤
            spinWheelControl1.SetItems(_items); // Set the items on the wheel control / 設置轉盤控件上的項目
        }

        // Event handler for when the spin is completed / 旋轉完成時的事件處理程序
        private void WheelControl1_SpinCompleted(object sender, SpinCompletedEventArgs e)
        {
            btnSpin.Enabled = true; // Re-enable the spin button / 重新啟用旋轉按鈕

            string chosenItem = e.Item; // Get the chosen item from the event arguments / 從事件參數中獲取選中的項目
            lblInfo.Text = $"您的選擇是：\n【{chosenItem}】";
            // Move to result / 移至結果頁面
            /*Mode2_Result resultPage = new Mode2_Result(_listName, "轉盤", chosenItem); // Create result page instance / 創建結果頁面實例
            var parent = this.Parent; // Get the parent container / 獲取父容器
            resultPage.Dock = DockStyle.Fill; // Dock the result page to fill the parent / 將結果頁面停靠以填充父容器
            parent.Controls.Clear(); // Clear current controls / 清除當前控件
            parent.Controls.Add(resultPage); // Add the result page / 添加結果頁面 
            resultPage.BringToFront(); // Bring the result page to the front / 將結果頁面帶到最前面*/
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Switch_to_MainPage?.Invoke();
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            btnSpin.Enabled = false; // Disable the spin button during spin / 旋轉期間禁用旋轉按鈕
            spinWheelControl1.StartSpin(); // Start the wheel spin animation / 開始轉盤旋轉動畫
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Switch_to_ChooseRandom?.Invoke();
        }
    }
}
