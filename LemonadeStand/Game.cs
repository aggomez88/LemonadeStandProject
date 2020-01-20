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
        int dayCounter { get; set; } = 7;

        
        public Game()
        {
            player1 = new Player("Paul");
            Days = new List<Day>();
            groceryStore = new Store(player1);
            

        }

        public void RunGame()
        {
            Console.WriteLine("Welcome to Lemonade Stand.");

            
            for (int i = 0; i < dayCounter; i++)
            {
                // step 1 weather forecast
                // step 2 choose recepie (save for later implementation)
                // step 3 grocery shop
                // step 4 EOD totals
                DisplayWeather();
           
            }
            
        }

        public void GameOver()
        {
            if ((player1.wallet.Money <= 0) == true || (dayCounter == 0) == true) 
            {
                Console.WriteLine("Game Over");
            }

        }

        public void DisplayWeather()
        {
            
        }
    }
}
