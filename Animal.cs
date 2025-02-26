using System;
namespace Animals2025
{ 
	public class Animal
	{
        public string Name { get; set; }

        public Animal(string name)
		{
			Name = name;
		}

		public virtual string MakeSound()
        {
            return "Some generic animal sound";
        }

        public override string ToString()
        {
            return $"Animal: {Name}, Sound: {MakeSound()}";
        }
    }
}

