using System;
namespace Vehicles2025
{
	public class Motorcycle:Vehicle
	{
		public bool HasSidecar { get; set; }
		public Motorcycle(string make, string model, int year, bool asidecar) : base(make, model, year)
		{
			HasSidecar = true;
		}

        public override string ToString()
        {
			return $"{base.ToString()}, (Has Sidecar: {HasSidecar}";

		}

    }
}

