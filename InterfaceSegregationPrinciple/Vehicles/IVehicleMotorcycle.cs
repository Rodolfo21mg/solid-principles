﻿

namespace InterfaceSegregationPrinciple.Vehicles
{
    interface IVehicleMotorcycle : IVehicle
    {
        void ConfigureMotorcycle(string color, int year, double engine);
    }
}
