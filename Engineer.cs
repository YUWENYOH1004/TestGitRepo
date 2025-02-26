using System;
namespace Employees2025
{
	public class Engineer:Employee
	{
		public string Specialisation { get; set; }
		public Engineer(string name, int salary, string specialisation): base(name, salary, specialisation)
		{
			Specialisation = specialisation;
		}

        public override string ToString()
        {
			return $"{base.ToString()}, Specialisation: {Specialisation}";
        }
    }
}

