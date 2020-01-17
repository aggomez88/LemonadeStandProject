﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        double pricePerLemon = .48;
        double pricePerSugarCube = .01;
        double pricePerIceCube = .01;
        double pricePerCup = .04;
        Player player;

        public Store(Player player)
        {
            this.player = player;
            List<double> groceryStoreItemsList = new List<double> {pricePerLemon,pricePerSugarCube,pricePerIceCube,pricePerCup};
        }

        public void NotEnoughFunds()
        {
            Console.WriteLine("Not enough funds! Select another quantity.");
        }

        public void SellLemons()
        {
            Console.WriteLine("How many Lemons would you like to purchase?");
            int userInput = Convert.ToInt32(Console.ReadLine());


            player.wallet.Money -= pricePerLemon * userInput;

            if (player.wallet.Money < pricePerLemon * userInput)
            {
                NotEnoughFunds();
            }
            else
            {
                player.inventory.AddLemons(userInput); 
            }

            
        





            

          
        }


    }
}
