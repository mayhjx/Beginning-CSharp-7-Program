using System;
using System.IO;
using System.Reflection;

namespace Ch13Reflection
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nReflection.MemberInfo");
            Type MyType = Type.GetType("System.IO.File", true); // return null ???
            MemberInfo[] MyMemberInfoArray = MyType.GetMembers();

            Console.WriteLine($"\nThere are {MyMemberInfoArray.Length} members in {MyType.FullName}");
            Console.WriteLine($"{MyType.FullName}");

            if (MyType.IsPublic)
            {
                Console.WriteLine($"{MyType.FullName} is public.");
            }
        }

        private static void GetStringTypeConstructors()
        {
            Type t = typeof(System.String);
            Console.WriteLine($"Listing all the public constructors of the {t} type");
            ConstructorInfo[] ci = t.GetConstructors(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine("//constructors");
            PrintMembers(ci);
        }

        private static void PrintMembers(MemberInfo[] ms)
        {
            foreach(MemberInfo m in ms)
            {
                Console.WriteLine($"\t{m}");
            }
            Console.WriteLine();
        }
    }
}
