using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inventory inventory = new Inventory();
            ////inventory.statusInventoryList();
            //Weather weather = new Weather();
            Game game = new Game();
            game.RunGame();
            game.NewDay();
            Console.ReadLine();
        }
    }
}
