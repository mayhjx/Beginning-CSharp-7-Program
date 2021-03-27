using System;
using static System.Console;

namespace Ch05Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friendNames = { "Todd Anthony", "Kevin Holton", 
                                    "Shane Laigle", null, "" };

            foreach(string friendName in friendNames)
            {
                switch (friendName)
                {
                    case string t when t.StartsWith("T"):
                        WriteLine($"This friends name starts with a 'T': " +
                                    $"{friendName} and is {t.Length - 1} letters long.");
                        break;
                    case string e when e.Length == 0:
                        WriteLine("There is a string in the array with no value");
                        break;
                    case null:
                        WriteLine("There was a 'null' value in the array");
                        break;
                    case var x:
                        WriteLine("This is the var pattern of type: " +
                                    $"{x.GetType().Name}");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
