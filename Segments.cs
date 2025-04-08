using System;
namespace Assignment_6
{
	public class Segments
	{
        public int CountSegments(string s)
        {
            int sum = 0;
            
              
            return sum;

    }
}

public int CountSegments(string s)
{
    int sum = 0;
    bool inSegment = false;

    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] != ' ' && !inSegment)
        {
            sum++;
            inSegment = true;  // We've started a new word
        }
        else if (s[i] == ' ')
        {
            inSegment = false;  // We are no longer in a word
        }
    }

    return sum;
}
