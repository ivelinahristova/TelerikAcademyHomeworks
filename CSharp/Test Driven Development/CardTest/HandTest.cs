using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Test
{
    [TestClass]
    public class HandTest
    {
        [TestMethod]
        public void ToString_NoCards()
        {
            Hand hand = new Hand(new List<ICard>());
            string result = hand.ToString();
            Assert.AreEqual(result, string.Empty);
        }

        [TestMethod]
        public void ToString_TenOfSpades()
        {
            Hand hand = new Hand(new List<ICard>() { new Card(CardFace.Ten, CardSuit.Spades)});
            string result = hand.ToString();
            Assert.AreEqual(result, "10♠");
        }

        [TestMethod]
        public void ToString_ThreeCards()
        {
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Hearts)
            });
            string result = hand.ToString();
            Assert.AreEqual(result, "10♠ 7♣ Q♥");
        }

        [TestMethod]
        public void ToString_SameCards()
        {
            Hand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades)
            });
            string result = hand.ToString();
            Assert.AreEqual(result, "10♠ 10♠");
        }
    }
}
