using System;
using BossBattle;

class Program
{
    static void Main()
    {
        // Player 1 sets the Manticore's distance from the city (between 0 and 100)
        Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
        int distance = int.Parse(Console.ReadLine());
        Console.Clear();
        // Create the game logic object with the chosen Manticore distance
        GameLogic game = new GameLogic(distance);

        // Start the game
        game.StartGame();
    }
}

