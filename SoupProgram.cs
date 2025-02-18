using System;
using SimulaSoup;
using SoupMakerApp;

namespace SoupMakerApp
{
    // 3. Main program class to handle user input and interaction
    class Program
    {
        // 4. Method to get user input for food type
        static FoodType GetFoodTypeChoice()
        {
            Console.WriteLine("Choose the type of dish (Soup, Stew, Gumbo):");
            Console.WriteLine("1. Soup");
            Console.WriteLine("2. Stew");
            Console.WriteLine("3. Gumbo");
            int choice = int.Parse(Console.ReadLine()) - 1;
            return (FoodType)choice;
        }

        // 5. Method to get user input for main ingredient
        static Ingredient GetMainIngredientChoice()
        {
            Console.WriteLine("Choose the main ingredient (Mushrooms, Chicken, Carrots, Potatoes):");
            Console.WriteLine("1. Mushrooms");
            Console.WriteLine("2. Chicken");
            Console.WriteLine("3. Carrots");
            Console.WriteLine("4. Potatoes");
            int choice = int.Parse(Console.ReadLine()) - 1;
            return (Ingredient)choice;
        }

        // 6. Method to get user input for seasoning
        static Seasoning GetSeasoningChoice()
        {
            Console.WriteLine("Choose the seasoning (Spicy, Salty, Sweet):");
            Console.WriteLine("1. Spicy");
            Console.WriteLine("2. Salty");
            Console.WriteLine("3. Sweet");
            int choice = int.Parse(Console.ReadLine()) - 1;
            return (Seasoning)choice;
        }

        // 7. Method to process the soup recipe (get input, create soup, and display it)
        static void ProcessSoupRecipe()
        {
            // Create an instance of SoupMaker
            SoupMaker soupMaker = new SoupMaker();

            // Get user input for the type of dish, main ingredient, and seasoning
            FoodType foodType = GetFoodTypeChoice();
            Ingredient mainIngredient = GetMainIngredientChoice();
            Seasoning seasoning = GetSeasoningChoice();

            // Create the soup using the selected choices
            var soupTuple = soupMaker.CreateSoup(foodType, mainIngredient, seasoning);

            // Display the soup recipe
            soupMaker.DisplaySoup(soupTuple);
        }

        static void Main(string[] args)
        {
            // 8. Call the method to process the soup recipe
            ProcessSoupRecipe();
        }
    }
}

