using System;
using System.IO;
using System.Text;
class Matrix
{
    static int CheckNeighbours(int[,] matrix, int n, int i, int j)
    {
        int sum = 0;
        int maxSum = 0;
        sum = matrix[i, j - 1] + matrix[i, j] + matrix[i + 1, j] + matrix[i + 1, j - 1];
        if (sum>maxSum)
        {
            maxSum = sum;
        }
        sum = matrix[i, j + 1] + matrix[i, j] + matrix[i + 1, j] + matrix[i + 1, j + 1];
        if (sum > maxSum)
        {
            maxSum = sum;
        }
        sum = matrix[i, j - 1] + matrix[i, j] + matrix[i - 1, j] + matrix[i - 1, j - 1];
        if (sum > maxSum)
        {
            maxSum = sum;
        }
        sum = matrix[i, j + 1] + matrix[i, j] + matrix[i - 1, j] + matrix[i - 1, j + 1];
        if (sum > maxSum)
        {
            maxSum = sum;
        }
        return maxSum;
    }
    static void Main()
    {
        int maxSum = 0;
        StreamReader reader = new StreamReader(@"..\..\text.txt", Encoding.GetEncoding("windows-1251"));
        using (reader)
        {
            string line = reader.ReadLine();
            int n = int.Parse(line);
            int row=0;
            int[,] matrix = new int[n, n];
            line = reader.ReadLine();
            while (line != null)
            {
                string[] numbers = line.Split(' ');
                for (int col = 0; col < n; col++)
                {
                    matrix[row,col] = int.Parse(numbers[col]);
                }
                row++;
                line = reader.ReadLine();
            }
            for (row = 1; row < n-1; row++)
            {
                for (int col = 1;  col < n-1;  col++)
                {
                    if (CheckNeighbours(matrix,n,row,col)>maxSum)
                    {
                        maxSum = CheckNeighbours(matrix,n,row,col);
                    }
                }
            }
            
        }
        StreamWriter writeResult = new StreamWriter(@"../../result.txt");
        using (writeResult)
        {
            writeResult.WriteLine(maxSum);
        }
        
    }
}