using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Casino.Interfaces
{
    interface IWalkAway
    {
        TwentyOneDealer Dealer { get; set; }

        void WalkAway(Player player);
    }
}
