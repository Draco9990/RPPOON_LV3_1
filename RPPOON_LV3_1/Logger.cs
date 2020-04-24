using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace RPPOON_LV3_1
{
    class Logger
    {
        public static Logger instance;
        private string filePath;

        private Logger()
        {
            filePath = @"C:\temp.txt";
        }

        public static Logger GetInstance()
        {
            if(instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }

        public void Log(string message)
        {
            using (StreamWriter file = new StreamWriter(filePath, true))
            {
                file.Write(message);
            }
        }

        public void SetFilepath(string filepathIn)
        {
            filePath = filepathIn;
        }
    }
}
