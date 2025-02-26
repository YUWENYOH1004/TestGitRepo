using System;
namespace Vehicles2025
{
	public class Vehicle
    {

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Year} {Make} {Model}";
        }
    
}
}

