using System;
using System.Timers;
using static System.Console;

namespace Ch13Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection myConnection = new Connection();
            Display myDisplay = new Display();
            myConnection.MessageArrived +=
                new MessageHandler(myDisplay.DisplayMessage);
            myConnection.Connect();
            ReadKey();
        }
    }
}
