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

            PlayerMenu();
            



            
            
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
                CycleDay();
            }
            else
            {
                Console.WriteLine("Invalid input, choose number 1, 2 or 3");

            }
        }

        public void CycleDay()
        {
            for (int i = 0; i < dayCounter; i++)
            {
                // step 1 weather forecast
                // step 2 choose recepie (save for later implementation)
                // step 3 grocery shop
                // step 4 EOD totals



            }
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
