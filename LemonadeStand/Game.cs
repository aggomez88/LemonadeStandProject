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
        public Day day;

        public int currentDay = 0; //INCREMENT BY ONE (++)

        public Store groceryStore;
        public Customer customer;
        public Weather weather;
        int dayCounter { get; set; } = 7;
        public double startingMoney;
        public double dailyEarnings;


        public Game()
        {
            player1 = new Player("Steve");
            days = new List<Day>();
            groceryStore = new Store(player1);

            //this.customer = new Customer(player1.recipe, weather);
        }

        public void RunGame()
        {
            //Welcome message & display rules = COMPLETE
            //Instantiate day =
            //Populate customers in day =
            //Generate weather temp and forecast in day =
            //Use and/or make recipe to use =
            //Populate inventory with lemons, ice, sugar, cups =
            //Player sets price for cup =
            //Sell lemonade =
            //Display end of day totals =

            GreetUser();
            PlayerMenu();
            for (int i = 0; i < dayCounter; i++)
            {
                if (player1.wallet.Money >= 0)
                {
                    days.Add(new Day());
                    //generate customers
                    //generate weather
                    groceryStore.RunGroceryShoppingSim();
                    player1.recipe.DeclareDailyRecipie();
                    days[i].SellLemonade(player1);
                    Profits();
                }
            }
        }

        public void GreetUser()
        {
            string userInput = Console.ReadLine().ToLower();

            Console.WriteLine("Welcome to your lemonade stand. Here's how it works...");
            Console.WriteLine("You have $20.00 to start.  Go to the store and stock your inventory.");
            Console.WriteLine("Choose how much of each item to add to your recipe and set your price, then go hit the street...Good Luck!");
            Console.WriteLine("Hit any ENTER to continue...");
            userInput = Console.ReadLine();
        }
        public void RunSingleDay()//have a method that runs a single day:
        {
            GreetUser();
            weather.DisplayWeather();
            player1.recipe.DeclareDailyRecipie();
            Console.WriteLine(player1.wallet.Money);
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
                double dailyEarnings; //if daily earning


                double calculateDailyEarnings = player1.recipe.pricePerCup * customer.CostPerCupPreference;
                double calculateEndOfGameEarnings = calculateDailyEarnings - player1.wallet.Money;  //player.wallet.money - 20 (starting money) = FINAL WEEKS EARNINGS
            return calculateEndOfGameEarnings;

            }
            public double DailyEarnings()
            {
                if (customer.makeDecisionToPurchase == true)
                {
                    player1.wallet.Money += player1.recipe.pricePerCup;
                    return 0;
                }
                else
                {
                    return 0;
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
