using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
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

        public void AddLemons(int purchasedLemons)
        {
           
            for (int i = 0; i < purchasedLemons; i++)
            {
                lemons.Add(new Lemon());
            } 

        }

        public void AddSugarCubes( int purchasedSugarCubes)
        {
            for (int i = 0; i < purchasedSugarCubes; i++)
            {
                sugarCubes.Add(new SugarCube());
            }
        }

        public void AddIceCubes(int purchasedIceCubes)
        {
            for (int i = 0; i < purchasedIceCubes; i++)
            {
                iceCubes.Add(new IceCube());
            }
        }

        public void AddDrinkingCups(int purchasedDrinkingCups)
        {
            for (int i = 0; i < purchasedDrinkingCups; i++)
            {
                drinkingCups.Add(new Cup());
            }
        }
     

    }
}
