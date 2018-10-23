using System;
using Lab07_Collections.Classes;
using System.Collections.Generic;

namespace Lab07_Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            int cardsDealt = 10;

            Console.WriteLine("========================== Original Deck ==========================");
            Deck<Card> myHand = CreateHand(cardsDealt);
            foreach (Card card in myHand)
            {
                Console.WriteLine(card.CardValue + " of " + card.Suit);
            }

            Console.WriteLine("========================== Deck with New Card ==========================");
            AddCardToHand(myHand);
            foreach (Card card in myHand)
            {
                Console.WriteLine(card.CardValue + " of " + card.Suit);
            }


            Console.WriteLine("========================== Deck with Card Revomed ==========================");
            RemoveCardFromHand(myHand, 3, 4);
            foreach (Card card in myHand)
            {
                Console.WriteLine(card.CardValue + " of " + card.Suit);
            }


            Console.WriteLine("========================== Filtered by a Suit ==========================");
            Deck<Card> singleSuit = DisplayAllCardsInASuit(myHand, 2);
            foreach (Card card in singleSuit)
            {
                Console.WriteLine(card.CardValue + " of " + card.Suit);
            }

        }

        /// <summary>
        /// Deals a random hand of cards
        /// </summary>
        /// <param name="cardsDealt">number of cards to be dealt</param>
        public static Deck<Card> CreateHand(int cardsDealt)
        {
            Deck<Card> myHand = new Deck<Card>();
            {
                myHand.Add(new Card { Suit = (Suit) 1, CardValue = (CardValue) 2 });
                myHand.Add(new Card { Suit = (Suit) 3, CardValue = (CardValue) 4 });

                for (int i = 0; i < (cardsDealt - 2); i++)
                {
                    int[] randomCard = RandomCard();
                    myHand.Add(new Card { Suit = (Suit)randomCard[0], CardValue = (CardValue)randomCard[1] });
                }
            }
            return myHand;
        }

        /// <summary>
        /// Adds a single card to the dealt hand
        /// </summary>
        /// <param name="myHand">Deck collection containing the dealt hand</param>
       public static void AddCardToHand(Deck<Card> myHand)
        {
            int[] randomCard = RandomCard();
            myHand.Add(new Card { Suit = (Suit)randomCard[0], CardValue = (CardValue)randomCard[1] });
        }

        /// <summary>
        /// Removes a single card from the dealt hand
        /// </summary>
        /// <param name="myHand">Deck collection containing the dealt hand</param>
        /// <param name="cardSuit">Suit of card to be removed</param>
        /// <param name="cardValue">Value of card to be reomved</param>
        public static void RemoveCardFromHand(Deck<Card> myHand, int cardSuit, int cardValue)
        {
            foreach (Card card in myHand)
            {
                if (card.Suit == (Suit) cardSuit && card.CardValue == (CardValue) cardValue)
                {
                    myHand.Remove(card);
                }
            }
        }
        /// <summary>
        /// Filters the dealt hand down to a single suit
        /// </summary>
        /// <param name="myHand">Deck collection containing the dealt hand<</param>
        /// <param name="cardSuit">Suit of cards to be filtered</param>
        public static Deck<Card> DisplayAllCardsInASuit(Deck<Card> myHand, int cardSuit)
        {
            Deck<Card> singleSuit = new Deck<Card>();
            singleSuit = myHand.CardsInSuit((Suit) cardSuit);

            return singleSuit;
        }

        /// <summary>
        /// Generates a random card
        /// </summary>
        /// <returns>returns an int array,  0 = card suit, 1 = card value</returns>
        public static int[] RandomCard()
        {
            Random rnd = new Random();
            int randomCardSuit = rnd.Next(4);
            int randomCardValue = rnd.Next(2, 14);
            int[] randomCard = new int[] { randomCardSuit, randomCardValue };

            return randomCard;

        }
    }
}
