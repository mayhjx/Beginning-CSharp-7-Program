using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13Ex04
{
    public class Cow : Animal
    {
        public void Mile() => Console.WriteLine($"{name} has beed milked.");

        public override void MakeANoise()
        {
            Console.WriteLine($"{name} says 'moo!'");
        }

    }
}
