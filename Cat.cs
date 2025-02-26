using System;
namespace Animals2025
{
	public class Cat:Animal
	{
		public Cat(string name): base(name)
		{
		}

        public override string MakeSound()
        {
            return "Meow";
        }
    }
}

