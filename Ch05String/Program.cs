using System;
using System.Globalization;

namespace Ch05String
{
    class Program
    {
        static void Main(string[] args)
        {
            // a string type can treated as a read-only array of char
            string myString = "Hello World!";
            Console.WriteLine(myString[1]);
            foreach(char ch in myString)
            {
                Console.WriteLine($"{ch}");
            }
            // convert string to char array which can modified
            char[] myChars = myString.ToCharArray();
            myChars[1] = 'E';
            Console.WriteLine(string.Join("", myChars));

            // get string length
            Console.WriteLine("Enter some string: ");
            string input = Console.ReadLine();
            Console.WriteLine($"You types {input.Length} characters");

            // convert string to lower case and upper case
            myString = myString.ToUpper();
            Console.WriteLine(myString);

            myString = myString.ToLower();
            Console.WriteLine(myString);

            // convert string to titlecase
            TextInfo myTI = new CultureInfo("zh-cn").TextInfo;

            myString = myTI.ToTitleCase(myString); // can not format string that is entirely uppercase, such as acronym
            Console.WriteLine(myString);

            // trim space at the beginning or end of the string
            string myString1 = "  123  ";
            Console.WriteLine($"|{myString1.Trim()}|");
            Console.WriteLine($"|{myString1.TrimStart()}|");
            Console.WriteLine($"|{myString1.TrimEnd()}|");

            // trim target characters at the beginning or end of the string
            char[] trimChars = { ' ', 'e', 's' };
            string myString2 = " Yeeeeeeeees";
            Console.WriteLine(myString2.Trim(trimChars));

            // padding
            Console.WriteLine("Aligned".PadLeft(10));
            Console.WriteLine("Aligned".PadLeft(10, '-'));
        }
    }
}
