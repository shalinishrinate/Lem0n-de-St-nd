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
            CreateCustomerWalkIns();
            CreateCustomers();

        }

        //member method
        public void RunDay(Player player, Store store, Inventory inventory, Recipe recipe, double transactionAmount)
        {
           UserInterface.DisplayGameIntroduction(); // introducing the game 

            UserInterface.ShowMoney(player); //shows the initial amount 

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

            CreateCustomers();

            //willTheCustomerBuy ???

            DailyIncome(player);
            AddIncomeToWallet(player.wallet);
            DisplayCurrentTotal();

            //typed by Nevin
            //1. Go To Store
            //2. Set Recipe 
            //3. Sell Lemonade
            //4. Staticstics// how much money

            //the earlier version I was I think making things too complicated and not utilising the started code given

            //game.CreateDays();
            //UserInterface.PlayerInventory(player.inventory);
            //UserInterface.StoreMenu(store);
            //player.wallet.PayMoneyForItems(transactionAmount);
            //UserInterface.PlayerInventory(player.inventory); //this should be displayed again to show the latest inventory after store visit
            //weather.DisplayForecast();
            //weather.DisplayActualWeather();
            //player.recipe.CreateRecipe();
            //CreateCustomers();
            //player.pitcher.CreatePitcher(inventory, recipe);
            //SellLemonade();
            //Income();
            // Profit();    // will have to solve this issue tomorrow, otherwise cant progress!!

        }


        public void CreateCustomerWalkIns()
        {
            if (weather.condition == "Dubai Heat")
            {
                customerWalkIns = 20;
            }
            else if (weather.condition == "Delhi Sun")
            {
                customerWalkIns = 40;
            }
            else if (weather.condition == "Barcelona Bliss")
            {
                customerWalkIns = 70;
            }
            else if (weather.condition == "London Cloud")
            {
                customerWalkIns = 60;
            }
            else if (weather.condition == "Chicago Wind")
            {
                customerWalkIns = 50;
            }
            else if (weather.condition == "Wisconsin Cold")
            {
                customerWalkIns = 30;
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

            //profitMade = dailyIncome - /amountSpent/; this is the way profit will be derived but have to figure out where I am getting this value
        }

        // the income should then go back the wallet
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
