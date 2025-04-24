using System;
namespace Assignment_6
{
    public class LastWord
    {
        public int LengthOfLastWord(string s)
        {
            int length = 0;
            int i = s.Length - 1;

            // Step 1: Skip trailing spaces (like Trim)
            while (i >= 0 && s[i] == ' ')
            {
                i--;
            }

            // Step 2: Count characters in the last word
            while (i >= 0 && s[i] != ' ')
            {
                length++;
                i--;
            }

            return length;
        }
    }
}