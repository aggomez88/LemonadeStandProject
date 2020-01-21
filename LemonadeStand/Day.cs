using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        // Member variables
        public Weather weather;
        public List<Customer> customers;

        

        // Constructor
        public Day()
        {
            weather = new Weather();
            customers = new List<Customer>();

        }
        public void SellLemonade(Player player)
        {
            CustomersDecide();
            CustomersPurchase(player);
        }
        public void CustomersDecide()
        {
            for (int i = 0; i < customers.Count; i++)
            {
                customers[i].MakeDecisionToPurchaseLemonade();
            }
        }
        public void CustomersPurchase(Player player)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if(customers[i].makeDecisionToPurchase == true)
                {
                    player.wallet.Money += player.recipe.pricePerCup;
                }
            }
        }
    }

}
