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

        public List<Lemon> lemonList;
        public List<IceCube> iceCubeList;
        public List<Cup> cupsList;
        public List<SugarCube> sugarCubeList;

        // CONSTRUCTOR 
        public Recipe()
        {
            amountOfLemons = 0;
            amountOfIceCubes = 0;
            amountOfSugar = 0;
            pricePerCup = 0;
        }

        // MEMBER METHODS (CAN DO...)

        public void AddLemons(int amountOfLemonsToAdd) //for loop
        {
            this.lemonList.Add(new Lemon());
        }

        public void AddSugar(int amountOfSugarToAdd)
        {
            this.sugarCubeList.Add(new SugarCube());
        }
        public void AddIce(int amountOfIceToAdd)
        {
            this.iceCubeList.Add(new IceCube());
            {

            }

        }    
    }
}
