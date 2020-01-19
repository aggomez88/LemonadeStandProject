using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public string name;
        
        public Wallet wallet;

        public Inventory inventory = new Inventory();
        
        Recipe recipe = new Recipe();
        Pitcher pitcher = new Pitcher();



        public Player(string name)
        {
            this.name = name;
            wallet = new Wallet();

        }
    }
}

