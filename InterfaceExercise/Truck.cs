using System;
namespace InterfaceExercise
{
    public class Truck: IVehicle, ICompany
    {
        public Truck()
        {
        }

        public int WheelCount { get; set; } = 4;
        public string Make { get; set; } = "Tesla";
        public string Model { get; set; } = "Cybertruck";
        public string HornSound { get; set; } = "Beeeeep";
        public string CompanyName { get; set; } = "Capital Elon";
        public int AnnualProfits { get; set; } = 100000000;

        public bool MonsterTruck = false;
        public double TrunkSpace = 10.5;
        //TrunkSpace measured in feet by length
    }
}
