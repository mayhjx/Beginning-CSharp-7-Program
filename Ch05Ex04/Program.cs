using System;
using static System.Console;
using static System.Convert;

namespace Ch05Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friendNames = { "Todd Anthony", "Kevin Holton", "Shane Laigle" };
            WriteLine($"Here are {friendNames.Length} of my friends:");
            
            //for (int i = 0; i < friendNames.Length; i++)
            //{
            //    WriteLine(friendNames[i]);
            //}

            foreach(string friendName in friendNames)
            {
                WriteLine(friendName);
            }
        }
    }
}
