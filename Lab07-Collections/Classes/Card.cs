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

    enum Suit
    {
        Spades,
        Hearts,
        Clubs,
        Diamonds
    }

    enum CardValue
    {
        A,
        K,
        Q,
        J,
        Ten,
        Nine,
        Eight,
        Seven,
        Six,
        Five,
        Four,
        Three,
        Two
    }
}
