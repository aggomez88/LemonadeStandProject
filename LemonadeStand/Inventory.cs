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

        public List<Lemon> lemons;
        public List<IceCube> iceCubes;
        public List<SugarCube> sugarCubes;
        public List<Cup> drinkingCups;

        

        // CONSTRUCTOR
        public Inventory()
        {
            lemons = new List<Lemon>();
            iceCubes = new List<IceCube>();
            sugarCubes = new List<SugarCube>();
            drinkingCups = new List<Cup>();

           

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
            } while (Int32.TryParse(choice, out userInput) == false || userInput < 1 || userInput > 4 );
            return userInput;
        }

    }
}
