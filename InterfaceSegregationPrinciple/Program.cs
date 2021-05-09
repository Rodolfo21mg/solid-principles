using InterfaceSegregationPrinciple.Vehicles;
using System;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car("Azul", 2022, 4.0, 2, 2);
            Motorcycle motorcycle = new Motorcycle("Branca", 2023, 600);

            Console.ReadLine();

        }
    }
}
