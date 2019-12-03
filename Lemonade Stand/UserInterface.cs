using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    static class UserInterface
    {
        
        public static int GetNumberOfItems(string itemsToGet)
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("How many " + itemsToGet + " would you like to buy?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }

            return quantityOfItem;

        }

        public static int AmountOfLemons()
        {
            Console.WriteLine("Please enter how many lemons would you like in your recipe?");
            int amountofLemons = Convert.ToInt32(Console.ReadLine());
            return amountofLemons;
        }

        public static int AmountOfSugarCubes()
        {
            Console.WriteLine("Please enter how many sugar cubes would you like in your recipe?");
            int amountofSugarCubes = Convert.ToInt32(Console.ReadLine());
            return amountofSugarCubes;
        }

        public static int AmountOfIceCubes()
        {
            Console.WriteLine("Please enter how many ice cubes would you like in your recipe?");
            int amountofIceCubes = Convert.ToInt32(Console.ReadLine());
            return amountofIceCubes;
        }

        public static double PricePerCup()
        {
            Console.WriteLine(" Please enter your price per cup.");
            double pricePerCup = Convert.ToDouble(Console.ReadLine());
            return pricePerCup;
        }

        public static void ShowMoney(Player player)
        {
            Console.WriteLine(" You have $" + player.wallet.Money); 
        }



        public static void DisplayGameIntroduction()
        {
            Console.WriteLine("Welcome! We are so happy to see you come and play LEMONADE STAND");

            Console.WriteLine(); // just to separate the lines

            Console.WriteLine("Your goal is to make as much money as you can in 7 days by selling " +
                               "lemonade at your lemonade stand.");
            Console.WriteLine();
            
            Console.WriteLine("You will be given $20 at the beginning to go buy the inventory");

            Console.WriteLine();

            Console.WriteLine("You get to decide your recipe for that special lemonade you want to sell.");

            Console.WriteLine();

            Console.WriteLine("Do remember that weather conditions and temperature play " +
                              "a big role in detemining the number of potential customers.");

            Console.WriteLine();

            Console.WriteLine("At the end of the game, you'll see how much money you made. ");

            Console.WriteLine();

            //Console.WriteLine("Want to better your last score, play again!");
        
        }

    }
}
