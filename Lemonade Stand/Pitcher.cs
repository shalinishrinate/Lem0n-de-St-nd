using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Pitcher
    {
        public int cupsLeftInPitcher;
        int remainingLemons;
        int remainingSugarCubes;
        int remainingIceCubes;
        int remainingCups;


        //constructor
        public Pitcher()
        {
            cupsLeftInPitcher = 0;
        }

        //member method

        public void CreatePitcher(Inventory inventory , Recipe recipe)

        //List<T>.RemoveRange(Int32, Int32) Method
        //Removes a range of elements from the List< T >.

        //public void RemoveRange(int index, int count);
        // index Int32 : The zero - based starting index of the range of elements to remove.in this case it should be the inventory.

        //count Int32 : The number of elements to remove.
        //in this case it should be amountof lemons etc mentioned in the recipe.

        {
            inventory.lemons.RemoveRange(0, recipe.amountOfLemons);
            inventory.sugarCubes.RemoveRange(0, recipe.amountOfSugarCubes);
            inventory.iceCubes.RemoveRange(0, recipe.amountOfIceCubes);

            cupsLeftInPitcher = 12; //while playing this game on coolmathgames, it mentioned 12 cups make a pitcher,so going by it

        }

        public void RefillPitcher(Inventory inventory, Recipe recipe, Store store, Player player, Day day)
        {
            if (inventory.lemons.Count < recipe.amountOfLemons)
            {
                Console.WriteLine("Uh-ho.. you have run out of lemons.");
            }

            else if (inventory.sugarCubes.Count < recipe.amountOfSugarCubes)
            {
                Console.WriteLine("Uh-ho.. you have run out of sugar cubes.");
            }

            else if (inventory.iceCubes.Count < recipe.amountOfIceCubes)
            {
                Console.WriteLine("Uh-ho.. you have run out of ice cubes.");
            }
            
            else
            {
                CreatePitcher(inventory, recipe);
            }
            
        }

        public void DisplayLeftoverInventory(Inventory inventory)
        { 
            remainingLemons = inventory.lemons.Count();
            remainingSugarCubes = inventory.sugarCubes.Count();
            remainingIceCubes = inventory.iceCubes.Count();                   
            remainingCups = inventory.cups.Count();
            Console.WriteLine("You have " + remainingLemons + " lemons, " + remainingSugarCubes + " sugar cubes, " + remainingIceCubes + " ice cubes and " + remainingCups + "cups in your inventory.");
        }


    }
}
