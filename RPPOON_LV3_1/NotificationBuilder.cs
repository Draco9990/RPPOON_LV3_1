using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV3_1
{
    class NotificationBuilder : IBuilder
    {
        string author = "Anonymous";
        string title = "";
        string text = "";
        DateTime timestamp = DateTime.Now;
        Category level = Category.ERROR;
        ConsoleColor color = ConsoleColor.White;

        public ConsoleNotification Build()
        {
            return new ConsoleNotification(author, title, text, timestamp, level, color);
        }

        public IBuilder SetAuthor(string author)
        {
            this.author = author;
            return this;
        }

        public IBuilder SetColor(ConsoleColor color)
        {
            this.color = color;
            return this;
        }

        public IBuilder SetLevel(Category level)
        {
            this.level = level;
            return this;
        }

        public IBuilder SetText(string text)
        {
            this.text = text;
            return this;
        }

        public IBuilder SetTime(DateTime time)
        {
            this.timestamp = time;
            return this;
        }

        public IBuilder SetTitle(string title)
        {
            this.title = title;
            return this;
        }
    }
}
