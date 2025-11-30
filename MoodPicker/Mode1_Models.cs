using System;
using System.Collections.Generic;
using System.Linq;

namespace MoodPicker
{
    public class Mode1_Activity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        public Mode1_Activity(string name, string description = "", string imagePath = "")
        {
            Name = name;
            Description = description;
            ImagePath = imagePath;
        }

        public void Execute()
        {
            // Implementation for executing the activity
            Console.WriteLine($"Executing activity: {Name}");
        }

        public void DisplayInfo()
        {
            // Implementation for displaying activity info
            Console.WriteLine($"Activity: {Name}, Description: {Description}");
        }
    }

    public class Mode1_Card
    {
        public int Position { get; set; }
        public Mode1_Activity Activity { get; set; }
        public bool IsRevealed { get; private set; }

        public Mode1_Card(int position, Mode1_Activity activity)
        {
            Position = position;
            Activity = activity;
            IsRevealed = false;
        }

        public void Flip()
        {
            IsRevealed = !IsRevealed;
        }

        public void Cover()
        {
            IsRevealed = false;
        }

        public void ShowActivity()
        {
            if (IsRevealed)
            {
                Activity.DisplayInfo();
            }
        }
    }

    public abstract class Mode1_Mood
    {
        public string Name { get; set; }
        public List<Mode1_Activity> Activities { get; set; }

        public Mode1_Mood(string name)
        {
            Name = name;
            Activities = new List<Mode1_Activity>();
        }

        public List<Mode1_Activity> GetAllActivities()
        {
            return Activities;
        }

        public List<Mode1_Activity> GetShuffledActivities()
        {
            var rng = new Random();
            return Activities.OrderBy(a => rng.Next()).ToList();
        }
    }

    public class Mode1_Happy : Mode1_Mood
    {
        public Mode1_Happy() : base("Happy")
        {
            Activities.Add(new Mode1_Activity("騎腳踏車"));
            Activities.Add(new Mode1_Activity("做甜點"));
            Activities.Add(new Mode1_Activity("吃壽司"));
            Activities.Add(new Mode1_Activity("吃披薩"));
        }
    }

    public class Mode1_Boring : Mode1_Mood
    {
        public Mode1_Boring() : base("Boring")
        {
            Activities.Add(new Mode1_Activity("逛書店"));
            Activities.Add(new Mode1_Activity("看電影"));
            Activities.Add(new Mode1_Activity("吃異國料理"));
            Activities.Add(new Mode1_Activity("做菜"));
        }
    }

    public class Mode1_Bad : Mode1_Mood
    {
        public Mode1_Bad() : base("Bad")
        {
            Activities.Add(new Mode1_Activity("慢跑"));
            Activities.Add(new Mode1_Activity("寫日記"));
            Activities.Add(new Mode1_Activity("喝熱可可"));
            Activities.Add(new Mode1_Activity("吃泡麵"));
        }
    }

    public class Mode1_Angry : Mode1_Mood
    {
        public Mode1_Angry() : base("Angry")
        {
            Activities.Add(new Mode1_Activity("跑步"));
            Activities.Add(new Mode1_Activity("整理房間"));
            Activities.Add(new Mode1_Activity("玩遊戲"));
            Activities.Add(new Mode1_Activity("重訓"));
        }
    }
}
