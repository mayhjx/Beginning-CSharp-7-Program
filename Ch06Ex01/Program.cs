using System;

namespace Ch06Ex01
{
    class Program
    {
        static string myString;
        static void Write()
        {
            string myString = "String defined in Write()";
            Console.WriteLine("\nNow in Write()");
            Console.WriteLine($"Local myString = {myString}");
            Console.WriteLine($"Global myString = {Program.myString}");
        }
        static void Main(string[] args)
        {
            string myString = "String defined in Main()";
            Program.myString = "Global string";
            Write();
            Console.WriteLine("\nNow in Main()");
            Console.WriteLine($"Local myString = {myString}");
            Console.WriteLine($"Global myString = {Program.myString}");
        }
    }
}
