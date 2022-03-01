using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();


            var truck = new Truck();


            var SUV = new SUV();


            var vehicles = new List<IVehicle>() { car, truck, SUV };

            foreach(var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.HornSound);
                Console.WriteLine(vehicle.Make);
                Console.WriteLine(vehicle.Model);
                Console.WriteLine(vehicle.WheelCount);
                Console.WriteLine(vehicle.AnnualProfits);
                Console.WriteLine(vehicle.CompanyName);


            }
            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
