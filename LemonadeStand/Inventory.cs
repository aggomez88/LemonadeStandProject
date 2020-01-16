using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        // MEMBER VARIABLES (HAS A...)

        public int lemons;
        public int iceCubes;
        public int sugarCubes;
        public int drinkingCups;

        public List<string> inventory;

        // CONSTRUCTOR
        public Inventory()
        {
            inventory = new List<string>() { "Lemons", "Ice Cubes", "Sugar Cubes", "Drinking Cups" };
            lemons = 0;
            iceCubes = 0;
            sugarCubes = 0;
            drinkingCups = 0;
        }

        // MEMBER METHODS (CAN DO...)
        public int statusInventoryList()
        {
            int userInput;
            string choice;

            do
            {
                Console.Clear();
                Console.WriteLine("You have currently have nothing in your inventory. Choose one of the following stock up: \n 1. Drinking Cups \n 2. Lemons \n 3. Sugar \n 4. Ice Cubes");
                choice = Console.ReadLine();
            } while (Int32.TryParse(choice, out userInput) == false);
            return userInput;
        }

    }
}
