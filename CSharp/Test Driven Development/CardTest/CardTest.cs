using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace Poker
{
    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void ToString_Test7Clubs()
        {
            Card card = new Card(CardFace.Seven, CardSuit.Clubs);
            string result = card.ToString();
            Assert.AreEqual(result, "7♣");
        }

        [TestMethod]
        public void ToString_TestQueenHearts()
        {
            Card card = new Card(CardFace.Queen, CardSuit.Hearts);
            string result = card.ToString();
            Assert.AreEqual(result, "Q♥");
        }

        [TestMethod]
        public void ToString_TestTenHearts()
        {
            Card card = new Card(CardFace.Ten, CardSuit.Hearts);
            string result = card.ToString();
            Assert.AreEqual(result, "10♥");
        }
    }
}
