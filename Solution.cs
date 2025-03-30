using System;
namespace Assignment_6
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            for (int i = 0; i < nums2.Length; i++)
            {
                nums1[m] = nums2[i];
                m += 1;
            }
            Array.Sort(nums1);
        }
    }
  