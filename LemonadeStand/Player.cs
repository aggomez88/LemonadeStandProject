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
        public Recipe recipe;
        public Pitcher pitcher;
        public Wallet wallet;
        public Inventory inventory;
       
        public Player(string name)
        {
            this.name = name;

            this.wallet = new Wallet();
            this.recipe = new Recipe();
            this.pitcher = new Pitcher();

            wallet = new Wallet();
            recipe = new Recipe();
            pitcher = new Pitcher();
            inventory = new Inventory();
        }
    }
}

