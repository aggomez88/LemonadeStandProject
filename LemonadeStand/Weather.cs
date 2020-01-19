using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public string condition;
        public int temperature;
        public string predictedForecast;
        List<string> dailyWeatherConditionsList = new List<string> { "Cloudy", "Rainy", "Sunny" };

    

        public int GenerateDailyTemp()
        {
            Random random = new Random();
            temperature = random.Next(55,95);

            return temperature;
          
        }

        public string GenerateDailyWeatherCondition()
        {

            Random random = new Random();
            int conditionGenetrated = random.Next(0,3);

            condition = dailyWeatherConditionsList[conditionGenetrated];

            return condition;
        }

    }

}
