using System;

namespace Ch05Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("multidimensional Arrays:");
            //double[,] hillHeight = new double[3, 4];
            double[,] hillHeight =
            {
                { 1, 2, 3, 4 },
                { 2, 3, 4, 5 },
                { 3, 4, 5, 6 },
            };

            // loop
            foreach (double height in hillHeight)
            {
                Console.WriteLine($"{height}");
            }

            Console.WriteLine("Arrays of Arrays:");
            // declaring in turn
            int[][] jaggedIntArray;
            jaggedIntArray = new int[2][];
            jaggedIntArray[0] = new int[3] { 1, 2, 3 };
            jaggedIntArray[1] = new int[4] { 1, 2, 3, 4 };

            // or
            int[][] jaggedIntArray1 = new int[3][]
            {
                new int[] {1, 2, 3},
                new int[] {1},
                new int[] {1, 2},
            };

            // simplified
            int[][] jaggedIntArray2 =
            {
                new int[] {1, 2, 3},
                new int[] {1},
                new int[] {1, 2},
            };

            // loop 
            foreach(int[] arr in jaggedIntArray2)
            {
                //Console.WriteLine(string.Join(":", arr));
                foreach(int elem in arr)
                {
                    Console.WriteLine(elem);
                }
            }

        }
    }
}
