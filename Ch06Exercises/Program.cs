using System;

namespace Ch06Ex62
{
    class Program
    {
        static void Main(string[] args)
        {
            string arg1 = args[0];
            int arg2 = Convert.ToInt32(args[1]);
            Console.WriteLine($"{arg1} {arg2}");
        }
    }
}
