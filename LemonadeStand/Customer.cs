using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        Weather weather = new Weather();
        Recipe recipe = new Recipe();
        private int sugarCubePref;
        private int tempPref;
        public bool makeDecisionToPurchase;
        
           
        public int iceCubePreference { get; set; }
        public int lemonPreference { get; set; }

        public double CostPerCupPreference { get; set; }

        public string recipePreference { get; set; }

        public int TemperaturePreference {
            get
            {
                return tempPref;
            }
            set
            {
                if (value > 95)
                    tempPref = 95;
                else if (value < 55)
                    tempPref = 55;
                else
                    tempPref = value;
            }
        }

        public int sugarCubePreference
        {
            get
            {
                return sugarCubePref;
            }
            set
            {
                if (value > 9)
                    sugarCubePref = 9;
                else if (value < 0)
                    sugarCubePref = 0;
                else
                    sugarCubePref = value;
            }
        }


        public Customer(Recipe recipe, Weather weather)
        {
            this.weather = weather;
            this.recipe = recipe;
            Random random = new Random();
            TemperaturePreference = random.Next(55, 95);  // Set method on the TemperaturePreference Property
            CostPerCupPreference = random.NextDouble();   // will pick a number between .00 and 1.00 only
            RecepiePreference();
            MakeDecisionToPurchaseLemonade();
        }

        public void RecepiePreference()
        {
            Random random = new Random();
            iceCubePreference = random.Next(0,9);
            sugarCubePreference = random.Next(0,9);
            lemonPreference = random.Next(0, 9);

        }


        private bool DecideWeatherCondition()
        {
            Random random = new Random();
            int randomValue = random.Next(1, 100);
            if (weather.dailyCondition == "Sunny" && randomValue > 10)
            {
                    return true;
            }
            else if (weather.dailyCondition == "Rainy" && randomValue < 30)
            {
                    return true;
            }
            else if (weather.dailyCondition == "cloudy" && randomValue >= 50)
            {
                    return true;
            }
            else
            {
                    return false;
            }
        }
        

        public void MakeDecisionToPurchaseLemonade()
        {

            if (weather.dailyTemperature >= TemperaturePreference && recipe.pricePerCup <= CostPerCupPreference && recipe.amountOfIceCubes >= iceCubePreference && recipe.amountOfLemons >= lemonPreference && recipe.amountOfSugar >= sugarCubePref )


            if (weather.dailyTemperature >= TemperaturePreference && DecideWeatherCondition() && recipe.pricePerCup <= CostPerCupPreference && recipe.amountOfIceCubes >= iceCubePreference && recipe.amountOfLemons >= lemonPreference && recipe.amountOfSugar >= sugarCubePref )

            {

                makeDecisionToPurchase =  true;

            }
            else 
            {
                makeDecisionToPurchase =  false;
            }
        }
        
       
        
    }
}
