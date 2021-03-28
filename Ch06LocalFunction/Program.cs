using System;

namespace Ch06LocalFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 5;
            Console.WriteLine($"Main Function = {myNumber}");
            DoubleIt(myNumber);

            void DoubleIt(int val)
            {
                val *= 2;
                Console.WriteLine($"Local Function - val = {val}");
            }
        }
    }
}
