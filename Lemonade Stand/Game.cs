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
        Random rnd;
        public List <Day> days = new List<Day>();
        public Store store;
        public Pitcher pitcher;
        public Weather weather;
        public int currentDay;
        public Recipe recipe;
        public Inventory inventory;
        public double transactionAmount;
        
 

        // constructor
        public Game()
        {
            rnd = new Random();
            store = new Store();
            player = new Player();
            recipe = new Recipe();
        
            pitcher = new Pitcher();
 
            

           CreateDays();
        }


        //methods

        public void RunGame()
        {
            for (int i = 0; i < 7; i++)
            {
                days[i].RunDay(player, store,inventory,recipe, transactionAmount);
            }

        }

        public void CreateDays()
        {

            days = new List<Day>();

            Day day = new Day(player, store, rnd);

            for (int i = 0; i <= 7; i++)
            {
                day = new Day(player, store, rnd);

                days.Add(day);

            }
        }
    }
}
