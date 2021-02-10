using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlackJack_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);





            //deck.Cards = new List<Card>();

            //Card cardOne = new Card();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            //deck.Cards.Add(cardOne);

            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            Console.ReadLine();
        }
    }
}
