using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12Ex04
{
    class SuperCow : Cow
    {
        public void Fly()
        {
            Console.WriteLine($"{name} is flying!");
        }
        public SuperCow(string newName) : base(newName)
        {

        }
        public override void MakeANoise()
        {
            Console.WriteLine($"{name} says 'here i come to save the day!");
        }
    }
}
