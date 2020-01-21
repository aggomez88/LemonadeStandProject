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
        public Customer customer;
        public Weather weather;
        int dayCounter { get; set; } = 7;
        public double startingMoney;


        public Game()
        {
            player1 = new Player("Steve");
            days = new List<Day>();
            groceryStore = new Store(player1);

            AddNewDayToList();
            this.customer = new Customer(recipe, weather);
        }

        public void AddNewDayToList()
        {
            for (int i = 0; i < 7; i++)
            {
                days.Add(new Day());
                Console.WriteLine(i);

<<<<<<< HEAD
            PlayerMenu();
                 
            
=======
            }
        }

        public void NewDay()
        {
            List<int> days = new List<int>() { 0, 7 };
            foreach (int day in days)
            {
                Console.WriteLine("$ Day {0}", days);
            }
            //days += 1;
        }

        
        public void CycleDay()
        {
            for (int i = 0; i < dayCounter; i++)
            {
                days.Add(new Day());
                Console.WriteLine(i);
            }
        }
        public void RunGame()
        {

            groceryStore.RunGroceryShoppingSim();   
                                                  

            Console.WriteLine("Welcome to Lemonade Stand.");

            PlayerMenu();
>>>>>>> 9e1ff6f3f08c547722af4c62d695f084b6b6d804
        }

        public void PlayerMenu()
        {
            
            Console.WriteLine("What would you like to do today? Choosing by entering number: \n1) Create a recipe \n2)Go to the store\n 3) Open your stand for the day");
            string menuInput = Console.ReadLine();

            if (menuInput == "1")
            {
                player1.recipe.DeclareDailyRecipie();
            }
            else if (menuInput == "2")
            {
                groceryStore.RunGroceryShoppingSim();
            }
            else if (menuInput == "3")
            {
                if (player1.inventory.lemons.Count >= 1 && player1.inventory.sugarCubes.Count >= 1 && player1.inventory.iceCubes.Count >= 1 && player1.inventory.drinkingCups.Count >= 1)
                {
                    CycleDay();
                }
                else
                {
                    Console.WriteLine("Your inventory is low, you need to hit the store.");
                    groceryStore.RunGroceryShoppingSim();
                }
                
            }
            else
            {
                Console.WriteLine("Invalid input, choose number 1, 2 or 3");

            }
        }
        public double Profits()
        {
            double dailyEarnings;

            double calculateDailyEarnings = player1.recipe.pricePerCup * customer.makeDecisionToPurchase;
            double calculateEndOfGameEarnings = calculateDailyEarnings - player1.wallet.Money;
            return calculateEndOfGameEarnings;

            return 0;

        }
        public double DailyEarnings()
        {
            if (customer.makeDecisionToPurchase == true)
            {
                player1.wallet.Money += player1.recipe.pricePerCup;
            }
            //double dailyEarnings = customer.makeDecisionToPurchase * player1.recipe.pricePerCup;
            //return dailyEarnings;
        }
        public void EndOfDdayTotal()
        {

        }
        public void GameOver()
        {
            if ((player1.wallet.Money <= 0) == true || (dayCounter == 0) == true)
            {
                Console.WriteLine("Game Over");
            }
            else
            {
                RunGame();
            }

        }
    }

}
