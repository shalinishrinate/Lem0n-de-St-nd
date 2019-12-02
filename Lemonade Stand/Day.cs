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


        //constructor
        public Day()
        {
            weather = new Weather();
            CreateCustomerWalkIns();
            CreateCustomers();

        }

        //member method

        

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
