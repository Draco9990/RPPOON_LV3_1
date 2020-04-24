using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV3_1
{
    class Director
    {
        IBuilder builder = new NotificationBuilder();

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }
        
        public void SetBuilder(IBuilder builder)
        {
            this.builder = builder;
        }

        public ConsoleNotification LogInfo(string author)
        {
            return builder
                .SetAuthor(author)
                .SetTitle("Notification")
                .SetText("NotificationText")
                .SetTime(DateTime.Now)
                .SetLevel(Category.INFO)
                .SetColor(ConsoleColor.Blue)
                .Build();
        }

        public ConsoleNotification LogAlert(string author)
        {
            return builder
                .SetAuthor(author)
                .SetTitle("Notification")
                .SetText("NotificationText")
                .SetTime(DateTime.Now)
                .SetLevel(Category.ALERT)
                .SetColor(ConsoleColor.DarkYellow)
                .Build();
        }

        public ConsoleNotification LogError(string author)
        {
            return builder
                .SetAuthor(author)
                .SetTitle("Notification")
                .SetText("NotificationText")
                .SetTime(DateTime.Now)
                .SetLevel(Category.ERROR)
                .SetColor(ConsoleColor.Red)
                .Build();
        }
    }
}
