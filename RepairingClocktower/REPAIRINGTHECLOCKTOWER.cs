namespace RepairingClocktower;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int Number = int.Parse(Console.ReadLine());

        if (Number % 2 == 0)
        {
            Console.WriteLine("DING!");
        }
        else
        {
            Console.WriteLine("DONG!");
        }

    }
}

