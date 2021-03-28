using System;
using System.Collections.Generic;
using System.Linq;

namespace Ch06Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            var result = GetMaxMin(numbers);
            Console.WriteLine($"Max number is {result.max}, " +
                                $"Min number is {result.min}, " +
                                $"Average is {result.average}");
        }

        private static (int max, int min, double average)
            GetMaxMin(IEnumerable<int> numbers)
        {
            return (Enumerable.Max(numbers),
                    Enumerable.Min(numbers),
                    Enumerable.Average(numbers));
        }
    }
}
