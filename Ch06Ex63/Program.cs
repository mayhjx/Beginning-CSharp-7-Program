using System;

namespace Ch06Ex63
{
    class Program
    {
        delegate string ReadLineDelegate();
        static void Main(string[] args)
        {
            ReadLineDelegate readLine;
            Console.WriteLine("Enter a string");
            readLine = Console.ReadLine;

            string input = readLine();
            Console.WriteLine(input);
        }
    }
}
