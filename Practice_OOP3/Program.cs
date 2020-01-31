using System;

namespace Practice_OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            GasCooktop gasCooktop = new GasCooktop();
            ElectricCooktop electricCooktop = new ElectricCooktop();
            GasOven gasOven = new GasOven();
            ElectricOven electricOven = new ElectricOven();
            GasStove gasStove = new GasStove();
            ElectricStove electricStove = new ElectricStove();


            Console.WriteLine(gasCooktop.Cook());
            Console.WriteLine(electricCooktop.Cook());
            Console.WriteLine(gasOven.Bake());
            Console.WriteLine(electricOven.Bake());
            Console.WriteLine(gasStove.Cook() + gasStove.Bake());
            Console.WriteLine(electricStove.Cook() + electricStove.Bake());       
        }
    }
}
