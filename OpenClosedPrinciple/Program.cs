using OpenClosedPrinciple.Vehicles;
using System;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {

            ETypeVehicle type = TypeVehicle.CAR;

            if (type == TypeVehicle.CAR)
            {

                Car vehicle = new Car("Azul", 2022, 2.0, 5, 4);

            } else
            {

                Motorcycle vehicle = new Motorcycle("Branco", 2023, 250);

            }

            Console.ReadLine();
                

        }
    }
}
