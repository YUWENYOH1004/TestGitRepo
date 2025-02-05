// ANKINIMBOM YUWENYOH
// 02/03/2025

namespace BuyingInventory;
class BuyingInventory
{
    // the list of equipments used for refernce in the following code
    /*1 – Rope
    2 – Torches
    3 – Climbing Equipment
    4 – Clean Water
    5 – Machete
    6 – Canoe
    7 – Food Supplies*/

    static void Main(string[] args)
    {
        Console.Write("What number do you want to see the price of : ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Rope costs 10 gold.");
                break;
            case 2:
                Console.WriteLine("Torches cost 16 gold.");
                break;
            case 3:
                Console.WriteLine("Climbing Equipment costs 24 gold.");
                break;
            case 4:
                Console.WriteLine("Clean Water costs 2 gold.");
                break;
            case 5:
                Console.WriteLine("Machete costs 20 gold.");
                break;
            case 6:
                Console.WriteLine("Canoe costs 200 gold.");
                break;
            case 7:
                Console.WriteLine("Food Supplies cost 2 gold.");
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a number between 1 and 7.");
                break;

        }
    }
}

