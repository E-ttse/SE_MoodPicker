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
    public partial class Mode2_Result: UserControl
    {
        public event Action Switch_to_MainPage;
        public Mode2_Result()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Switch_to_MainPage?.Invoke();
        }
    }
}
