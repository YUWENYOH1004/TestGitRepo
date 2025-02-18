using System;
namespace STRINGS
{
	public class Vowels
	{
		public static string CountVowel(string sentence, int n)
		{
			string vowels = "aeiou";
			sentence.ToLower();
			string answer = "";
			foreach (char letter in sentence)
			{
				if (vowels.Contains(letter))
				{
					answer += letter;
				}
				
			}
			if (n > answer.Length)
				return "invalid";

			return $"{sentence},{n} = {answer}";
		}


	}
}

