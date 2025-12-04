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

            // Path to card back image
            string cardBackPath = System.IO.Path.Combine(Application.StartupPath, "Images", "card_back.jpg");
            Image cardBackImage = null;

            if (System.IO.File.Exists(cardBackPath))
            {
                try
                {
                    cardBackImage = Image.FromFile(cardBackPath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading card back: {ex.Message}");
                }
            }

            for (int i = 0; i < cards.Length; i++)
            {
                // Reset card state
                if (cardBackImage != null)
                {
                    cards[i].Image = (Image)cardBackImage.Clone(); // Clone to avoid sharing issues if disposed
                    cards[i].SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    cards[i].Image = null;
                }
                
                cards[i].Cover();

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
                // Simulate execution trace
                System.Diagnostics.Debug.WriteLine($"[Card_Click] Card clicked at position {card.Position}");
                System.Diagnostics.Debug.WriteLine($"[Card_Click] Activity: {card.Activity.Name}");

                // Try to load image
                if (!string.IsNullOrEmpty(card.Activity.ImagePath) && System.IO.File.Exists(card.Activity.ImagePath))
                {
                    try
                    {
                        card.Image = Image.FromFile(card.Activity.ImagePath);
                        card.SizeMode = PictureBoxSizeMode.StretchImage; // Fit image to box
                        System.Diagnostics.Debug.WriteLine($"[Card_Click] Image loaded from {card.Activity.ImagePath}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error loading image: {ex.Message}");
                        // Fallback if load fails
                        CreatePlaceholderImage(card);
                    }
                }
                else
                {
                    // File doesn't exist or path empty
                    CreatePlaceholderImage(card);
                    System.Diagnostics.Debug.WriteLine($"[Card_Click] Image not found, using placeholder.");
                }

                MessageBox.Show($"Suggested Activity: {card.Activity.Name}", "Activity Revealed");
            }
        }

        private void CreatePlaceholderImage(Mode1_Card card)
        {
            // Create a simple bitmap with the activity name
            Bitmap bmp = new Bitmap(card.Width, card.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.LightBlue);
                using (Font font = new Font("Arial", 12))
                using (Brush brush = new SolidBrush(Color.Black))
                {
                    SizeF textSize = g.MeasureString(card.Activity.Name, font);
                    float x = (card.Width - textSize.Width) / 2;
                    float y = (card.Height - textSize.Height) / 2;
                    g.DrawString(card.Activity.Name, font, brush, x, y);
                }
            }
            card.Image = bmp;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Switch_to_MainPage?.Invoke();
        }
    }
}
