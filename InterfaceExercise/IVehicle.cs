using System;
namespace InterfaceExercise
{
    public interface IVehicle : ICompany
    {
        public int WheelCount { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string HornSound { get; set; }

    }
}
