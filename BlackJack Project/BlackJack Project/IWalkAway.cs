using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Project
{
    interface IWalkAway
    {
        TwentyOneDealer Dealer { get; set; }

        void WalkAway(Player player);
    }
}
