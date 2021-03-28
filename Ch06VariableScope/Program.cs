using System;

namespace Ch06VariableScope
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string text = "";
            for (i = 0; i < 10; i++)
            {
                text = $"Line {Convert.ToString(i)}";
                Console.WriteLine($"{text}");
            }
            Console.WriteLine($"Last text output in loop: {text}");
        }
    }
}
