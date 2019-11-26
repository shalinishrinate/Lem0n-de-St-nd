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
        public string condition; //what does this represent???
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
            weatherConditions.Add("Sahara Heat");
            weatherConditions.Add("Sunny");
            weatherConditions.Add("Cloudy");
            weatherConditions.Add("Windy");
            weatherConditions.Add("Snowmageddon");

            // choose a weatherConditions
            // set 'condition' member variable
        }

        public void CreateTemperature()
        {
            if (condition == "Sunny")
            {
                temperature =rng.Next( );

                Random rnd = new Random();
                gesture = gestures[rnd.Next(gestures.Count)];
            }
        }

    }
}
