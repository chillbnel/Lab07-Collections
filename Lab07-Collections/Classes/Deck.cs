using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections.Classes
{
    class Deck <T> : IEnumerable
    {
        T[] hand = new T[10];
        int count = 0;

        public void Add(T card)
        {
            if(count == hand.Length)
            {
                Array.Resize(ref hand, 3 + hand.Length);
            }
            hand[count++] = card;
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
