using System;
namespace Assignment_6
{
	public class Moves
	{
        public bool JudgeCircle(string moves)
        {
            int x = 0, y = 0;
            foreach (char move in moves)
            {
                if (move == 'U') y++; // Move up (increase y)
                else if (move == 'D') y--; // Move down (decrease y)
                else if (move == 'L') x--; // Move left (decrease x)
                else if (move == 'R') x++; // Move right (increase x)
            }
            bool result = false;
            if (x == 0 && y == 0)
                result = !result;

            return result;
        }
    }
}


