using System;
using System.Collections;

namespace Ch11ExAll
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
            people.Add(new Person("Jack", 27));
            people.Add(new Person("Mike", 27));
            people.Add(new Person("Monica", 25));

            Console.WriteLine("Name\tAge");
            foreach (DictionaryEntry p in people)
            {
                Console.WriteLine($"{p.Key}\t{(p.Value as Person).Age}");
            }

            Console.WriteLine($"Is {people["Jack"].Name} older than {people["Mike"].Name} ? " +
                $"{people["Jack"] > people["Mike"]}");

            Person[] oldestPeople = people.GetOldest();

            foreach (Person p in oldestPeople)
            {
                Console.WriteLine($"{p.Name} {p.Age}");
            }

            Console.WriteLine();
            Console.WriteLine("Copy the people");
            People newPeople = (People)people.Clone();
            people.Add(new Person("Ross", 28));

            foreach (DictionaryEntry p in newPeople)
            {
                Console.WriteLine($"{p.Key}\t{(p.Value as Person).Age}");
            }

            foreach (int age in people.Ages)
            {
                Console.WriteLine(age);
            }
        }
    }

    public class People : DictionaryBase, ICloneable
    {
        public void Add(Person newPerson) =>
            Dictionary.Add(newPerson.Name, newPerson);

        public void Remove(string name) => Dictionary.Remove(name);

        public Person this[string name]
        {
            get { return (Person)Dictionary[name]; }
            set { Dictionary[name] = value; }
        }

        public Person[] GetOldest()
        {
            ArrayList oldestPeople = new ArrayList(Dictionary.Values);

            oldestPeople.Sort(PersonComparerAge.Defalut);

            int oldestAge = ((Person)oldestPeople[0]).Age;

            for (int i = oldestPeople.Count - 1; i > 0; i--)
            {
                if (((Person)oldestPeople[i]).Age != oldestAge)
                {
                    oldestPeople.RemoveAt(i);
                }
                else
                {
                    break;
                }
            }

            Person[] people = new Person[oldestPeople.Count];
            oldestPeople.CopyTo(people);
            return people;
        }

        public object Clone()
        {
            People newPeople = new People();
            foreach (DictionaryEntry p in this.Dictionary)
            {
                newPeople.Add(new Person(p.Key.ToString(), ((Person)p.Value).Age));
            }
            return newPeople;
        }

        public IEnumerable Ages
        {
            get
            {
                foreach (object person in Dictionary.Values)
                {
                    yield return (person as Person).Age;
                }
            }
        }
    }

    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public static bool operator >(Person p1, Person p2) => p1.Age > p2.Age;

        public static bool operator <(Person p1, Person p2) => p1.Age < p2.age;

        public static bool operator >=(Person p1, Person p2) => !(p1 < p2);

        public static bool operator <=(Person p1, Person p2) => !(p1 > p2);
    }

    public class PersonComparerAge : IComparer
    {
        public static IComparer Defalut = new PersonComparerAge();
        public int Compare(object x, object y)
        {
            if (x is Person p1 && y is Person p2)
            {
                return Comparer.Default.Compare(p2.Age, p1.Age);
            }
            else
            {
                throw new ArgumentException("Can not compare two different type of objects.");
            }
        }
    }

}
