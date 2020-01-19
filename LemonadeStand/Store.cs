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


            

            if (player.wallet.Money < pricePerLemon * userInput)
            {
                NotEnoughFunds();
            }
            else
            {
                player.wallet.Money -= pricePerLemon * userInput;
                player.inventory.AddLemons(userInput); 
            }          

        }

        public void SellSugarCubes()
        {
            Console.WriteLine("How many Sugar Cubes would you like to purchase?");
            int userInput = Convert.ToInt32(Console.ReadLine());




            if (player.wallet.Money < pricePerSugarCube * userInput)
            {
                NotEnoughFunds();
            }
            else
            {
                player.wallet.Money -= pricePerSugarCube * userInput;
                player.inventory.AddSugarCubes(userInput);
            }
        }

        public void SellCups()
        {
            Console.WriteLine("How many Cups would you like to purchase?");
            int userInput = Convert.ToInt32(Console.ReadLine());


            if (player.wallet.Money < pricePerCup * userInput)
            {
                NotEnoughFunds();
            }
            else
            {
                player.wallet.Money -= pricePerCup * userInput;
                player.inventory.AddDrinkingCups(userInput);
            }
        }

        public void SellIceCubes()
        {
            Console.WriteLine("How many Ice Cubes would you like to purchase?");
            int userInput = Convert.ToInt32(Console.ReadLine());


            if (player.wallet.Money < pricePerIceCube * userInput)
            {
                NotEnoughFunds();
            }
            else
            {
                player.wallet.Money -= pricePerIceCube * userInput;
                player.inventory.AddIceCubes(userInput);
            }
        }
    }
}
