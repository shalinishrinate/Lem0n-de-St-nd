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
        public Random random;

        public List<string> names = new List<string>()
        {
            "Messi","Pique","Suarez","Umtiti","Griezmann","De Jong","Dembele","Vidal","Perez","Rakitic",
            "Ter Stegen","Busquets","Alba","Lenglet","Semedo","Roberto","Rodriguez"
        };

        int customerLemonPreferance;
        int customerSugarCubePreferance;
        int customerIceCubePreferance;
        int customerTemperaturePreferance;
        double customerPricePreferance;

        public Customer()
        {
        }

        public Customer(Random rnd)
        {
            random = rnd;
            CreateName();
            CustomerPreferences();
        }

        //member methods

        public void CreateName()
        {
            
            int potentialNames = random.Next(0, 17);
            name = names[potentialNames];
        }

        public void CustomerPreferences() // instead of asking questions, randomly generating preferance now.
        {
            customerLemonPreferance = random.Next(1, 11);
            customerIceCubePreferance = random.Next(1, 11);
            customerSugarCubePreferance = random.Next(1, 31);
            customerTemperaturePreferance = random.Next(20, 141);
            customerPricePreferance = random.Next(10,100); 
        }
        
        public bool WillTheCustomerBuyLemonade(Recipe recipe, Weather weather)
        {
            if (recipe.amountOfLemons >= customerLemonPreferance &&
                recipe.amountOfSugarCubes >= customerSugarCubePreferance &&
                recipe.amountOfIceCubes >= customerIceCubePreferance &&
                (recipe.pricePerCup <= customerPricePreferance)&&
                (weather.temperature >= customerTemperaturePreferance - 5 ||
                weather.temperature <= customerTemperaturePreferance + 5))
            {
                return true;
            }
            return false;
        }

        
    }
}
