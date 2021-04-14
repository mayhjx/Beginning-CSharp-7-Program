using System;

namespace Ch13ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            // oldschool way
            Animal animal = new Animal();
            animal.Name = "Benjamin";
            animal.Age = 42;
            animal.Weight = 185.4;

            // use nondefault constructor
            Animal animal1 = new Animal("Benjamin", 42, 185.4);

            // use object initializers
            Animal animal2 = new Animal
            {
                Name = "Benjamin",
                Age = 42,
                Weight = 185.4
            };

            Animal animal3 = new Animal("Rual", 44, 166.1)
            {
                Name = "Benjamin",
                Age = 42,
                Weight = 185.4
            };

            Console.WriteLine(animal3.Name); // Benjamin
        }
    }

    public class Animal
    {
        // necessary to be serializable (JSON or XML)
        // The concept of Serialization and deserialization is used
        // whenever data pertaining to objects have to be sent from
        // one application to another.
        // https://www.guru99.com/c-sharp-serialization.html
        public Animal() { }
        public Animal(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
    }
}
