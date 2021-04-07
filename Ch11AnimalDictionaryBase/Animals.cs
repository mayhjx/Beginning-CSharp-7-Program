using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11AnimalDictionaryBase
{
    public class Animals:DictionaryBase
    {
        public void Add(string newId, Animal newAnimal) =>
            Dictionary.Add(newId, newAnimal);

        public void Remove(string animalId) =>
            Dictionary.Remove(animalId);

        public Animal this[string animalId]
        {
            get { return (Animal)Dictionary[animalId]; }
            set { Dictionary[animalId] = value; }
        }

        public new IEnumerator GetEnumerator()
        {
            foreach (object animal in Dictionary.Values)
                yield return (Animal)animal;
        }
    }
}
