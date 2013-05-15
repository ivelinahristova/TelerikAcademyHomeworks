using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RotatingWalk;

namespace RotatingWalkInMatrixTest
{
    [TestClass]
    public class HasPossibleMovementTest
    {
        [TestMethod]
        public void HasPossibleMovement_ThereIsPossibleMovement()
        {
            int[,] matrix = new int[7, 7]
            {
                {0, 0, 0, 1, 1, 0, 1},
                {1, 1, 0, 1, 1, 0, 1},
                {0, 0, 0, 1, 0, 0, 1},
                {1, 0, 0, 0, 1, 0, 1},
                {0, 1, 0, 1, 1, 0, 1},
                {1, 0, 0, 1, 0, 0, 1},
                {0, 0, 1, 1, 1, 0, 1}
            };

            bool result = RotatingWalkInMatrix.HasPossibleMovement(matrix, 3, 3);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HasPossibleMovement_ThereIsNotPossibleMovement()
        {
            int[,] matrix = new int[7, 7]
            {
                {0, 0, 0, 1, 1, 0, 1},
                {1, 1, 0, 1, 1, 0, 1},
                {0, 0, 1, 1, 1, 0, 1},
                {1, 0, 1, 0, 1, 0, 1},
                {0, 1, 1, 1, 1, 0, 1},
                {1, 0, 0, 1, 1, 0, 1},
                {0, 0, 1, 1, 1, 0, 1}
            };

            bool result = RotatingWalkInMatrix.HasPossibleMovement(matrix, 3, 3);
            Assert.IsFalse(result);
        }
    }
}
