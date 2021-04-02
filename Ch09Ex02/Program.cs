using System;
using Ch09ClassLib;

namespace Ch09Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            var myObj = new MyExternalClass();
            Console.WriteLine(myObj.ToString());
        }
    }
}
