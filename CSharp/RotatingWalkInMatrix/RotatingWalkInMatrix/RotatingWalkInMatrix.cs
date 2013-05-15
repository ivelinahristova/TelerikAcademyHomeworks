using System;
using System.Text;

namespace RotatingWalk
{
    public static class RotatingWalkInMatrix
    {
        public static void ChangeDirection(ref int currentDirectionX, ref int currentDirectionY)
        {
            if (currentDirectionX != -1 && currentDirectionX != 1 && currentDirectionX != 0)
            {
                throw new ArgumentOutOfRangeException("Directions could be only -1/1/0");
            }

            if (currentDirectionY != -1 && currentDirectionY != 1 && currentDirectionY != 0)
            {
                throw new ArgumentOutOfRangeException("Directions could be only -1/1/0");
            }

            int[] directionX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            if (currentDirectionX == 0 && currentDirectionY == 1)
            {
                currentDirectionX = directionX[0]; 
                currentDirectionY = directionY[0];
            }
            else
            {
                int currentDirectionIndex = 0;
                for (int index = 0; index < 8; index++)
                {
                    if (directionX[index] == currentDirectionX && directionY[index] == currentDirectionY)
                    {
                        currentDirectionIndex = index;
                        break;
                    }
                }

                currentDirectionX = directionX[currentDirectionIndex + 1];
                currentDirectionY = directionY[currentDirectionIndex + 1];
            }
        }

        public static bool HasPossibleMovement(int[,] matrix, int positionX, int positionY)
        {
            int[] directionX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            for (int i = 0; i < 8; i++)
            {
                if (positionX + directionX[i] >= matrix.GetLength(0) || positionX + directionX[i] < 0)
                {
                    directionX[i] = 0;
                }

                if (positionY + directionY[i] >= matrix.GetLength(0) || positionY + directionY[i] < 0)
                {
                    directionY[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (matrix[positionX + directionX[i], positionY + directionY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static void FindEmptyCell(int[,] matrix, ref int positionX, ref int positionY)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        positionX = i;
                        positionY = j;
                        return;
                    }
                }
            }

            throw new InvalidOperationException("There is no empty cells in the matrix!");
        }

        public static void FillInClockDirection(ref int[,] matrix, ref int positionX, ref int positionY, ref int cellValue)
        {
            int directionX = 1, directionY = 1;
            
            int matrixSize = matrix.GetLength(0);
            bool canMove = HasPossibleMovement(matrix, positionX, positionY);
            while (canMove == true)
            {
                matrix[positionX, positionY] = cellValue;
                if (HasPossibleMovement(matrix, positionX, positionY) == false)
                {
                    canMove = false;
                }
                else
                {
                    while ((positionX + directionX >= matrixSize || positionX + directionX < 0 || positionY + directionY >= matrixSize || positionY + directionY < 0 || matrix[positionX + directionX, positionY + directionY] != 0))
                    {
                        ChangeDirection(ref directionX, ref directionY);
                    }

                    positionX += directionX;
                    positionY += directionY;
                    cellValue++;
                }
            }
        }

        public static string FillAllMatrix(int matrixSize)
        {
            int[,] matrix = new int[matrixSize, matrixSize];
            int positionX = 0, positionY = 0;
            int cellValue = 1;
            StringBuilder toString = new StringBuilder();
            FillInClockDirection(ref matrix, ref positionX, ref positionY, ref cellValue);
            try
            {
                FindEmptyCell(matrix, ref positionX, ref positionY);
            }
            catch (InvalidOperationException)
            {

            }

            cellValue++;
            FillInClockDirection(ref matrix, ref positionX, ref positionY, ref cellValue);
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    toString.AppendFormat("{0,3}", matrix[i, j]);
                }

                toString.Append("\n");
            }

            return toString.ToString();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine( "Enter a positive number for the matrix size" );
            string input = Console.ReadLine();
            int n = 0;
            while (int.TryParse(input, out n) == false || n <= 0 || n > 100)
            {
                Console.WriteLine( "You haven't entered a correct positive number" );
                input = Console.ReadLine();
            }
            int matrixSize = int.Parse(input);
            
            
            Console.WriteLine(FillAllMatrix(matrixSize));
        }
    }
}
