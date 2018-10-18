using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections.Classes
{
    class Card
    {
        public Suit Suit { get; set; }
        public CardValue CardValue { get; set; }
    }

    public enum Suit
    {
        Spades,
        Hearts,
        Clubs,
        Diamonds
    }

    public enum CardValue
    {
        Two = 2,
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
}
