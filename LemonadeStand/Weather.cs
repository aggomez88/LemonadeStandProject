using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public string dailyCondition;
        public int dailyTemperature;
        List<string> dailyWeatherConditionsList = new List<string> { "Cloudy", "Rainy", "Sunny" };


        public Weather()
        {
            dailyTemperature = GenerateDailyTemp();
            dailyCondition = GenerateDailyWeatherCondition();
                   
        }

        public int GenerateDailyTemp()
        {
            Random random = new Random();
            dailyTemperature = random.Next(55,95);

            return dailyTemperature;
          
        }

        public string GenerateDailyWeatherCondition()
        {

            Random random = new Random();
            int conditionGenetrated = random.Next(0,3);

            dailyCondition = dailyWeatherConditionsList[conditionGenetrated];

            return dailyCondition;
        }

    }

}
