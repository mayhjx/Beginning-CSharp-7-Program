using System;

namespace Ch09Ex94
{
    public abstract class Vehicles
    {

    }

    public interface IPassengerCarrier
    {

    }

    public interface IHeavyLoadCarrier
    {

    }

    public class Car : Vehicles
    {

    }

    public class Train : Vehicles
    {

    }

    public class Compact : Car, IPassengerCarrier
    {

    }

    public class SUV : Car, IPassengerCarrier
    {

    }

    public class PickUp : Car, IHeavyLoadCarrier, IPassengerCarrier
    {

    }

    public class PassengerTrain : Train, IPassengerCarrier
    {

    }

    public class FreightTrain : Train, IHeavyLoadCarrier
    {

    }

    public class _424DoubleBogery : Train
    {

    }
}
