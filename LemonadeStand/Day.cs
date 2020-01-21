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
    }

}
