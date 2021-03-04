using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Project
{
    class TwentyOneDealer : Dealer //Inheritance
    {
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set{ _hand = value; } } //Dealers Hand
        public bool Stay { get; set; }
        public bool isBusted { get; set; }
    }
}
