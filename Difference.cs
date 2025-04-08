using System;
namespace Assignment_6
{
	public class Difference
	{
        public char FindTheDifference(string s, string t)
        {
            {
                // Iterate over each character in strA
                foreach (char letter in t)
                {
                    bool found = false;

                    // Check each character in strB manually
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i] == letter)
                        {
                            found = true;
                            break; // Exit the loop early if the letter is found in strB
                        }
                    }

                    // If the letter from strA was not found in strB, return true
                    if (!found)
                    {
                        return letter; // A letter from strA is absent in strB
                    }
                }

            }
        }
    }
}

