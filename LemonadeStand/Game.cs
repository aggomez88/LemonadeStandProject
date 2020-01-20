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
            player1 = new Player("Steve");
            Days = new List<Day>();
            groceryStore = new Store(player1);
        }

        public void RunGame()
        {
            groceryStore.RunGroceryShoppingSim();
        }

        public void GameOver()
        {
            if (player1.wallet.Money <= 0)
            {
                Console.WriteLine("Game Over");
            }
        }

        public void Profits()
        {
            double calculateDailyEarnings = DailyEarnings();
            double calculateEndOfGameEarnings = dailyEarnings - player.wallet.Money;

        }
        public double DailyEarnings()
        {
            double dailyEarnings = store.pricePerCup * customerPurchaseCount;
            return dailyEarnings;
        }
        public void EndOfDdayTotal()
        {

        }
    }
}
