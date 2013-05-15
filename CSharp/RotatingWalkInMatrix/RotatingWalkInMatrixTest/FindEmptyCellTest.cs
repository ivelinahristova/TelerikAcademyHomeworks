using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RotatingWalk;

namespace RotatingWalkInMatrixTest
{
    [TestClass]
    public class FindEmptyCellTest
    {
        [TestMethod]
        public void FindEmptyCell_ThereIsEmptyCell()
        {
            int[,] matrix = new int[7, 7]
            {
                {1, 1, 1, 1, 1, 1, 1},
                {0, 1, 1, 1, 1, 1, 1},
                {0, 0, 0, 1, 0, 1, 1},
                {1, 0, 0, 0, 1, 1, 1},
                {0, 1, 0, 1, 1, 1, 1},
                {1, 0, 0, 1, 1, 1, 1},
                {0, 0, 1, 1, 1, 1, 1}
            };
            int positionX = 4;
            int positionY = 4;
            RotatingWalkInMatrix.FindEmptyCell(matrix, ref positionX, ref positionY);
            Assert.AreEqual(positionX, 1);
            Assert.AreEqual(positionY, 0);
        }

        [TestMethod]
        public void FindEmptyCell_ThereIsEmptyCellLast()
        {
            int[,] matrix = new int[7, 7]
            {
                {1, 1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1, 1},
                {0, 1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1, 1}
            };
            int positionX = 4;
            int positionY = 4;
            RotatingWalkInMatrix.FindEmptyCell(matrix, ref positionX, ref positionY);
            Assert.AreEqual(positionX, 4);
            Assert.AreEqual(positionY, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void FindEmptyCell_ThereIsNotEmptyCell()
        {
            int[,] matrix = new int[7, 7]
            {
                {1, 1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1, 1}
            };
            int positionX = 4;
            int positionY = 4;
            RotatingWalkInMatrix.FindEmptyCell(matrix, ref positionX, ref positionY);
        }
    }
}
