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
            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            game.ListPlayers();
            Console.ReadLine();
            //Game game = new Game(); *Absract cannot instaitiate class when you abstract a class*
            //*Polymorphism*
            //List<Game> games = new List<Game>();
            //TwentyOneGame game = new TwentyOneGame();
            //games.Add(game);
            //*Polymorphism*
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            //game.ListPlayers();
            //Console.ReadLine();



            //Deck deck = new Deck();
            //game.Dealer = "Jesse";
            //game.Name = "TwentyOne";
            //Card card = new Card { Face = "King", Suit = "Spades" }; Initailizes objects off the bat
            //deck.Shuffle(3);
        //    //deck = Shuffle(deck, 3);
        //    //deck = Shuffle(deck, 3);

        //    foreach (Card card in deck.Cards)
        //   {
        //        Console.WriteLine(card.Face + " of " + card.Suit);
        //    }
        //    Console.WriteLine(deck.Cards.Count);
            
        //    Console.ReadLine();
        //}

        //public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        //{
        //    timesShuffled++ = 0;
        //    for (int i = 0; i < times; i++)
        //    {
        //        timesShuffled++;
        //        List<Card> TempList = new List<Card>();
        //        Random random = new Random();

        //        while (deck.Cards.Count > 0)
        //        {
        //            int randomIndex = random.Next(0, deck.Cards.Count);
        //            TempList.Add(deck.Cards[randomIndex]);
        //            deck.Cards.RemoveAt(randomIndex);

        //        }
        //        deck.Cards = TempList;
        //    }
        //    return deck;
        //}

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}

//Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);





//deck.Cards = new List<Card>();

//Card cardOne = new Card();
//cardOne.Face = "Queen";
//cardOne.Suit = "Spades";

//deck.Cards.Add(cardOne);

//Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);