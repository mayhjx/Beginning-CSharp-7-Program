using System;

namespace Ch05Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5.4  print the string in reverse order
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            for(int i=input.Length-1; i>=0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();

            // 5.5 replace all occurrence of the string no with yes
            string input1 = "no no no no no";
            input1 = input1.Replace("no", "yes");
            Console.WriteLine(input1);

            //5.6 places double quotes around each word in a string
            string input2 = "Enter a string";

            string input3 = input2.Replace(" ", "\" \"");
            Console.WriteLine($"\"{input3}\"");

            // or
            string[] myWords = input2.Split(' ');
            foreach(string word in myWords)
            {
                Console.Write($"\"{word}\" ");
            }
        }
    }
}
