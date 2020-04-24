using System;
using System.Collections.Generic;

namespace RPPOON_LV3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadatak1();
            Zadatak2();
            Zadatak3();
            Zadatak4();
            Zadatak5();
            Zadatak6();
            Zadatak7();
        }

        static void Debug(Dataset d)
        {
            foreach (List<string> listString in d.GetData())
            {
                foreach (string s in listString)
                {
                    Console.Write(s + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Debug(float[][] f)
        {
            for (int i = 0; i < f.Length;  i++)
            {
                for(int j = 0; j < f[i].Length; j++)
                {
                    Console.Write(f[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Zadatak1()
        {
            Console.WriteLine("Zadatak 1");
            Console.WriteLine("Original");
            Console.WriteLine(Environment.CurrentDirectory);
            Prototype a1 = new Dataset(Environment.CurrentDirectory + @"\csv.csv");
            Debug((Dataset)a1);
            Console.WriteLine("Deep Copy");
            Prototype a2 = a1.Clone();
            Debug((Dataset)a2);
            Console.WriteLine("***************************************\n");
            /* Zakljucak:
             * Duboko kopiranje nije potrebno u ovom primjeru jer ce rezultati biti isti. Razlog toga je sto Dataset nema slozene tipove podatka koje bi se trebalo duboko kopirati!
             * */
        }
 
        static void Zadatak2()
        {
            Console.WriteLine("Zadatak 2");
            Console.WriteLine("Nasumicna matrica velicine 2x3");
            float[][] matrix = MatrixGenerator.GetInstance().CreateMatrix(2, 3);
            Debug(matrix);
            Console.WriteLine("***************************************\n");

        }
        
        static void Zadatak3()
        {
            Console.WriteLine("Zadatak 3");
            Console.WriteLine("U C:log.txt je napisana jedna recenica sa dvije funkcije.");
            Logger.GetInstance().SetFilepath(@"C:\log.txt");
            Zadatak3_1();
            Zadatak3_2();
            Console.WriteLine("\n***************************************\n");
            //Zato sto je logger singleton, obje funkcije pisu na isto mjesto.
        }
        static void Zadatak3_1()
        {
            Logger.GetInstance().Log("Ovo je pocetak ");
        }
        static void Zadatak3_2()
        {
            Logger.GetInstance().Log("nekakve recenice!");
        }

        static void Zadatak4()
        {
            Console.WriteLine("Zadatak 4");
            Console.WriteLine("Testiranje klase sa podatcima: Anonymous, Notification, NotificationText, CurrTime, ERROR, Red");
            ConsoleNotification notif = new ConsoleNotification("Anonymous", "Notification", "NotificationText", DateTime.Now, Category.ERROR, ConsoleColor.Red);
            NotificationManager manager = new NotificationManager();
            manager.Display(notif);
            Console.WriteLine("\n***************************************\n");
        }

        static void Zadatak5()
        {
            Console.WriteLine("Zadatak 5");
            Console.WriteLine("Testiranje NotificationBuildera sa prijasnjim podatcima");
            NotificationBuilder builder = new NotificationBuilder();
            builder
                .SetTitle("Notification")
                .SetText("NotificationText")
                .SetTime(DateTime.Now)
                .SetColor(ConsoleColor.Red);
            NotificationManager manager = new NotificationManager();
            manager.Display(builder.Build());
            Console.WriteLine("\n***************************************\n");
        }

        static void Zadatak6()
        {
            Console.WriteLine("Zadatak 6");
            Console.WriteLine("Testiranje Direktora sa prijasnjim podatcima");
            Director dir = new Director(new NotificationBuilder());
            NotificationManager manager = new NotificationManager();
            manager.Display(dir.LogError("Anonymous"));
            Console.WriteLine("\n***************************************\n");
        }

        static void Zadatak7()
        {
            Console.WriteLine("Zadatak 7");
            Console.WriteLine("Testiranje shallow copy funkcije");
            ConsoleNotification notif = new ConsoleNotification("Anonymous", "Notification", "NotificationText", DateTime.Now, Category.ERROR, ConsoleColor.Red);
            ConsoleNotification notifCopy = (ConsoleNotification)notif.Clone();
            NotificationManager manager = new NotificationManager();
            Console.WriteLine("Original");
            manager.Display(notif);
            Console.WriteLine("\nShallow Copy");
            manager.Display(notifCopy);

            Console.WriteLine("\n***************************************\n");
            //Kao sto vidimo, shallow copy je sasvim dovoljan za kopiranje navedenih podataka, jer consolenotification klasa nema slozenih tipova
        }
    }
}
