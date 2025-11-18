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
    public partial class MainPage: UserControl
    {
        public event Action Switch_to_Mode1;
        public event Action Switch_to_Mode2;
        
        public MainPage()
        {
            InitializeComponent();            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Switch_to_Mode1?.Invoke();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Switch_to_Mode2?.Invoke();
        }
    }
}
