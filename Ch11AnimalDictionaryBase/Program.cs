using System;
using System.Collections;

namespace Ch11AnimalDictionaryBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animals = new Animals();

            animals.Add("A", new Cow("Andrea"));
            animals.Add("B", new Chicken("Donna"));

            //foreach(DictionaryEntry animal in animals)
            //{
            //    Console.WriteLine($"{animal.Key} {((Animal)animal.Value).Name}");
            //}

            foreach(Animal myAnimal in animals)
            {
                Console.WriteLine($"{myAnimal.ToString()} object added to " +
                    $"custom collection, Name = {myAnimal.Name}");
            }
        }
    }
}
