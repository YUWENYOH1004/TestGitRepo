using System;
namespace Assignment_6
{
    public class SortbyArray
    {
        public int[] SortArrayByParity(int[] nums)
        {
            int length = nums.Length;
            int[] array1 = new int[length];
            int j = 0;
            foreach (int i in nums)
            {
                if (i % 2 == 0)
                {
                    array1[j] = i;
                    j += 1;
                }
            }
            foreach (int i in nums)
            {
                if (i % 2 != 0)
                {
                    array1[j] = i;
                    j += 1;
                }

            }
            return array1;
        }

    }
}
