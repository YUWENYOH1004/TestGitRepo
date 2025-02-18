using System;
namespace STRINGS
{
	public class Alphabet
	{
        public static string Move(string input)
        {
            string result = "";


            foreach (char c in input)
            {

                if (char.IsLetter(c))
                {
                    result += (char)(c + 1);
                }
            }

            return result;
        }

    }
}

