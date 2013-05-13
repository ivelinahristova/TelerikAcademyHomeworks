using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Test
{
    [TestClass]
    public class PokerHandsCheckerTest
    {
        [TestMethod]
        public void IsValidHand_3Cards()
        {
            PokerHandsChecker handsChecker = new PokerHandsChecker();
            bool result = handsChecker.IsValidHand(new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Hearts)
            }));
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void IsValidHand_5EqualCards()
        {
            PokerHandsChecker handsChecker = new PokerHandsChecker();
            bool result = handsChecker.IsValidHand(new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Hearts)
            }));
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void IsValidHand_4DifferentCards()
        {
            PokerHandsChecker handsChecker = new PokerHandsChecker();
            bool result = handsChecker.IsValidHand(new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds)
            }));
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void IsValidHand_5DifferentCards()
        {
            PokerHandsChecker handsChecker = new PokerHandsChecker();
            bool result = handsChecker.IsValidHand(new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds)
            }));
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void IsValidHand_5DifferentFacesAndEqualSuit()
        {
            PokerHandsChecker handsChecker = new PokerHandsChecker();
            bool result = handsChecker.IsValidHand(new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts)
            }));
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void IsValidHand_4EqualFacesAndDifferentSuit()
        {
            PokerHandsChecker handsChecker = new PokerHandsChecker();
            bool result = handsChecker.IsValidHand(new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts)
            }));
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void IsConsecutive_5CardsAreNotConsecutive()
        {
            bool result = PokerHandsChecker.IsConsecutive(new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts)
            }));
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void IsConsecutive_5CardsAlmostConsecutive()
        {
            bool result = PokerHandsChecker.IsConsecutive(new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts)
            }));
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void IsConsecutive_5CardsConsecutive()
        {
            bool result = PokerHandsChecker.IsConsecutive(new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Hearts)
            }));
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void IsOneColored_5CardsWithDifferentColors()
        {
            bool result = PokerHandsChecker.IsOneColored(new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts)
            }));
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void IsOneColored_1CardWithDifferentColor()
        {
            bool result = PokerHandsChecker.IsOneColored(new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts)
            }));
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void IsOneColored_5CardsWithEqualColorsBlack()
        {
            bool result = PokerHandsChecker.IsOneColored(new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Clubs)
            }));
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void IsOneColored_5CardsWithEqualColorsRed()
        {
            bool result = PokerHandsChecker.IsOneColored(new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Diamonds)
            }));
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void IsFlush_5CardsWithDifferentColors()
        {
            PokerHandsChecker handsChecker = new PokerHandsChecker();
            bool result = handsChecker.IsFlush(new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts)
            }));
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void IsFlush_5CardsWithRedColorsAndNotConsecutive()
        {
            PokerHandsChecker handsChecker = new PokerHandsChecker();
            bool result = handsChecker.IsFlush(new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts)
            }));
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void IsFlush_4RedsAnd1BlackColor()
        {
            PokerHandsChecker handsChecker = new PokerHandsChecker();
            bool result = handsChecker.IsFlush(new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Hearts)
            }));
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void IsFlush_ConsecutiveAndBlackColored()
        {
            PokerHandsChecker handsChecker = new PokerHandsChecker();
            bool result = handsChecker.IsFlush(new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Clubs)
            }));
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void IsFlush_ConsecutiveAndRedColored()
        {
            PokerHandsChecker handsChecker = new PokerHandsChecker();
            bool result = handsChecker.IsFlush(new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Six, CardSuit.Diamonds)
            }));
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void IsFourOfAKind_5OfDifferentKind()
        {
            PokerHandsChecker handsChecker = new PokerHandsChecker();
            bool result = handsChecker.IsFourOfAKind(new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Six, CardSuit.Diamonds)
            }));
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void IsFourOfAKind_3OfAKind()
        {
            PokerHandsChecker handsChecker = new PokerHandsChecker();
            bool result = handsChecker.IsFourOfAKind(new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Six, CardSuit.Diamonds)
            }));
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void IsFourOfAKind_4OfAKind()
        {
            PokerHandsChecker handsChecker = new PokerHandsChecker();
            bool result = handsChecker.IsFourOfAKind(new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Spades)
            }));
            Assert.AreEqual(result, true);
        }


    }
}
