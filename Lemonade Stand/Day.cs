using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        //member variable

        public Weather weather;
        public List<Customer> customers;
        public int customerWalkIns;
        public Recipe recipe;
        public Game game;
        public double dailyIncome;
        public double numberOfCustomersWhoBought;
        public double profitMade;
        public double walletTotal;
        public int customer;


        //constructor
        public Day(Player player, Store store, Random rnd)
        {
            weather = new Weather(rnd);
            
        }

        //member method
        public void RunDay(Player player, Store store, Inventory inventory, Recipe recipe, double transactionAmount, Customer customer)
        {
           
           
            store.SellLemons(player); // player buys inventory from the store
            store.SellSugarCubes(player);
            store.SellIceCubes(player);
            store.SellCups(player);

            player.wallet.PayMoneyForItems(transactionAmount); // pays for the things bought above

            player.wallet.DisplayBalanceMoney(); // it should now how much money is left

            weather.DisplayForecast(); // based on the forecast recipe is made
            
            player.recipe.AmountOfLemons(player.inventory); // changed it from earlier version, as i had not accounted for the fact, what if the amount filled in the recipe is more than what is available in the inventory.
            player.recipe.AmountOfSugarCubes(player.inventory);
            player.recipe.AmountOfIceCubes(player.inventory);
            player.recipe.PricePerCup();

            player.pitcher.CreatePitcher(player.inventory, player.recipe);

            weather.DisplayActualWeather(); // now based on the actual weather customers will walk in

            CreateCustomerWalkIns();
            CreateCustomers();


            //sell lemonade

            DailyIncome(player);
            AddIncomeToWallet(player.wallet);
            DisplayCurrentTotal();

        }

        public void CreateCustomerWalkIns()
        {
            if (weather.condition == "Dubai Heat")
            {
                customerWalkIns = 20;
                Console.WriteLine("The number of potential customers walking around are " + customerWalkIns);
            }
            else if (weather.condition == "Delhi Sun")
            {
                customerWalkIns = 40;
                Console.WriteLine("The number of potential customers walking around are " + customerWalkIns);
            }
            else if (weather.condition == "Barcelona Bliss")
            {
                customerWalkIns = 70;
                Console.WriteLine("The number of potential customers walking around are " + customerWalkIns);
            }
            else if (weather.condition == "London Cloud")
            {
                customerWalkIns = 60;
                Console.WriteLine("The number of potential customers walking around are " + customerWalkIns);
            }
            else if (weather.condition == "Chicago Wind")
            {
                customerWalkIns = 50;
                Console.WriteLine("The number of potential customers walking around are " + customerWalkIns);
            }
            else if (weather.condition == "Wisconsin Cold")
            {
                customerWalkIns = 30;
                Console.WriteLine("The number of potential customers walking around are " + customerWalkIns);
            }
            
        }
        
        public void CreateCustomers()
        {
            customers = new List<Customer>();

            for (int i = 0; i < customerWalkIns; i++)
            {
                Customer customer = new Customer();
                customers.Add(customer);
                
            }
            
        }


        public void DailyIncome(Player player)
        {
            dailyIncome = customer * player.recipe.pricePerCup;

            Console.WriteLine("Your income for today is " + dailyIncome);

        }

        public void AddIncomeToWallet(Wallet wallet)
        {
            walletTotal = wallet.Money + dailyIncome;
        }

        public void DisplayCurrentTotal()
        {
            Console.WriteLine("You now have " + walletTotal + " in your wallet.");
        }
    }
}
