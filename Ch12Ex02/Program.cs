using System;
using System.Collections.Generic;

namespace Ch12Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalCollection = new List<Animal>();
            animalCollection.Add(new Cow("Rual"));
            animalCollection.Add(new Chicken("Donna"));
            foreach(Animal myAniaml in animalCollection)
            {
                myAniaml.Feed();
            }
        }
    }
}
