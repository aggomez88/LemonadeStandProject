using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Pitcher
    {
        // MEMBER VARIABLES (HAS A...)
        public int cupsToMakePitcher;
        public int cupsLeftInPitcher;


        // CONSTRUCTOR
        public Pitcher(Recipe recipe)
        {
            cupsLeftInPitcher = 0;
        }

        // MEMBER METHODS (CAN DO...)
        public void MakePitcher()
        {

        }
        
        public void DeductInventory(Recipe recipe, Inventory inventory)
        {
            inventory.lemonList.RemoveRange(0, recipe.amountOfLemons);
            inventory.sugarCubeList.RemoveRange(0, recipe.amountOfSugar);
            inventory.iceCubeList.RemoveRange(0, recipe.amountOfIceCubes);

            while (inventory.lemonList > 0 && recipe.amountOfLemons > 0)
            {

            }
        }



    }
}
