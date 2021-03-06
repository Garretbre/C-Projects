﻿using System;
using System.Collections.Generic;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace BlackJack_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = FileStyleUriParser.ReadAllText("C:\\Users\\jesse\\Logs\\log.txt");

            //Player newPlayer = new Player("Jesse");

            const string casinoName = "Grand Hotel and Casino";

            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();

        } 
    }
}

//Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);



//Card card1 = new Card(); //Instantiate
//Card card2 = card1; //Change value to card2
//card1.Face = Face.Eight;
//card2.Face = Face.King;

//Console.WriteLine(card1.Face);


//Deck deck = new Deck();

//int count = deck.Cards.Count(x => x.Face == Face.Ace); //*Lambda way to print aces in the deck* 

//deck.Cards. to produce a list.

//int counter = 0; //*how many Aces are ing the deck foreach
//foreach (Card card in deck.Cards)
//{
// if(card.Face == Face.Ace)
//{
//counter++;
//}
//}

// Console.WriteLine(counter);
//deck.Shuffle(3);
//foreach (Card card in deck.Cards)
// {
//     Console.WriteLine(card.Face + " of " + card.Suit);
// }
// Console.WriteLine(deck.Cards.Count);

// Console.ReadLine();
// }


//game.ListPlayers();
//Console.ReadLine();
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


//Game game = new TwentyOneGame();
//game.Players = new List<Players>();
//Player player = new Player();
//player.Name = "Jesse";
//game += player;
//game -= player;
//DaysOfTheWeek day = DaysOfTheWeek.Monday;
//Deck deck = new Deck();
//game.Dealer = "Jesse";
//game.Name = "TwentyOne";
//Card card = new Card { Face = "King", Suit = "Spades" }; Initailizes objects off the bat
//deck.Shuffle(3);
//    //deck = Shuffle(deck, 3);
//    //deck = Shuffle(deck, 3);

//   foreach (Card card in deck.Cards)
//  {
//        Console.WriteLine(card.Face + " of " + card.Suit);
//    }
//    Console.WriteLine(deck.Cards.Count);

//    Console.ReadLine();
//}
//public enum DaysOfTheWeek
//{
//    Monday,
//    Tuesday,
//    Wednesday,
//    Thursday,
//    Friday,
//    Saturday,
//    Sunday
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

//deck.Cards = new List<Card>();

//Card cardOne = new Card();
//cardOne.Face = "Queen";
//cardOne.Suit = "Spades";

//deck.Cards.Add(cardOne);

//Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);