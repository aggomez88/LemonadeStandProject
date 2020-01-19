using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        // MEMBER VARIABLES (HAS A...)

        public int amountOfLemons;
        public int amountOfSugar;
        public int amountOfIceCubes;
        public double pricePerCup;


        // CONSTRUCTOR 
        public Recipe()
        {
            amountOfLemons = 3;
            amountOfIceCubes = 3;
            amountOfSugar = 5;
            pricePerCup = .25;
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
