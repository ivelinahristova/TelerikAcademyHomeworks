using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            if (this.Cards.Count == 0)
            {
                return string.Empty;
            }

            foreach (var item in this.Cards)
            {
                toString.Append(item.ToString());
                toString.Append(' ');
            }

            toString.Remove(toString.Length - 1, 1);
            return toString.ToString();
        }
    }
}
