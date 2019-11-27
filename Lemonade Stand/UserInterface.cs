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
            double pricePerCup = Convert.ToInt32(Console.ReadLine());
            return pricePerCup;
        }
    }
}
