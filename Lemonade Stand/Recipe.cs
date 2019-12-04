using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        //member variables
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;

        //constructor
        public Recipe()
        {
            amountOfLemons = 0;
            amountOfSugarCubes = 0;
            amountOfIceCubes = 0;
            pricePerCup = 0;

        }

        //member method

        public void AmountOfLemons(Inventory inventory)
        {
            amountOfLemons = UserInterface.AmountOfLemons();

            if (amountOfLemons > inventory.lemons.Count)
            {
                Console.WriteLine("Sorry but you do not have enough number of lemons in your inventory. Please type an amount equal or less than what you bought.");
            }

            else
            {
                Console.WriteLine("You have now added " + amountOfLemons + " lemons to your recipe.");
            }
        }

        public void AmountOfSugarCubes(Inventory inventory)
        {
            amountOfSugarCubes = UserInterface.AmountOfSugarCubes();

            if (amountOfSugarCubes > inventory.sugarCubes.Count)
            {
                Console.WriteLine("Sorry but you do not have enough number of sugar cubes in your inventory. Please type an amount equal or less than what you bought.");
            }

            else
            {
                Console.WriteLine("You have now added " + amountOfSugarCubes + " sugar cubes to your recipe.");
            }
        }


        public void AmountOfIceCubes(Inventory inventory)
        {
            amountOfIceCubes = UserInterface.AmountOfIceCubes();

            if (amountOfIceCubes > inventory.iceCubes.Count)
            {
                Console.WriteLine("Sorry but you do not have enough number of ice cubes in your inventory. Please type an amount equal or less than what you bought.");
            }

            else
            {
                Console.WriteLine("You have now added " + amountOfIceCubes + " ice cubes to your recipe.");
            }
        }
        
        public void PricePerCup()
        {
            pricePerCup = UserInterface.PricePerCup();
        }

   

    }

}
