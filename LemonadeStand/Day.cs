﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        // Member variables
        public Weather weather;
        public List<Customer> customers;
        public int randomValue;
        public Player player;
      


        

        // Constructor
        public Day()
        {
            weather = new Weather();
            customers = new List<Customer>();
            player = new Player();
            GenerateCustomers();
        }
<<<<<<< HEAD

        public void GenerateCustomers()
        {
            Random random = new Random();
            randomValue = random.Next(1, 50);

            if (weather.dailyCondition == "Sunny") 
            {
                randomValue += 50;
            }
            else if (weather.dailyCondition == "Rainy") 
            {
                randomValue += 10;
            }
            else if (weather.dailyCondition == "Cloudy") 
            {
                randomValue += 25;
            }

            for (int i = 0; i < randomValue; i++)
            {
                customers.Add(new Customer(recipe, weather));
            }

        }



=======
>>>>>>> 9e1ff6f3f08c547722af4c62d695f084b6b6d804
    }

}
