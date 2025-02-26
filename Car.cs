using System;
namespace Vehicles2025
{
	public class Car:Vehicle
	{
		public int NumberofDoors { get; set; }

        public Car(string make, string model, int year, int numberofdoors) : base(make, model, year)
        {
            NumberofDoors = numberofdoors;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, with {NumberofDoors}";
        }
    }
}

