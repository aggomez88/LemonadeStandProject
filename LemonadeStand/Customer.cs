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
        int temperaturePreferance;
        
     

        public Customer(Recipe recipe, Weather weather)
        {
            this.weather = weather;
            this.recipe = recipe;
        }

        public void RandomizeTaste()
        {

        }

        public int TemperaturePreference()
        {
            Random random = new Random();
            temperaturePreferance = random.Next(55, 95);

            if 

            

            
            return temperaturePreferance; 
        }

        public void CostPerCupPreferance()
        {

        }

        public void MakeDecisionToPurchaseLemonade()
        {

        }

        //Member Variables (HAS A)

        //Constructor

        //Member Methods (CAN DO)






       
        
    }
}
