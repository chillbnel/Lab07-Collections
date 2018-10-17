using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections.Classes
{
    class Cards
    {
        public Suits SuitInDeck { get; set; }
    }

    enum Suits
    {
        Spades,
        Hearts,
        Clubs,
        Diamonds
    }
}
