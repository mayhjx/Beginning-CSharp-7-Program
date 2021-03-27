using System;

namespace Ch05TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // 281 = 100011001
            // 25 =  000011001
            // 255 = 011111111
            byte destinationVar;
            short sourceVar = 281;
            destinationVar = (byte)sourceVar;
            Console.WriteLine($"sourceVar val: {sourceVar}");
            Console.WriteLine($"destinationVar val: {destinationVar}");
        }
    }
}
