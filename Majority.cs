using System;
namespace Assignment_6
{
	public class Majority
	{
        public int MajorityElement(int[] nums)
        {
            int candidate = nums[0]; // Start with the first number as candidate
            int count = 1;           // We have seen it once

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == candidate)
                {
                    count++; // Same as candidate, increase count
                }
                else
                {
                    count--; // Different from candidate, decrease count
                }

                if (count == 0)
                {
                    // If count goes to 0, choose new candidate
                    candidate = nums[i];
                    count = 1;
                }
            }

            return candidate;
        }
    }
}

