using System;
namespace Employees2025
{
	public class Employee
	{
		public string Name { get; set; }
		public int Salary { get; set; }

		public Employee(string name, int salary)
		{
			Name = name;
			Salary = salary;
		}

        public override string ToString()
        {
			return $"Employee: {Name}, Salary: ${Salary}";

		}
    }
}

