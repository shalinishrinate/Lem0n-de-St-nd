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


        //constructor
        public Day()
        {
            weather = new Weather();
            CreateCustomerWalkIns();
            CreateCustomers();
            

        }

        //member method
        public void RunDay()
        {
            //1. Go To Store
            //1.5 
            //2. Set Recipe 
            //3. Sell Lemonade
            //4. Staticstics// how much money

           

            game.DisplayGameIntroduction();
            UserInterface.ShowMoney(player);
            UserInterface.PlayerInventory(inventory);
            UserInterface.StoreMenu();
            recipe.CreateRecipe();
            Store.SellLemons();
            Store.
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
    }
}
