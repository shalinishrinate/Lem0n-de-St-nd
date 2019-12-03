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
        public int todaysActualLow;
        public int todaysActualHigh;
        public int actualTemperature;
        public string actualWeather;
        public string forecast;
        Random pickTemp;

        //constructor
        public Weather(Random rnd)
        {
            pickTemp = rnd;
            CreateWeatherConditions();
            CreateTemperature();
    
            CreateActualWeather();
     
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

            int randomCondition = pickTemp.Next(weatherConditions.Count);   // List.Count Property is used to get the total number of elements contained in the List.

            condition = weatherConditions[randomCondition];

        }

        public void CreateTemperature()
        {
            if (condition == "Dubai Heat")
            {

                temperature = pickTemp.Next(120, 140);          // have put a range of temperation for each weather condition   
                forecast = (condition + " and " + temperature); // forecast will be the expected weather condition and tempeture
            }

            else if (condition == "Delhi Sun")
            {
             
                temperature = pickTemp.Next(100, 120);
                forecast = (condition + " and " + temperature);
            }

            else if (condition == "Barcelona Bliss")
            {
   
                temperature = pickTemp.Next(80, 100);
                forecast = (condition + " and " + temperature);
            }

            else if (condition == "London Cloud")
            {

                temperature = pickTemp.Next(60, 80);
                forecast = (condition + " and " + temperature);
            }

            else if (condition == "Chicago Wind")
            {
  
                temperature = pickTemp.Next(40, 60);
                forecast = (condition + " and " + temperature);
            }

            else if (condition == "Wisconsin Cold")
            {
       
                temperature = pickTemp.Next(20, 40);
                forecast = (condition + " and " + temperature);
            }

        }

        public void DisplayForecast()
        {
            Console.WriteLine(" Today's forecast is: " + forecast);
        }

        public void CreateActualWeather()
        {
             //ActualWeather = ActualTemperature + WeatherCondition - 
            //should be working on this for what actual weather will be like
            //taking into account fluctuations in temperature, the daily highs and lows will change

            int temperatureFluctuation = 5;

            todaysActualLow = temperature - temperatureFluctuation;
            todaysActualHigh = temperature + temperatureFluctuation;

      
            actualTemperature = pickTemp.Next(todaysActualLow, todaysActualHigh);

            actualWeather = (condition + " and " + actualTemperature);

        }
        
        public void DisplayActualWeather()
        {
            Console.WriteLine(" Today's weather is: " + actualWeather);
        }

        
    }
}
