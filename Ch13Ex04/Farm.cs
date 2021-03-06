using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13Ex04
{
    public class Farm<T> : IEnumerable<T>
        where T : Animal
    {
        private List<T> animals = new List<T>();
        public List<T> Animals
        {
            get { return animals; }
        }

        public IEnumerator<T> GetEnumerator() => animals.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => animals.GetEnumerator();

        public void Add(T animal) => animals.Add(animal);

        public void MakeNoises()
        {
            foreach (T animal in animals)
            {
                animal.MakeANoise();
            }
        }
        public void FeedTheAnimals()
        {
            foreach (T animal in animals)
            {
                animal.Feed();
            }
        }
        public Farm<U> GetSpecies<U>() where U : T
        {
            Farm<U> speciesFarm = new Farm<U>();
            foreach (T animal in animals)
            {
                if (animal is U)
                {
                    speciesFarm.Animals.Add(animal as U);
                }
            }
            return speciesFarm;
        }
    }
}
