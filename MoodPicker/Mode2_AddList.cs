using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MoodPicker
{
    public partial class Mode2_AddList: UserControl
    {
        public event Action<string, List<string>> Switch_to_ChooseRandom;
        public event Action Switch_to_MainPage;

        public Mode2_AddList()
        {
            InitializeComponent();
            string filePath = "D:\\下載(C)\\SE_MoodPicker-Mode1_waterfall\\MoodPicker\\list.txt";
            LoadTreeViewFromTextFile(filePath);

            // 顯示調整
            treeView1.DrawMode = TreeViewDrawMode.OwnerDrawText;
            treeView1.DrawNode += treeView1_DrawNode;
            treeView1.ItemHeight = 28;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Switch_to_MainPage?.Invoke();
        }

        private void Mode2_AddList_Load(object sender, EventArgs e)
        {
            string filePath = "D:\\下載(C)\\SE_MoodPicker-Mode1_waterfall\\MoodPicker\\list.txt";
            LoadTreeViewFromTextFile(filePath);

            // AfterSelect 事件綁定 (+=)
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void LoadTreeViewFromTextFile(string filePath)
        {
            treeView1.Nodes.Clear();

            try
            {
                // 一次性讀取所有行
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string trimmedLine = line.Trim();

                    // 忽略空白行
                    if (string.IsNullOrWhiteSpace(trimmedLine))
                    {
                        continue;
                    }

                    char[] delimiters = new char[] { ' ' };

                    string[] parts = trimmedLine.Split(
                        delimiters,
                        StringSplitOptions.RemoveEmptyEntries // 忽略因多個連續空白產生的空字串
                    );

                    // 確保至少有一個項目 (種類)
                    if (parts.Length < 1)
                    {
                        continue;
                    }

                    // 第0項是種類
                    string parentText = parts[0];
                    TreeNode parentNode = new TreeNode(parentText);
                    treeView1.Nodes.Add(parentNode);

                    // 處理剩餘的項目 (選項1, 選項2, ...)
                    for (int i = 1; i < parts.Length; i++)
                    {
                        string childText = parts[i];
                        parentNode.Nodes.Add(new TreeNode(childText));
                    }
                }

                // 展開所有節點
                //treeView1.ExpandAll();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show($"錯誤：找不到檔案 {filePath}", "檔案錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"讀取檔案時發生錯誤: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            bool isParent = (e.Node.Parent == null);

            // 字體
            Font nodeFont = isParent
                ? new Font("微軟正黑體", 10, FontStyle.Bold)
                : new Font("微軟正黑體", 9, FontStyle.Regular);

            Color textColor = isParent ? Color.DarkBlue : Color.Black;

            // 留白
            Rectangle nodeBounds = e.Bounds;
            nodeBounds.Width += 4; // 加寬

            // 文字
            TextRenderer.DrawText(
                e.Graphics,
                e.Node.Text,
                nodeFont,
                nodeBounds,
                textColor,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter
            );

            e.DrawDefault = false; // 關預設
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 是否有選中
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("請先選取一個類別！");
                return;
            }

            TreeNode selected = treeView1.SelectedNode;

            // 確保選到的是類別
            if (selected.Parent != null)
            {
                MessageBox.Show("請選取一個類別，而不是項目！");
                return;
            }
            // 收集子項

            List<string> items = new List<string>();
            foreach (TreeNode child in selected.Nodes)
            {
                items.Add(child.Text);
            }

            string selectedText = treeView1.SelectedNode.Text;
            Switch_to_ChooseRandom?.Invoke(selectedText, items);

            // 跳到Mode2_ChooseRandom 傳入資料
            /*Mode2_ChooseRandom nextPage = new Mode2_ChooseRandom(selected.Text, items);
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Controls.Clear();
                nextPage.Dock = DockStyle.Fill;
                parentForm.Controls.Add(nextPage);
            }*/
        }
    }
}
