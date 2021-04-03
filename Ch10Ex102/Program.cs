using System;
using Ch10Ex101;

namespace Ch10Ex102
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class MyDerivedClass : MyClass
    {
        public override string GetString() =>
            base.GetString() + " (output from derived class)"; ;
    }
}
