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
      // List<string> names;
       public string name;

        public List<string> names = new List<string>()
        {
            "Messi","Pique","Suarez","Umtiti","Griezmann","De Jong","Dembele","Vidal","Perez","Rakitic",
            "Ter Stegen","Busquets","Alba","Lenglet","Semedo","Roberto","Rodriguez"
        };

        public Customer()
        {
            names = new List<string>();
        }

        //member methods

        public void CreateName()
        {
            Random namePicking = new Random();
            int potentialNames = namePicking.Next(0, 17);
            name = names[potentialNames];
        }


    }
}
