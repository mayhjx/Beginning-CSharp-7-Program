using System;
using Ch09Ex94;

namespace Ch09Ex95
{
    class Traffic
    {
        public static void AddPassenger(IPassengerCarrier passengerCarrier)
        {
            Console.WriteLine(passengerCarrier.ToString());
        }

        static void Main(string[] args)
        {
            AddPassenger(new Compact());
            AddPassenger(new SUV());
            AddPassenger(new PickUp());
            AddPassenger(new PassengerTrain());
        }
    }
}
