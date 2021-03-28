using System;

namespace Ch06StructFunction
{
    class Program
    {
        struct CustomerName
        {
            public string firstName, lastName;
            public string Name() => firstName + " " + lastName;
        }
        static void Main(string[] args)
        {
            CustomerName myCustomer;
            myCustomer.firstName = "John";
            myCustomer.lastName = "franklin";
            Console.WriteLine(myCustomer.Name()) ;
        }
    }
}
