using System;
using System.Linq;
namespace STRINGS
{
	public class flipping
	{
		public static string flipEnd(string sentence)
		{

            if (sentence.Length < 2)
            {
                return "Incompatible.";
            }
            if (sentence[0] == sentence[sentence.Length-1])
            {
                return "Two's a pair.";
            }

            char first = sentence[0];
            char last = sentence[sentence.Length-1];
            string middle = "";

            foreach (var i in Enumerable.Range(1, sentence.Length-2))
            {
                middle += sentence[i];
            }

            return $"{last}{middle}{first}";
        }
	}
}

