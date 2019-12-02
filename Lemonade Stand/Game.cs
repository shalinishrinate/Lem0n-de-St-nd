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
        public Store store;
        public Pitcher pitcher;
        public Weather weather;
        public int currentDay;
        public Recipe recipe;
        public Inventory inventory;



        // constructor
        public Game()
        {
            store = new Store();
            player = new Player();
            recipe = new Recipe();
            inventory = new Inventory();
            pitcher = new Pitcher();
            weather = new Weather();

            
        }


        //methods

        public void RunGame()  // master method
        {
            DisplayGameIntroduction();
            store.SellLemons(player);
            store.SellSugarCubes(player);
            store.SellIceCubes(player);
            store.SellCups(player);
            player.recipe.PricePerCup();
            recipe.AmountOfLemons();
            recipe.AmountOfSugarCubes();
            recipe.AmountOfIceCubes();
            pitcher.CreatePitcher(inventory,recipe);
            weather.CreateWeatherConditions();
            weather.CreateTemperature();


           

        }

        public void CreateDays()
        {

            days = new List<Day>();

            Day day = new Day();

            for (int i = 0; i <= 7; i++)
            {
                day = new Day();

                days.Add(day);

            }
        }






            public void DisplayGameIntroduction()
        {
            Console.WriteLine("Welcome! We are so happy to see to come and play LEMONADE STAND");

            Console.WriteLine("Your goal is to make as much money as you can in 7 days by selling " +
                               "lemonade at your lemonade stand.");

            Console.WriteLine("You will be given $20 at the beginning to go buy the inventory");
            
            Console.WriteLine("You get to decide your recipe for that special lemonade you want.");

            Console.WriteLine("Do remember that weather conditions and temperature plays " +
                              "a big role in detemining the number of potential customers.");

            Console.WriteLine("At the end of the game, you'll see how much money you made. ");

            Console.WriteLine("Want to better your last score, play again!");


        }
    }
}
