using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public int WheelCount { get; set; } = 4;
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Camry";
        public string HornSound { get; set; } = "weak";
        public string CompanyName { get; set; } = "Toyota";
        public int AnnualProfits { get; set; } = 25000;
    }
}
