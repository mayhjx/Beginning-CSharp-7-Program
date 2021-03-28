using System;

namespace Ch06Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
            int maxVal = MaxValue(myArray);
            Console.WriteLine($"The Maximum value in myArray is {maxVal}");
        }

         static int MaxValue(int[] myArray)
        {
            int maxVal = myArray[0];
            for(int i =1; i< myArray.Length; i++)
            {
                if(myArray[i] > maxVal)
                {
                    maxVal = myArray[i];
                }
            }
            return maxVal;
        }
    }
}
