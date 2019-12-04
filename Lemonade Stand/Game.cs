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
        public List<Day> days = new List<Day>();
        public Store store;
        public Pitcher pitcher;
        public Weather weather;
        public int currentDay;
        public Recipe recipe;
        public Inventory inventory;
        public double transactionAmount;
        public Customer customer;



        // constructor
        public Game()
        {
            rnd = new Random();
            store = new Store();
            player = new Player();
            recipe = new Recipe();
           // customer = new Customer();
            pitcher = new Pitcher();
        }


        //methods

        public void RunGame()
        {
            UserInterface.DisplayGameIntroduction(); // put it here so that it does not display everyday of game playing.
            CreateDays();
            PlayFor7Days();
        }

        public void PlayFor7Days()
        {
            for (int i = 0; i < 7; i++)
            {
                days[i].RunDay(player, store, inventory, recipe, transactionAmount, customer);
            }
            EndOf7DaysOfGame();
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

        public void EndOf7DaysOfGame()
        {
            Console.WriteLine("Hope you had fun playing 7 days of Lemonade Stand!");
            PlayAnotherGame();
        }

        public void PlayAnotherGame()
        {
            Console.WriteLine("Press 1 to play again,or " +
                              "press any other key to quit.");
            string UserInput = Console.ReadLine();
            switch (UserInput)
            {
                case "1":
                    Console.WriteLine("Good to see you play again.");
                    PlayFor7Days();
                    break;

                default:
                    Console.WriteLine("Bye! See you soon.");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;

            }
        }
    }
}

