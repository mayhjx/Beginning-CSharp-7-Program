﻿using System;

namespace Ch12Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm<Animal> farm = new Farm<Animal>();
            farm.Animals.Add(new Cow("Rual"));
            farm.Animals.Add(new Chicken("Donna"));
            farm.Animals.Add(new Chicken("Mary"));
            farm.Animals.Add(new SuperCow("Ben"));

            farm.MakeNoises();

            Farm<Cow> dairyFarm = farm.GetSpecies<Cow>();
            dairyFarm.FeedTheAnimals();

            foreach(Cow cow in dairyFarm)
            {
                if(cow is SuperCow)
                {
                    (cow as SuperCow).Fly();
                }
            }
        }
    }
}
