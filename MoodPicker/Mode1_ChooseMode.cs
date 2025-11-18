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
    public partial class Mode1_ChooseMode: UserControl
    {
        public event Action<int> Switch_to_EachMood;
        public event Action Switch_to_MainPage;

        public Mode1_ChooseMode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Switch_to_EachMood?.Invoke(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Switch_to_EachMood?.Invoke(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Switch_to_EachMood?.Invoke(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Switch_to_EachMood?.Invoke(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Switch_to_MainPage?.Invoke();
        }
    }
}
