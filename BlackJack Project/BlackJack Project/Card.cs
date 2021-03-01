using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Project
{
    public struct Card
    {
        public Suit Suit { get; set; }
        public string Face { get; set; }
    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
            //public Card()
            //{
            //Suit = "Spades";
            //Face = "Two";
            //}


    
            
        
    
}
