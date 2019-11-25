using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        //member variables
        public Player player;

        public List <Day> days = new List<Day>();

        public int currentDay;



        // constructor
        public Game()
        {
            Day day = new Day();
            days.Add(day);
        }


        //methods

        public void RunGame()  // master method
        {
            DisplayGameIntroduction();
            


        }
        public void DisplayGameIntroduction()
        {
            Console.WriteLine("Welcome! We are so happy to see to come and play Lemonade Stand");

            Console.WriteLine("Your goal is to make as much money as you can in 7 days by selling lemonade at your lemonade stand.");

            Console.WriteLine("Buy cups, lemons, sugar, and ice cubes, then set your recipe based on the weather and conditions." +
                                "Start with the basic recipe, but try to vary the recipe and see if you can do better." +
                                "Lastly, set your price and sell your lemonade at the stand. " +
                                "Try changing up the price based on the weather conditions as well.");

            Console.WriteLine("At the end of the game, you'll see how much money you made. "); 
               
            Console.WriteLine("Want to better your last score, play again!");
        }
    }
}
