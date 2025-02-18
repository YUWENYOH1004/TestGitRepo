// ankinimbom yuwenyoh
using System;
namespace VinFletchers;

class Program
{
    static void Main()
    {

        Console.WriteLine("Enter the arrowhead type (Steel, Wood, Obsidian):");
        string arrowhead = Console.ReadLine();

        Console.WriteLine("Enter the fletching type (Plastic, TurkeyFeathers, GooseFeathers):");
        string fletching = Console.ReadLine();

        Console.WriteLine("Enter the shaft length (between 60 and 100 cm):");
        float shaftLength = float.Parse(Console.ReadLine());


        Arrow arrow = new Arrow(arrowhead, fletching, shaftLength);


        float cost = arrow.GetCost();
        Console.WriteLine($"The cost of your arrow is: {cost} gold.");
    }
}