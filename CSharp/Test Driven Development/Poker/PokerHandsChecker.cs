using System;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count < 5)
            {
                return false;
            }
            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        if (hand.Cards[i].Suit == hand.Cards[j].Suit)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public static bool IsConsecutive(IHand hand)
        {
            bool isConsetutive = true;
            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                if ((int)hand.Cards[i].Face + 1 != (int)hand.Cards[i + 1].Face)
                {
                    isConsetutive = false;
                    break;
                }
            }
            return isConsetutive;
        }

        public static bool IsOneColored(IHand hand)
        {
            bool isOneColored = true;
            if ((int)hand.Cards[0].Suit == 1 || (int)hand.Cards[0].Suit == 4)
            {
                for (int i = 0; i < hand.Cards.Count; i++)
                {
                    if ((int)hand.Cards[i].Suit != 1 && (int)hand.Cards[i].Suit != 4)
                    {
                        isOneColored = false;
                        break;
                    }
                }
            }

            if ((int)hand.Cards[0].Suit == 2 || (int)hand.Cards[0].Suit == 3)
            {
                for (int i = 0; i < hand.Cards.Count; i++)
                {
                    if ((int)hand.Cards[i].Suit != 2 && (int)hand.Cards[i].Suit != 3)
                    {
                        isOneColored = false;
                        break;
                    }
                }
            }

            return isOneColored;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (this.IsValidHand(hand) == false)
            {
                return false;
            }
            int count = 1;
            for (int i = 1; i < hand.Cards.Count; i++)
            {
                if (hand.Cards[0].Face == hand.Cards[i].Face)
                {
                    count++;
                }
            }
            if (count == 4)
            {
                return true;
            }
            count = 1;
            for (int i = 2; i < hand.Cards.Count; i++)
            {
                if (hand.Cards[1].Face == hand.Cards[i].Face)
                {
                    count++;
                }
            }
            if (count == 4)
            {
                return true;
            }
            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            if (this.IsValidHand(hand) == false)
            {
                return false;
            }
            if (IsConsecutive(hand) == true && IsOneColored(hand) == true)
            {
                return true;
            }
            return false;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
