using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV3_1
{
    public enum Category { ERROR, ALERT, INFO }
    public class ConsoleNotification : Prototype
    {
        public String Author { get; private set; }
        public String Title { get; private set; }
        public String Text { get; private set; }
        public DateTime Timestamp { get; private set; }
        public Category Level { get; private set; }
        public ConsoleColor Color { get; private set; }
        public ConsoleNotification(String author, String title, String text, DateTime time, Category level, ConsoleColor color)
        {
            this.Author = author;
            this.Title = title;
            this.Text = text;
            this.Timestamp = time;
            this.Level = level;
            this.Color = color;
        }

        public void SetColor(ConsoleColor inC)
        {
            this.Color = inC;
        }

        public Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
