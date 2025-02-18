using System;
using SoupMakerApp;

namespace SimulaSoup
{
    public enum FoodType
    {
        soup,
        stew,
        gumbo
    }
    public enum Ingredient
    {
        mushrooms,
        chicken,
        carrots,
        potatoes
    }
    public enum Seasoning
    {
        spicy,
        salty,
        sweet
    }

    class SoupMaker
    {
        public (FoodType, Ingredient, Seasoning) CreateSoup(FoodType foodType, Ingredient mainIngredient, Seasoning seasoning)
        {
            return (foodType, mainIngredient, seasoning);
        }

        public void DisplaySoup((FoodType, Ingredient, Seasoning) soupTuple)
        {
            // Display the soup recipe in the required format
            Console.WriteLine($"\nYour soup recipe is: {soupTuple.Item3} {soupTuple.Item2} {soupTuple.Item1}");
        }
    }

}

