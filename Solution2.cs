using System;
namespace Assignment_6
{
    using System.Collections.Generic;

    public class Solution2
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            Queue<int> queue = new Queue<int>(students);
            int index = 0; // index for sandwiches
            int attempts = 0;

            while (queue.Count > 0 && attempts < queue.Count)
            {
                if (queue.Peek() == sandwiches[index])
                {
                    queue.Dequeue();
                    index++;
                    attempts = 0; // reset attempts
                }
                else
                {
                    queue.Enqueue(queue.Dequeue());
                    attempts++;
                }
            }

            return queue.Count;
        }
    }
}

