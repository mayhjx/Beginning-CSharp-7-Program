using System;
using System.Timers;
using static System.Console;

namespace Ch13Ex01
{
    class Program
    {
        static int counter = 0;
        static string displayString = 
            "This string will appear one letter at a time. ";

        static void Main(string[] args)
        {
            Timer myTimer = new Timer(200);
            myTimer.Elapsed += new ElapsedEventHandler(WriteChar);
            myTimer.Start();

            // give the timer the opportunity to start sending message to the console application.
            System.Threading.Thread.Sleep(200); 

            ReadKey(); // important
        }

        static void WriteChar(object source, ElapsedEventArgs e)
        {
            Write(displayString[counter++ % displayString.Length]);
        }
    }
}
