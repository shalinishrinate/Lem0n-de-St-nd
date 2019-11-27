using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Pitcher
    {
        int cupsLeftInPitcher;


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
        // index Int32 : The zero - based starting index of the range of elements to remove.
        //in this case it should be the inventory.

        //count Int32 : The number of elements to remove.
        //in this case it should be amountof lemons etc mentioned in the recipe.

        {
            inventory.lemons.RemoveRange(0, recipe.amountOfLemons);
            inventory.sugarCubes.RemoveRange(0, recipe.amountOfSugarCubes);
            inventory.iceCubes.RemoveRange(0, recipe.amountOfIceCubes);

            //while playing this game on coolmathgames, it mentioned 12 cups make a pitcher,so going by it
            cupsLeftInPitcher = 12;

        }


    }
}
