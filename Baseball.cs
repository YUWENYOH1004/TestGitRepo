using System;
namespace Assignment_6
{
    public class Baseball
    {
        public int CalPoints(IList<string> ops)
        {
            Stack<int> stack = new Stack<int>();

            foreach (string op in ops)
            {
                if (op == "C")
                {
                    // Invalidate the previous score (pop the top score)
                    stack.Pop();
                }
                else if (op == "D")
                {
                    // Double the last score and add it to the record
                    stack.Push(stack.Peek() * 2);
                }
                else if (op == "+")
                {
                    // Sum the previous two scores and add to the record
                    int last = stack.Pop();
                    int secondLast = stack.Peek();
                    stack.Push(last); // Push the last score back
                    stack.Push(last + secondLast); // Push the sum of last and second last scores
                }
                else
                {
                    // It's a number, add it to the record
                    stack.Push(int.Parse(op));
                }
            }

            // Sum all the scores in the stack
            int total = 0;
            foreach (int score in stack)
            {
                total += score;
            }

            return total;
        }
    }
}

