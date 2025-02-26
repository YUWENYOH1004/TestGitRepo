using System;
namespace Shapes2025
{
	public class Rectangle:Shape
	{
		public double Width { get; }
		public double Lenght { get; }

		public Rectangle(string color, double width, double lenght): base(color)
		{
			Width = width;
			Lenght = lenght;
		}

		public override double GetArea()
		{
			return Width * Lenght;
		}

        public override string ToString()
        {
            return $"{base.ToString()}, Lenght: {Lenght}, Width: {Width}, Area: {GetArea()}";
        }
    }
}

