using System;
namespace STRINGS
{
	public class Order
	{
        public static string IsInOrder(string word)
        {
            List<char> Words = new List<char>(word);

            Words.Sort();
            string sortedWord = new string(Words.ToArray());

            if (sortedWord == word)
                return "true";
            else
                return "false";


        }
          

    }

}


