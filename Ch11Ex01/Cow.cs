using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11Ex01
{
    public class Cow:Animal
    {
        public void Mile() => Console.WriteLine($"{name} has beed milked.");
        public Cow(string newName) : base(newName) { }
    }
}
