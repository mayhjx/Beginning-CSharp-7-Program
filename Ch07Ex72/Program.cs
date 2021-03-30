using System;

namespace Ch07Ex72
{
    class Program
    {
        static int[] array = new int[] { 1, 2, 3 };
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                i++;
                //Console.WriteLine(i);
                if(i == 5000)
                {
                    array[4] = 0;
                }
            }
        }
    }
}
