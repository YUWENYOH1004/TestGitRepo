using System;
namespace Assignment_6
{
    public class Element
    {
        public int RemoveElement(int[] nums, int val)
        {
            int x = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[x] = nums[i];
                    x++;
                }

            }
            return x;

        }
    }
}
