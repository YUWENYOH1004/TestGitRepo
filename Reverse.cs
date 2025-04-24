﻿using System;
namespace Assignment_6
{
	public class Reverse
	{
         public void ReverseString(char[] s)
            {
                int left = 0;
                int right = s.Length - 1;

                while (left < right)
                {
                    // Swap characters
                    char temp = s[left];
                    s[left] = s[right];
                    s[right] = temp;

                    left++;
                    right--;
                }
            
         }

    }
}

