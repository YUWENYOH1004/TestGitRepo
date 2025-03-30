using System;
namespace Assignment_6
{
	public class TwoSum2025
	{
        public int[] TwoSum(int[] nums, int target)
        {
            int[] value = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        value[0] = i;
                        value[1] = j;
                    }
                }
            }
            return value;
        }



    }
}

