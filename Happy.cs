using System;
namespace Assignment_6
{
	public class Happy
	{
        public bool IsHappy(int n)
        {
            HashSet<int> seen = new HashSet<int>();

            while (n != 1 && !seen.Contains(n))
            {
                seen.Add(n);
                n = GetSumOfSquares(n);
            }

            return n == 1;
        }

        private int GetSumOfSquares(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit * digit;
                number /= 10;
            }
            return sum;
        }
    }
}

