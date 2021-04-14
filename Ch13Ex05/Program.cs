using System;
using static System.Console;

namespace Ch13Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new[]
            {
                new { Name = "Benjamin", Age = 42, Weiht = 185 },
                new { Name = "Benjamin", Age = 42, Weiht = 185 },
                new { Name = "Andrea", Age = 46, Weiht = 109 },
            };

            // in an anonymous type outputs each property defined for the type.
            WriteLine(animals[0].ToString());

            // return unique integer for an object based on the object's state.
            WriteLine(animals[0].GetHashCode());
            WriteLine(animals[1].GetHashCode());
            WriteLine(animals[2].GetHashCode());

            // the implementation of Equals() in anonymous types compares
            // the state of objects. The result is true every property of one object
            // contains the same value as the compareable property on another object.
            WriteLine(animals[0].Equals(animals[1])); // true
            WriteLine(animals[0].Equals(animals[2])); // false

            // compare object references.
            WriteLine(animals[0] == animals[1]); // false
            WriteLine(animals[0] == animals[2]); // false
        }
    }


}
