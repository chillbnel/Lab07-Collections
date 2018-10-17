using System;
using Lab07_Collections.Classes;
using System.Collections.Generic;

namespace Lab07_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHand();
        }

        static void CreateHand()
        {
            Deck<Card> myHand = new Deck<Card>()
            {
                new Card {Suit = Suit.Clubs, CardValue = CardValue.A},
                new Card {Suit = Suit.Hearts, CardValue = CardValue.Q},
                new Card {Suit = Suit.Diamonds, CardValue = CardValue.Ten},
                new Card {Suit = Suit.Spades, CardValue = CardValue.Seven},
                new Card {Suit = Suit.Clubs, CardValue = CardValue.K},
                new Card {Suit = Suit.Hearts, CardValue = CardValue.Two},
                new Card {Suit = Suit.Diamonds,CardValue =  CardValue.Six},
                new Card {Suit = Suit.Spades, CardValue = CardValue.Three},
                new Card {Suit = Suit.Clubs, CardValue = CardValue.J},
                new Card {Suit = Suit.Clubs, CardValue = CardValue.Four}
            };

            foreach (Card card in myHand)
            {
                Console.WriteLine(card.Suit + " " + card.CardValue + " ");
            }
        }

        static void AddCardToHand()
        {

        }

        static void RemoveCardFromHand()
        {

        }

        static void ShowCardsInSuit()
        {

        }
    }
}
