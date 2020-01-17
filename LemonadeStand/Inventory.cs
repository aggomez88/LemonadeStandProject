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

        public List<Lemon> lemonList;
        public List<IceCube> iceCubeList;
        public List<SugarCube> sugarCubeList;
        public List<Cup> drinkingCupList;

        

        // CONSTRUCTOR
        public Inventory()
        {
            lemonList = new List<Lemon>();
            iceCubeList = new List<IceCube>();
            sugarCubeList = new List<SugarCube>();
            drinkingCupList = new List<Cup>();



        }

        // MEMBER METHODS (CAN DO...)
        

    }
}
