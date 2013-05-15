using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RotatingWalk;

namespace RotatingWalkInMatrixTest
{
    [TestClass]
    public class ChangeDirectionTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ChangeDirection_OutOfRangeDirectionsY()
        {
            int directionX = -1;
            int directionY = 2;
            RotatingWalkInMatrix.ChangeDirection(ref directionX, ref directionY);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ChangeDirection_OutOfRangeDirectionsX()
        {
            int directionX = -2;
            int directionY = 1;
            RotatingWalkInMatrix.ChangeDirection(ref directionX, ref directionY);
        }

        [TestMethod]
        public void ChangeDirection_XDirection1AndYDirection0()
        {
            int directionX = 1;
            int directionY = 0;
            RotatingWalkInMatrix.ChangeDirection(ref directionX, ref directionY);
            Assert.AreEqual(1, directionX);
            Assert.AreEqual(-1, directionY);
        }

        [TestMethod]
        public void ChangeDirection_LastPossibleDirections()
        {
            int directionX = 0;
            int directionY = 1;
            RotatingWalkInMatrix.ChangeDirection(ref directionX, ref directionY);
            Assert.AreEqual(1, directionX);
            Assert.AreEqual(1, directionY);
        }
    }
}
