using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections.Classes
{
   public class Deck <T> : IEnumerable
    {
        T[] hand = new T[10];
        int count = 0;

        /// <summary>
        /// Adds a card to the Deck collection
        /// </summary>
        /// <param name="card">takes in the card to be added</param>
        public void Add(T card)
        {
            if(count == hand.Length)
            {
                Array.Resize(ref hand, 3 + hand.Length);
            }
            hand[count++] = card;
        }

        /// <summary>
        /// Removes a card from the Deck collection
        /// </summary>
        /// <param name="card">takes in the card to be removed</param>
        public void Remove(T card)
        {
            for(int i = 0; i < count; i++)
            {
                if (hand[i].Equals(card))
                {
                    count = count - 1;
                    hand[i] = hand[i + 1];
                }
                hand[i] = hand[i + 1];
            }
        }

        public int Count()
        {
            int counter = count;

            return counter;
        }

        /// <summary>
        /// Returns the cards that are in a chosen suit
        /// </summary>
        /// <param name="suit">suit to be sorted by</param>
        /// <returns>all cards in the selected suit</returns>
        public Deck<Card> CardsInSuit(Suit suit)
        {
            Deck<Card> newHand = new Deck<Card>();

            for (int i = 0; i < count; i++)
            {
                Card card = ((Card)Convert.ChangeType(hand[i], typeof(Card)));
                {
                    if (card.Suit == suit)
                    {
                        newHand.Add(card);
                    }
                }
            }
            return newHand;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return hand[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
