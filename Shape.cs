using System;
namespace Shapes2025
{
	public abstract class Shape
	{
		public string Color { get; }

		public Shape(string color)
		{
			Color = color;
		}

		public abstract double GetArea();

        public override string ToString()
        {
            return $"{Color} Shape";
        }
    }
}

