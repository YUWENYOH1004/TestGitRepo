﻿using System;
namespace Assignment_6
{
    public class Pivot
    {
        public int PivotIndex(int[] nums)
        {
            int totalSum = 0;
            foreach (int num in nums)
            {
                totalSum += num;
            }

            int leftSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int rightSum = totalSum - leftSum - nums[i];

                if (leftSum == rightSum)
                {
                    return i; // Found pivot
                }

                leftSum += nums[i];
            }

            return -1; // No pivot index found
        }
    }
}