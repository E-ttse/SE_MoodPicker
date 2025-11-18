using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace MoodPicker
{
    public partial class Mode1_EachMode: UserControl
    {

        public event Action Switch_to_MainPage;
        private int currentMood;

        public Mode1_EachMode()
        {
            InitializeComponent();
        }

        // 看收到哪個mood就顯示哪個mood的畫面
        public void SetMood(int moodId)
        {
            currentMood = moodId;
           
            switch (moodId)
            {
                case 0:
                    label2.Text = "Happy :D";
                    break;
                case 1:
                    label2.Text = "Boring :|";
                    break;
                case 2:
                    label2.Text = "Bad :(";
                    break;
                case 3:
                    label2.Text = "Angry #-_-";
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Switch_to_MainPage?.Invoke();
        }
    }
}
