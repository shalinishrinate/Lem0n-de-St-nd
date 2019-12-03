using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        //member variables

        public string name;

        public List<string> names = new List<string>()
        {
            "Messi","Pique","Suarez","Umtiti","Griezmann","De Jong","Dembele","Vidal","Perez","Rakitic",
            "Ter Stegen","Busquets","Alba","Lenglet","Semedo","Roberto","Rodriguez"
        };

        int customerLemonPreferance;
        int customerSugarCubePreferance;
        int customerIceCubePreferance;
        int customerTempPreferance;
        //int customerPricePreferance;

        public Customer()
        { 

            CreateName();
        }

        //member methods

        public void CreateName()
        {
            Random namePicking = new Random();
            int potentialNames = namePicking.Next(0, 17);
            name = names[potentialNames];
        }

        public void CustomerLemonPreferance()
        {
            Console.WriteLine("How many lemons would you prefer in your cup?");
            customerLemonPreferance = int.Parse(Console.ReadLine());
        }

        public void CustomerSugarCubePreferance()
        {
            Console.WriteLine("How many Sugar cubes would you prefer in your cup?");
            customerSugarCubePreferance = int.Parse(Console.ReadLine());
        }

        public void CustomerIceCubesPreferance()
        {
            Console.WriteLine("How many Ice cubes would you prefer in your cup?");
            customerIceCubePreferance = int.Parse(Console.ReadLine());
        }

        public void CustomerTempPreferance()
        {
            Console.WriteLine("What is the temperature that best suits your likelihood to buy lemonade?");
            customerTempPreferance = int.Parse(Console.ReadLine());

        }



                 //public void CustomerPricePreferance()
                 //{
                    //    Console.WriteLine("What is the ideal price you will pay for lemonade?");
                    //    customerPricePreferance = int.Parse(Console.ReadLine());
                // 
                //    not sure now if this the right way to get input, the input 

        

        public bool WillTheCustomerBuyLemonade(Recipe recipe, Weather weather)
        {
            if (recipe.amountOfLemons >= customerLemonPreferance &&
                recipe.amountOfSugarCubes >= customerSugarCubePreferance &&
                recipe.amountOfIceCubes >= customerIceCubePreferance &&
                (weather.temperature >= customerTempPreferance - 5 ||
                weather.temperature <= customerTempPreferance + 5))
            {
                return true;
            }
            return false;
        }

        
    }
}
