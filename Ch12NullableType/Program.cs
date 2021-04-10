using System;

namespace Ch12NullableType
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Nullable<int> nullableInt = null;
            Console.WriteLine(nullableInt.HasValue);
        }
    }
}
