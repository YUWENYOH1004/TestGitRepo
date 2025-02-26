using System;
namespace Shapes2025
{
	public class Circle:Shape
	{
		public double Radius { get; }
		public Circle(string color, double radius): base(color)
		{
			Radius = radius;
		}

        public override double GetArea()
        {
			return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Radius: {Radius}, Area: {GetArea()}";
        }
    }
}

