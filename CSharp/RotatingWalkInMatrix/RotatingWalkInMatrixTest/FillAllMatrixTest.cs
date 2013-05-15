using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RotatingWalk;

namespace RotatingWalkInMatrixTest
{
    [TestClass]
    public class FillAllMatrixTest
    {
        [TestMethod]
        public void FillMatrixTest()
        {

            string result = RotatingWalkInMatrix.FillAllMatrix(3);
            string correctResult = "  1  7  8\n  6  2  9\n  5  4  3\n";
            Assert.AreEqual(result, correctResult);
        }

        [TestMethod]
        public void FillMatrixTestWithSizeOne()
        {

            string result = RotatingWalkInMatrix.FillAllMatrix(1);
            string correctResult = "  1\n";
            Assert.AreEqual(result, correctResult);
        }

        [TestMethod]
        public void FillMatrixTestSize6()
        {

            string result = RotatingWalkInMatrix.FillAllMatrix(6);
            string correctResult =  
                "  1 16 17 18 19 20\n" +
                " 15  2 27 28 29 21\n" +
                " 14 31  3 26 30 22\n" +
                " 13 36 32  4 25 23\n" +
                " 12 35 34 33  5 24\n" +
                " 11 10  9  8  7  6\n";
            Assert.AreEqual(result, correctResult);
        }
    }
}
