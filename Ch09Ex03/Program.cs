using System;

namespace Ch09Ex03
{
    class Program
    {
        class MyClass
        {
            public int val;
        }
        struct MyStruct
        {
            public int val;
        }
        static void Main(string[] args)
        {
            var objectA = new MyClass();
            var objectB = objectA;
            objectA.val = 10;
            objectB.val = 20;

            var structA = new MyStruct();
            var structB = structA;
            structA.val = 30;
            structB.val = 40;

            Console.WriteLine($"objectA.val = {objectA.val}");
            Console.WriteLine($"objectB.val = {objectB.val}");
            Console.WriteLine($"structA.val = {structA.val}");
            Console.WriteLine($"structB.val = {structB.val}");
        }
    }
}
