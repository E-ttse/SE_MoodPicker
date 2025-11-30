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

        public Mode1_Mood CurrentMood { get; private set; }

        // 看收到哪個mood就顯示哪個mood的畫面
        public void SetMood(int moodId)
        {
            currentMood = moodId;
           
            switch (moodId)
            {
                case 0:
                    CurrentMood = new Mode1_Happy();
                    label2.Text = $"{CurrentMood.Name} :D";
                    break;
                case 1:
                    CurrentMood = new Mode1_Boring();
                    label2.Text = $"{CurrentMood.Name} :|";
                    break;
                case 2:
                    CurrentMood = new Mode1_Bad();
                    label2.Text = $"{CurrentMood.Name} :(";
                    break;
                case 3:
                    CurrentMood = new Mode1_Angry();
                    label2.Text = $"{CurrentMood.Name} #-_-";
                    break;
                default:
                    CurrentMood = new Mode1_Happy();
                    label2.Text = $"{CurrentMood.Name} :D";
                    break;
            }

            // Assign activities to cards
            var activities = CurrentMood.GetShuffledActivities();
            var cards = new[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };

            for (int i = 0; i < cards.Length; i++)
            {
                if (i < activities.Count)
                {
                    cards[i].Activity = activities[i];
                    cards[i].Click -= Card_Click; // Prevent double subscription
                    cards[i].Click += Card_Click;
                }
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            if (sender is Mode1_Card card && card.Activity != null)
            {
                MessageBox.Show($"Suggested Activity: {card.Activity.Name}", "Activity Revealed");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Switch_to_MainPage?.Invoke();
        }
    }
}
