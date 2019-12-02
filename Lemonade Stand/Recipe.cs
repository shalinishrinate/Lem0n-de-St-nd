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

        public void AmountOfLemons()
        {
            amountOfLemons = UserInterface.AmountOfLemons();
        }

        public void AmountOfSugarCubes()
        {
            amountOfSugarCubes = UserInterface.AmountOfSugarCubes();
        }


        public void AmountOfIceCubes()
        {
            amountOfIceCubes = UserInterface.AmountOfIceCubes();
        }
        
        public void PricePerCup()
        {
            pricePerCup = UserInterface.PricePerCup();
        }

        public void CreateRecipe()
        {
            AmountOfLemons();
            AmountOfSugarCubes();
            AmountOfIceCubes();
            PricePerCup();
        }

    }

}
