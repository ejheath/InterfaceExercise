using System;
namespace InterfaceExercise
{
    public class SUV: IVehicle, ICompany
    {
        public int WheelCount { get; set; } = 4;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Explorer";
        public string HornSound { get; set; } = "Merrp";
        public string CompanyName { get; set; } = "Ford";
        public int AnnualProfits { get; set; } = 60000000;

        public bool FourWheelDrive = true;
        public int NumberOfSeats = 7;
    }
}
