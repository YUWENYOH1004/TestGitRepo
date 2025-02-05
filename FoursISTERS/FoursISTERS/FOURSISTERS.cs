namespace FoursISTERS;
class Program
{
    static void Main(string[] args)
    {

        // collecting user input
        Console.Write("how amny eggs are there? ");
        int eggs = int.Parse(Console.ReadLine());

        // calculating each persons share to display

        int eggpersistser = eggs / 4;
        int duckbear = eggs % 4;

        Console.WriteLine("each sister gets " + eggpersistser);

        Console.WriteLine("the duckbear gets " + duckbear);
    }
}

