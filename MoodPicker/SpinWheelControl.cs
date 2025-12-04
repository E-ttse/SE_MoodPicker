using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace MoodPicker
{
    public partial class SpinWheelControl: UserControl
    {
        private List<string> _items = new List<string>(); // List of items on the wheel / 轉盤上的項目列表
        private float _angle = 0f;           // current rotation angle / 當前旋轉角度
        private float _targetAngle = 0f;     // final target angle / 最終目標角度
        private float _speed = 0f;           // rotation speed / 旋轉速度
        private int _targetIndex = -1;       // index of the item that will be the result / 將成為結果的項目索引
        private Timer _timer; // Timer for animation / 用於動畫的計時器
        private Random _rng = new Random(); // Random number generator / 隨機數生成器

        // Event triggered when the spin is completed / 旋轉完成時觸發的事件
        public event EventHandler<SpinCompletedEventArgs> SpinCompleted;

        public SpinWheelControl()
        {
            InitializeComponent();

            DoubleBuffered = true; // Enable double buffering for smoother graphics / 啟用雙緩衝以獲得更流暢的圖形

            _timer = new Timer();
            _timer.Interval = 20;
            _timer.Tick += Timer_Tick; // Assign the Tick event handler / 分配 Tick 事件處理程序
        }

        // Sets the items to be displayed on the wheel / 設置要顯示在轉盤上的項目
        public void SetItems(List<string> items)
        {
            _items = items ?? new List<string>();
            _angle = 0; // Reset angle / 重置角度
            Invalidate(); // Redraw the control / 重繪控制項
        }

        // Starts the spinning animation / 開始旋轉動畫
        public void StartSpin()
        {
            if (_items == null || _items.Count == 0) return; // Do nothing if there are no items / 如果沒有項目則不執行任何操作

            // Select result index / 選擇結果索引
            _targetIndex = _rng.Next(_items.Count);

            float sweep = 360f / _items.Count; // Angle for each item slice / 每個項目扇形的角度
            float pointerAngle = -90f; // Arrow is at the top (pointing down) / 箭頭在頂部（指向下方）
            float center = (_targetIndex + 0.5f) * sweep; // Center angle of the target slice / 目標扇形的中心角度

            // We want several spins (e.g., 5x) / 我們想要轉幾圈（例如 5 圈）
            int spins = 5;
            // Calculate the final angle / 計算最終角度
            _targetAngle = pointerAngle - center + 360f * spins;

            _speed = 25f;   // Start fast / 開始時速度快
            _angle = 0f; // Reset current angle / 重置當前角度
            _timer.Start(); // Start the animation timer / 啟動動畫計時器
        }

        // Called every timer interval to update the animation / 每個計時器間隔調用以更新動畫
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Check if the target angle has been reached / 檢查是否已達到目標角度
            if (_angle >= _targetAngle)
            {
                _angle = _targetAngle; // Snap to the final angle / 鎖定到最終角度
                _timer.Stop(); // Stop the timer / 停止計時器

                // Trigger the SpinCompleted event / 觸發 SpinCompleted 事件
                if (_targetIndex >= 0 && _targetIndex < _items.Count)
                {
                    SpinCompleted?.Invoke(this,
                        new SpinCompletedEventArgs(_targetIndex, _items[_targetIndex]));
                }
                return;
            }

            // Slow down gradually / 逐漸減速
            float remaining = _targetAngle - _angle; // Calculate remaining angle / 計算剩餘角度
            if (remaining < 720 && _speed > 5f) // Start slowing down in the last 2 spins / 在最後兩圈開始減速
            {
                _speed *= 0.97f; // decelerate / 減速
            }

            _angle += _speed; // Update the angle / 更新角度
            Invalidate(); // Request a redraw / 請求重繪
        }

        // Handles the painting of the control / 處理控制項的繪製
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (_items == null || _items.Count == 0) return; // Don't paint if no items / 如果沒有項目則不繪製

            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // Enable anti-aliasing / 啟用抗鋸齒

            // Calculate drawing rectangle / 計算繪圖矩形
            int size = Math.Min(Width, Height) - 20;
            Rectangle rect = new Rectangle(
                (Width - size) / 2,
                (Height - size) / 2,
                size,
                size);

            float sweep = 360f / _items.Count; // Angle for each slice / 每個扇形的角度

            // Some simple colors / 一些簡單的顏色
            Brush[] brushes = new Brush[]
            {
                Brushes.Gold, Brushes.LightSkyBlue, Brushes.LightGreen,
                Brushes.Orange, Brushes.LightCoral, Brushes.Plum
            };

            // Loop through each item and draw its slice / 循環遍歷每個項目並繪製其扇形
            for (int i = 0; i < _items.Count; i++)
            {
                float start = _angle + i * sweep; // Calculate start angle for this slice / 計算此扇形的起始角度
                Brush b = brushes[i % brushes.Length]; // Pick a color / 選擇一種顏色

                g.FillPie(b, rect, start, sweep); // Draw the filled slice / 繪製填充的扇形
                g.DrawPie(Pens.White, rect, start, sweep); // Draw the slice border / 繪製扇形邊框

                // Text in the sector / 扇區中的文字
                using (Font f = new Font("Segoe UI", 10, FontStyle.Bold))
                {
                    float midAngle = (start + start + sweep) / 2f; // Mid-angle of the slice / 扇形的中心角度
                    double rad = midAngle * Math.PI / 180.0; // Convert to radians / 轉換為弧度

                    // Calculate text position / 計算文字位置
                    float r = size / 2f * 0.65f; // Radius for text placement / 文字放置的半徑
                    float cx = rect.Left + size / 2f; // Center X / 中心 X
                    float cy = rect.Top + size / 2f; // Center Y / 中心 Y

                    float tx = cx + (float)(r * Math.Cos(rad));
                    float ty = cy + (float)(r * Math.Sin(rad));

                    string text = _items[i]; // Get the item text / 獲取項目文字
                    SizeF textSize = g.MeasureString(text, f); // Measure the text / 測量文字大小
                    // Draw the text centered / 繪製置中的文字
                    g.DrawString(text, f, Brushes.White,
                        tx - textSize.Width / 2,
                        ty - textSize.Height / 2);
                }
            }

            // Center circle / 中心圓形
            int inner = (int)(size * 0.2); // Size of the center circle / 中心圓的大小
            Rectangle innerRect = new Rectangle(
                (Width - inner) / 2,
                (Height - inner) / 2,
                inner,
                inner);
            g.FillEllipse(Brushes.White, innerRect); // Draw the center circle / 繪製中心圓

            // Arrow at the top / 頂部的箭頭
            Point centerTop = new Point(Width / 2, rect.Top - 5); // Top point of the arrow / 箭頭的頂點
            // Define arrow points / 定義箭頭的點
            Point[] arrow =
            {
                new Point(centerTop.X - 15, centerTop.Y),
                new Point(centerTop.X + 15, centerTop.Y),
                new Point(centerTop.X, centerTop.Y + 25)
            };
            g.FillPolygon(Brushes.Red, arrow); // Draw the arrow / 繪製箭頭
        }
    }

    // Event arguments class for when the spin is completed / 旋轉完成時的事件參數類別
    public class SpinCompletedEventArgs : EventArgs
    {
        public int Index { get; } // The index of the chosen item / 選中項目的索引
        public string Item { get; } // The string value of the chosen item / 選中項目的字串值

        public SpinCompletedEventArgs(int index, string item)
        {
            Index = index;
            Item = item;
        }
    }
}
