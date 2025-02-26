using System;
namespace Employees2025
{
	public class Manager
	{
		public int NumberofEmployeesManaged { get; set; }
		public Manager(string name, int salary, int numberofemployees): base(name, salary, numberofemployees)
		{
			NumberofEmployeesManaged = numberofemployees;
		}

        public override string ToString()
        {
			return $"{base.ToString()}, Number of employees managed: {NumberofEmployeesManaged}" ;
        }
    }
}

