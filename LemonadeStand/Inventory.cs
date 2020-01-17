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

        public List<Lemon> lemonList;
        public List<IceCube> iceCubeList;
        public List<SugarCube> sugarCubeList;
        public List<Cup> drinkingCupList;

        

        // CONSTRUCTOR
        public Inventory()
        {
<<<<<<< HEAD
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
=======
            lemonList = new List<Lemon>();
            iceCubeList = new List<IceCube>();
            sugarCubeList = new List<SugarCube>();
            drinkingCupList = new List<Cup>();


>>>>>>> cef50463100f9b887d926fedc7cad928ea4c6506

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
        

        // MEMBER METHODS (CAN DO...)
        

    }
}
