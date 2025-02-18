
using System;
namespace BossBattle
{
    public class GameLogic
    {
        private int manticoreHealth = 10;
        private int cityHealth = 15;
        private int rounds = 1;
        private int distance;

        public GameLogic(int distance)
        {
            this.distance = distance;
        }

        public void StartGame()
        {
            while (cityHealth > 0 && manticoreHealth > 0)
            {
                Console.WriteLine("\n-----------------------------------------------------------");
                Console.WriteLine($"STATUS: Round: {rounds} City: {cityHealth}/15 Manticore: {manticoreHealth}/10");


                int damage = 1;

                if (rounds % 3 == 0 || rounds % 5 == 0)
                {
                    damage = 3;
                    Console.WriteLine($"The canon is expected to deal {damage} this round.");
                    manticoreHealth -= 3;
                    cityHealth -= 1;

                }
                else if (rounds % 3 == 0 && rounds % 5 == 0)
                {
                    damage = 10;
                    Console.WriteLine($"The canon is expected to deal {damage} this round.");
                    manticoreHealth -= 10;
                    cityHealth -= 1;
                }
                else
                {
                    damage = 1;
                    Console.WriteLine($"The canon is expected to deal {damage} this round.");
                    manticoreHealth -= 1;
                    cityHealth -= 1;
                }

                Console.Write("Enter desired canonrange: ");
                int canonRange = int.Parse(Console.ReadLine());

                if (canonRange == distance)
                {
                    manticoreHealth = 0;
                    Console.WriteLine("That round was a DIRECT HIT!");
                }
                else if (canonRange > distance)
                {
                    Console.WriteLine("That round OVERSHOT the target.");
                }

                else
                {
                    Console.WriteLine("That round FELL SHORT of the target.");
                }

                Console.WriteLine($"Manticore: {manticoreHealth}/10");
                Console.WriteLine($"STATUS: Round: {rounds} City: {cityHealth}/15");

                rounds++;

                if (cityHealth <= 0)
                {

                    Console.WriteLine("The city has been destroyed!");
                    break;
                }
                if (manticoreHealth <= 0)
                {
                    Console.WriteLine("The manticore has been ddestroyed! The city of Consolas has been saved!");
                    break;
                }
            }


        }
    }
}
