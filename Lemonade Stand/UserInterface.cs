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

        public static int PricePerCup()
        {
            Console.WriteLine(" Please enter your price per cup.");
            int pricePerCup = Convert.ToInt32(Console.ReadLine());
            return pricePerCup;
        }

        public static void ShowMoney(Player player)
        {
            Console.WriteLine(" You have $" + player.wallet.Money); 
        }

        public static void PlayerInventory(Inventory inventory)
        {
            //this should show me/player the inventory of lemons, sugar, ice and cups

            Console.WriteLine("You have " + inventory.lemons.Count + " lemons");

            Console.WriteLine("You have " + inventory.sugarCubes.Count + " sugarcubes");

            Console.WriteLine("You have " + inventory.iceCubes.Count + " icecubes");

            Console.WriteLine("You have " + inventory.cups.Count + " cups");


        }

        //public static void StoreMenu(Store store)
        //{
        //    Console.WriteLine("Please let us know what would you like to buy?\n" +
        //                     "Please type the item you would like to buy today.\n" +
        //                     "Lemons, Sugar, Cubes, Cups.\n" +
        //                     "Enter quit to exit game.");

        //    string storeItemsToBuy = Console.ReadLine().ToLower();

        //    switch (storeItemsToBuy)
        //    {
        //        case "lemons":
        //            Console.WriteLine("The cost of Lemons is $ " + store.PricePerLemon + " per piece.");
        //            break;
        //        case "sugar":
        //            Console.WriteLine("The cost of SugarCubes is $ " + store.PricePerSugarCube + " per piece.");
        //            break;
        //        case "cubes":
        //            Console.WriteLine("The cost of IceCubes is $ " + store.PricePerIceCube + " per piece.");
        //            break;
        //        case "cups":
        //            Console.WriteLine("The cost of Cups is $ " + store.PricePerCup + " per piece.");
        //            break;
        //        case "quit":
        //            Environment.Exit(0);
        //            break;
        //        default:
        //            Console.WriteLine("Please enter a valid item");
        //            break;
        //    }

        //}

        public static void DisplayGameIntroduction()
        {
            Console.WriteLine("Welcome! We are so happy to see you come and play LEMONADE STAND");

            Console.WriteLine("Your goal is to make as much money as you can in 7 days by selling " +
                               "lemonade at your lemonade stand.");

            Console.WriteLine("You will be given $20 at the beginning to go buy the inventory");

            Console.WriteLine("You get to decide your recipe for that special lemonade you want to sell.");

            Console.WriteLine("Do remember that weather conditions and temperature play " +
                              "a big role in detemining the number of potential customers.");

            Console.WriteLine("At the end of the game, you'll see how much money you made. ");

            //Console.WriteLine("Want to better your last score, play again!");
        
        }

    }
}
