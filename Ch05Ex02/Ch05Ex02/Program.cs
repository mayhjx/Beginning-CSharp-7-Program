using static System.Console;
using System;

namespace Ch05Ex02
{
    enum orientation: byte
    {
        north = 1,
        south = 2,
        east = 3,
        west = 4
    }

    class Program
    {
        static void Main(string[] args)
        {
            byte DirectionByte;
            string DirectionString;
            orientation myDirection = orientation.north;
            WriteLine($"myDirection = {myDirection}");
            DirectionByte = (byte)myDirection;
            DirectionString = myDirection.ToString();
            WriteLine($"byte equivalent = {DirectionByte}");
            WriteLine($"string equivalent = {DirectionString}");

            // loop enum values
            foreach(var i in Enum.GetValues(typeof(orientation)))
            {
                Console.WriteLine(i);
            }

            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"Foreground Color set to {color}");
            }

            Console.WriteLine(typeof(System.ComponentModel.DisplayNameAttribute));
        }
    }
}
