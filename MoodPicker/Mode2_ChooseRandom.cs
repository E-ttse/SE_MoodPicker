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
    public partial class Mode2_ChooseRandom: UserControl
    {
        public event Action Switch_to_Result;
        public event Action Switch_to_AddList;
        public event Action<string, List<string>> Switch_to_CoinScreen;
        public event Action<string, List<string>> Switch_to_DiceScreen;
        public event Action<string, List<string>> Switch_to_SpinWheelScreen;

        private string listName;             // The list that be selected
        private List<string> itemList;           // Items of the list

        // default
        public Mode2_ChooseRandom()
        {
            InitializeComponent();

            // drawing style
            treeView1.DrawMode = TreeViewDrawMode.OwnerDrawText;
            treeView1.DrawNode += treeView1_DrawNode;
            treeView1.ItemHeight = 28;
        }

        public void SetData(string selectedList, List<string> selectedItems)
        {
            this.listName = selectedList;
            this.itemList = selectedItems;

            // 接收到資料後，立即呼叫方法更新 UI 顯示
            DisplayListItems();
        }

        // displays the selected list and its items in the TreeView
        private void DisplayListItems()
        {
            treeView1.Nodes.Clear();

            TreeNode parentNode = new TreeNode(listName);
            treeView1.Nodes.Add(parentNode);

            foreach (var item in itemList)
            {
                parentNode.Nodes.Add(new TreeNode(item));
            }

            treeView1.ExpandAll();
        }

        // custom drawing
        private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            bool isParent = (e.Node.Parent == null);

            Font nodeFont = isParent
                ? new Font("微軟正黑體", 10, FontStyle.Bold)
                : new Font("微軟正黑體", 9, FontStyle.Regular);

            Color textColor = isParent ? Color.DarkBlue : Color.Black;

            Rectangle nodeBounds = e.Bounds;
            nodeBounds.Width += 4;

            TextRenderer.DrawText(
                e.Graphics,
                e.Node.Text,
                nodeFont,
                nodeBounds,
                textColor,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter
            );

            e.DrawDefault = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Switch_to_SpinWheelScreen?.Invoke(listName, itemList);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Switch_to_AddList?.Invoke();
        }

        private void Mode2_ChooseRandom_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Switch_to_DiceScreen?.Invoke(listName, itemList);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Switch_to_CoinScreen?.Invoke(listName, itemList);
        }

    }
}
