using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        // HAS A
        public Player player1;
        public List<Day> days;
        public int currentDay = 0;

        public Store groceryStore;
        public Store store;
        public Recipe recipe;
        // public Customer customer;
        public Weather weather;
        
        
        public Game()
        {
            player1 = new Player("Steve");
            days = new List<Day>();
            groceryStore = new Store(player1);
            this.store = new Store(player1);
            this.recipe = new Recipe();
            AddNewDayToList();
           // this.customer = new Customer(recipe, weather);
        }

        public void AddNewDayToList()
        {
            for (int i = 0; i < 7; i++)
            {
                days.Add(new Day());
                Console.WriteLine(i);

            }
        }

        public void NewDay()
        {
            List<int> days = new List<int>() { 0, 7 };
            foreach ( int day in days)
            {
                Console.WriteLine("$ Day {0}", days);
            }
            //days += 1;
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

        public double Profits()
        {
            // double dailyEarnings;

            //double calculateDailyEarnings = DailyEarnings();
            //double calculateEndOfGameEarnings = calculateDailyEarnings - player1.wallet.Money;
            //return calculateEndOfGameEarnings;

            return 0;

        }
        
    }
}
