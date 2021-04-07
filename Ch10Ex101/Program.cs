using System;

namespace Ch10Ex101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class MyClass
    {
        protected string myString;
        public virtual string GetString() => myString;

        public string ContainedString
        {
            set
            {
                myString = value;
            }
        }
    }
}
