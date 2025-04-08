using System;
using System.Text;

namespace Assignment_6
{
	public class StringMerge
	{
        public string MergeAlternately(string word1, string word2)
        {
            int length1 = word1.Length;
            int length2 = word2.Length;
            StringBuilder merged = new StringBuilder();

            // Use two pointers, one for each string
            int i = 0, j = 0;

            // Merge alternately while both strings have remaining characters
            while (i < length1 || j < length2)
            {
                if (i < length1)
                {
                    merged.Append(word1[i]);
                    i++;
                }
                if (j < length2)
                {
                    merged.Append(word2[j]);
                    j++;
                }
            }

            return merged.ToString();
        }
    }
}

