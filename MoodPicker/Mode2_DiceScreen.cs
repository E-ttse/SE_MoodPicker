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
    public partial class Mode2_DiceScreen: UserControl
    {
        public event Action Switch_to_MainPage;
        public event Action Switch_to_ChooseRandom;

        private string _listName; // Variable to store the list name / 用於儲存列表名稱的變數
        private List<string> _items; // List of items / 項目列表
        private Random rng = new Random(); // Random number generator / 隨機數生成器
        public Mode2_DiceScreen()
        {
            InitializeComponent();

            lblDice.Text = "-"; // Initial text for dice label / 骰子標籤的初始文字
            lblTotal.Text = "Total: -"; // Initial text for total label / 總數標籤的初始文字
            btnRoll.Text = "Roll / 擲骰子";
            lblInfo.Text = "請擲骰子來決定";
        }

        public void SetData(string selectedList, List<string> selectedItems)
        {
            this._listName = selectedList;
            this._items = selectedItems;
            btnRoll.Enabled = true;
            lblDice.Text = "-"; // Initial text for dice label / 骰子標籤的初始文字
            lblTotal.Text = "Total: -"; // Initial text for total label / 總數標籤的初始文字
            btnRoll.Text = "Roll / 擲骰子";
            lblInfo.Text = "請擲骰子來決定";
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            int dice = rng.Next(1, 7);     // dice 1-6 / / 骰子 1-6
            lblDice.Text = dice.ToString(); // Display the dice result / 顯示骰子結果
            lblTotal.Text = "Total: " + dice; // Display the total / 顯示總數

            // Select item according to dice index  / 根據骰子索引選擇項目
            int index = dice - 1; // Convert dice roll (1-6) to zero-based index (0-5) / 將骰子點數 (1-6) 轉換為從零開始的索引 (0-5)
            if (index < _items.Count) // Check if the index is within the bounds of the list / 檢查索引是否在列表範圍內
            {
                string chosen = _items[index]; // Get the chosen item / 獲取選中的項目

                lblInfo.Text = $"您的選擇是：\n【{chosen}】";
                btnRoll.Enabled = false;

                // Go directly to Mode2_Result / 直接轉到 Mode2_Result
                /*Mode2_Result resultPage =
                    new Mode2_Result(_listName, "骰子", chosen); // Create result page instance / 創建結果頁面實例

                var parent = this.Parent; // Get the parent container / 獲取父容器
                resultPage.Dock = DockStyle.Fill; // Dock the result page to fill the parent / 將結果頁面停靠以填充父容器
                parent.Controls.Clear(); // Clear current controls / 清除當前控件
                parent.Controls.Add(resultPage); // Add the result page / 添加結果頁面
                resultPage.BringToFront(); // Bring the result page to the front / 將結果頁面帶到最前面*/
            }
            else
            {
                // Show message if not enough items / 如果項目不足，顯示訊息
                MessageBox.Show("清單項目不足以對應骰子結果！");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Switch_to_MainPage?.Invoke();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Switch_to_ChooseRandom?.Invoke();
        }
    }
}
