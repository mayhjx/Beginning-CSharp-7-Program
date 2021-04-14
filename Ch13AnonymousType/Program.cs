using System;

namespace Ch13AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = new
            {
                Name = "Lea",
                Age = 11,
                Weight = 30.2
            };
            // animal.Name = "Rula"; // Readonly
        }
    }
}
