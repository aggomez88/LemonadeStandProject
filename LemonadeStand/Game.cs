using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        public Player player1;
        public List<Day> Days;
        public Store groceryStore;

        
        public Game()
        {
            player1 = new Player();
            Days = new List<Day>();
            groceryStore = new Store(player1);
            

        }

        public void RunGame()
        {
            groceryStore.RunGroceryShoppingSim();
        }
    }
}
