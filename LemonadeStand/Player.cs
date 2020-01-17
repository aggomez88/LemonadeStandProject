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
        Inventory inventory;//       Wallet wallet;
        Recipe recipe;//
        Pitcher pitcher;//


        public Player(string name)
        {
            this.name = name;
            