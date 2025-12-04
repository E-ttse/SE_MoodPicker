using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MoodPicker
{
    public partial class Mode2_CoinScreen: UserControl
    {
        public event Action Switch_to_MainPage;
        public event Action Switch_to_ChooseRandom;

        private string _listName; // Variable to store the list name / 用於儲存列表名稱的變數
        private List<string> _items;   // Should be 2 items / 應該是 2 個項目
        private Random _rng = new Random(); // Random number generator / 隨機數生成器
        private int _flipCount = 0; // Counter for the number of flips / 擲硬幣次數的計數器
        public Mode2_CoinScreen()
        {
            InitializeComponent();

            lblCoinText.Text = "";                 // No result yet / 尚未有結果
            lblInfo.Text = "Result / 結果";
            btnFlip.Text = "Flip / 擲硬幣";         // Initial text / 初始文字
        }

        public void SetData(string selectedList, List<string> selectedItems)
        {
            this._listName = selectedList;
            this._items = selectedItems;

            lblInfo.Text = "Result / 結果";
            btnFlip.Text = "Flip / 擲硬幣";         // Initial text / 初始文字
        }

        // // round shape / 圓形
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (lblCoinText == null) return; // Exit if the label doesn't exist yet / 如果標籤尚不存在則退出

            // Create a circular region for the label / 為標籤創建一個圓形區域
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(lblCoinText.ClientRectangle);
            lblCoinText.Region = new Region(gp);
        }

        private void Mode2_CoinScreen_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Switch_to_MainPage?.Invoke();
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            // Check if there are at least 2 items/ 檢查是否至少有 2 個項目
            if (_items == null || _items.Count < 2)
            {
                MessageBox.Show("硬幣模式需要至少兩個項目喔！");
                return;
            }

            _flipCount++; // Increment flip counter / 增加擲硬幣計數

            // 0 or 1 -> choose one of the two items in the list / 0 或 1 → 選擇列表中的兩個項目之一
            int index = _rng.Next(0, 2);
            string chosen = _items[index];

            // DISPLAY THE LIST TEXT INSIDE THE "COIN" / 在「硬幣」內顯示列表文字
            lblCoinText.Text = chosen;
            lblInfo.Text = $"您的選擇是：\n【{chosen}】";

            // Change button text after the first flip / 第一次擲硬幣後更改按鈕文字
            if (_flipCount >= 1)
            {
                btnFlip.Text = "Flip Again / 再擲一次";
            }


            // Mode2_Result result = new Mode2_Result(_listName, "硬幣", chosen);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Switch_to_ChooseRandom?.Invoke();
        }
    }
}
