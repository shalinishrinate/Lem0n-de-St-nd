using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        //member variables (HAS A)

        public string condition; 
        public int temperature;
       // public List<string> weatherConditions;

        //constructor
        public Weather()
        {
            CreateWeatherConditions();
            CreateTemperature();
        }

        //method (CAN DO)
        public void CreateWeatherConditions()
        {

            List<string> weatherConditions = new List<string>();

            weatherConditions.Add("Dubai Heat");
            weatherConditions.Add("Delhi Sun");
            weatherConditions.Add("Barcelona Bliss");
            weatherConditions.Add("London Cloud");
            weatherConditions.Add("Chicago Wind");
            weatherConditions.Add("Wisconsin Cold");

            Random pickCondition = new Random();
            int randomcondition = pickCondition.Next(weatherConditions.Count);

            condition = weatherConditions[randomcondition];

        }

        public void CreateTemperature()
        {
            if (condition == "Dubai Heat")
            {
                Random pickTemp = new Random();
                temperature = pickTemp.Next(120, 140);             
            }

            else if (condition == "Delhi Sun")
            {
                Random pickTemp = new Random();
                temperature = pickTemp.Next(100, 120);
            }

            else if (condition == "Barcelona Bliss")
            {
                Random pickTemp = new Random();
                temperature = pickTemp.Next(70, 100);
            }

            else if (condition == "London Cloud")
            {
                Random pickTemp = new Random();
                temperature = pickTemp.Next(50, 70);
            }

            else if (condition == "Chicago Wind")
            {
                Random pickTemp = new Random();
                temperature = pickTemp.Next(30, 50);
            }

            else if (condition == "Wisconsin Cold")
            {
                Random pickTemp = new Random();
                temperature = pickTemp.Next(10, 30);
            }

        }

    }
}
