using System;
namespace Assignment_6
{
    public class Balloons
    {
        public int MaxNumberOfBalloons(string text)
        {
            // Create an array to count letters (assuming lowercase English letters)
            int[] count = new int[26];

            // Count each character in the input string
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                count[c - 'a']++;
            }

            // Calculate how many times we can form the word "balloon"
            int b = count['b' - 'a'];
            int a = count['a' - 'a'];
            int l = count['l' - 'a'] / 2;
            int o = count['o' - 'a'] / 2;
            int n = count['n' - 'a'];

            // Return the minimum of all required counts
            int min = b;
            if (a < min) min = a;
            if (l < min) min = l;
            if (o < min) min = o;
            if (n < min) min = n;

            return min;
        }
    }

}
