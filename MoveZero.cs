using System;
namespace Assignment_6
{
	public class MoveZero
	{
        public void MoveZeroes(int[] nums)
        {
            int length = nums.Length;
            int j = 0;

            // Move non-zero elements forward
            for (int i = 0; i < length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[j] = nums[i];
                    j++;
                }
            }

            // Fill the rest with zeros
            for (int i = j; i < length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}

