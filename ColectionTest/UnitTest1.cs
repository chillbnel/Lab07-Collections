using System;
using Xunit;
using Lab07_Collections.Classes;
using System.Collections.Generic;
using Lab07_Collections;

namespace ColectionTest
{
    public class UnitTest1
    {
        [Fact]
        public void AddCardToDeck()
        {
            Deck<Card> myHand = Program.CreateHand(10);
            Program.AddCardToHand(myHand);
            int count = myHand.Count();

            Assert.Equal(11, count);
        }

        [Fact]
        public void RemoveCardFromDeck()
        {
            Deck<Card> myHand = Program.CreateHand(10);
            Program.RemoveCardFromHand(myHand, 3, 4);
            int count = myHand.Count();

            Assert.Equal(9, count);
        }

        [Fact]
        public void RemoveCardNotInDeckFromDeck()
        {
            Deck<Card> myHand = Program.CreateHand(10);
            Program.RemoveCardFromHand(myHand, 3, 4);
            int count1 = myHand.Count();
            Program.RemoveCardFromHand(myHand, 3, 4);//running a second time to ensure that card will not be in the deck
            int count2 = myHand.Count() + 1;

            Assert.Equal(count2, count1);
        }

        [Fact]
        public void GetProperties()
        {
            Card card = new Card { Suit = (Suit) 1, CardValue = (CardValue) 2 };
            
            Assert.Equal(Suit.Hearts, card.Suit);
        }

        [Fact]
        public void SetProperties()
        {
            Card card = new Card { Suit = (Suit)1, CardValue = (CardValue)2 };
            card.Suit = Suit.Clubs;

            Assert.Equal(Suit.Clubs, card.Suit);
        }
    }
}
