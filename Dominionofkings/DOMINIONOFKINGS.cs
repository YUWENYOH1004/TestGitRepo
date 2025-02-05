namespace Dominionofkings;
class Program
{
    static void Main(string[] args)
    {
        // retrieving user inputs.
        Console.Write("enter the number of estates: ");
        int estates = int.Parse(Console.ReadLine());

        Console.Write("enter the number of duchies: ");
        int duchies = int.Parse(Console.ReadLine());

        Console.Write("enter the number of provinces: ");
        int provinces = int.Parse(Console.ReadLine());

     


        int Total = (estates * 1) + (duchies * 3) + (provinces * 6);

        Console.WriteLine("your total points are: " + Total + " points");


    }
}

