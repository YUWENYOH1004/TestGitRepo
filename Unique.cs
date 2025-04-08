using System;
namespace Assignment_6
{
	public class Unique
	{
        public class Solution
        {
            public int FirstUniqChar(string s)
            {
                int[] freq = new int[26]; // Array to count occurrences of each character (a-z)

                // First pass: Count frequencies of characters
                foreach (char c in s)
                {
                    freq[c - 'a']++;
                }

                // Second pass: Find the first character with frequency 1
                for (int i = 0; i < s.Length; i++)
                {
                    if (freq[s[i] - 'a'] == 1)
                    {
                        return i;  // Return the index of the first non-repeating character
                    }
                }

                return -1;  // If no non-repeating character is found
            }
        }

    }
}

