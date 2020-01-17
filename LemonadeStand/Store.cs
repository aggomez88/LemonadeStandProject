using System;
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


        public Store()
        {

            List<double> groceryStoreItemsList = new List<double> {pricePerLemon,pricePerSugarCube,pricePerIceCube,pricePerCup};
        }

        public void SellLemons(Player player)
        {
            Console.WriteLine("How many Lemons would you like to purchase?");
            int userInput = Convert.ToInt32(Console.ReadLine());


            player.wallet.Money -= pricePerLemon * userInput;

            player.inventory.lemons += userInput;  

          
        }


    }
}
