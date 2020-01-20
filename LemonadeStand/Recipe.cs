using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        // MEMBER VARIABLES (HAS A...)

        public int amountOfLemons;
        public int amountOfSugar;
        public int amountOfIceCubes;
        public double pricePerCup;

        // CONSTRUCTOR 
        public Recipe()
        {
            DeclareDailyRecipie();
        }
        public void DeclareDailyRecipie()
        {
            Console.WriteLine("Choose your recipie for the day, only input numbers only 0-9");
            Console.WriteLine("Amount of lemons: ");
            amountOfLemons = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Amount of SugarCubes: ");
            amountOfSugar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Amount of IceCubes: ");
            amountOfIceCubes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Amount of : ");
            pricePerCup = Convert.ToInt32(Console.ReadLine());


        }

        // MEMBER METHODS (CAN DO...)

        //public void AddLemons(int amountOfLemonsToAdd) //use 'for loop' but also connect to pitcher --> HOW?
        //{
        //    this.lemonList.Add(new Lemon());
        //}

        //public void AddSugar(int amountOfSugarToAdd)
        //{
        //    this.sugarCubeList.Add(new SugarCube());
        //}
        //public void AddIce(int amountOfIceToAdd)
        //{
        //    this.iceCubeList.Add(new IceCube());
        //    {

        //    }

        //}
        //public void CreateRecipe()
        //{

        //}

    }
}
