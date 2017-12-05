using System;

namespace MKLibrary
{
    public class WorkWith2DArrays
    {
        public int[,] A { set; get; }

        public WorkWith2DArrays(int[,] array)
        {
            A = array;
        }

        public int[,] LeftBottomTransfer()
        {
            int rows = A.GetUpperBound(0) + 1;
            int cols = A.GetUpperBound(1) + 1;
            int[,] result = new int[rows, cols];
            int newRow, newCol;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    newRow = row + 1; if (newRow == rows) newRow = 0;
                    newCol = col - 1; if (newCol < 0) newCol = cols - 1;
                    result[newRow, newCol] = A[row, col];
                }
            }
            return result;
        }

        public string AmountOfEven(int[,] arr)
        {
            int upEven = 0, downEven = 0;

            for (int row = 0; row <= arr.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= arr.GetUpperBound(1); col++)
                {
                    if (row < col && (arr[row, col] % 2) == 0) upEven++;
                    else if (row > col && (arr[row, col] % 2) == 0) downEven++;
                }
            }
            return upEven > downEven ? "up" : (upEven == downEven ? "equal" : "down");
        }
    }
}