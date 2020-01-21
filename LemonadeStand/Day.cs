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

        public double startingMoney;

        // Constructor
        public Day()
        {
            weather = new Weather();
            customers = new List<Customer>();

        }

        public double DailyEarnings(Player player)
        {
            double dailyEarnings = player.wallet.Money - startingMoney;
            return dailyEarnings;
        }
        public void EndOfDdayTotal()
        {

        }

        // Member methods





    }
}
