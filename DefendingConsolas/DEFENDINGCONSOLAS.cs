using System;

class DefenseOfConsolas
{
    static void Main()
    {
        // Set the console title
        Console.Title = "Defense of Consolas";

        // Ask the user for target row and column
        Console.Write("Target Row? ");
        int targetRow = int.Parse(Console.ReadLine());

        Console.Write("Target Column? ");
        int targetColumn = int.Parse(Console.ReadLine());

        // Deploy to adjacent blocks
        Console.ForegroundColor = ConsoleColor.DarkYellow; 
        Console.WriteLine("Deploy to:");

        // Calculate and display the adjacent block coordinates
        Console.WriteLine($"({targetRow}, {targetColumn - 1})");  
        Console.WriteLine($"({targetRow - 1}, {targetColumn})");  
        Console.WriteLine($"({targetRow}, {targetColumn + 1})");  
        Console.WriteLine($"({targetRow + 1}, {targetColumn})");  

        // Play a beep sound after displaying results
        Console.Beep(440, 1000);
    }
}
