using System.Collections.Generic;
using System.Linq;

namespace SudokuSolver
{
    public class SquareChecker
    {
        List<int> allDigits = new List<int>(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

        public List<int> GetPossiblesSquare(int[,] table, int row, int column)
        {
            var squarePossibles = allDigits.Except(GetNotPossiblesSquare(table, row, column)).ToList();
            return squarePossibles;
        }

        public List<int> GetNotPossiblesSquare(int[,] table, int row, int column)
        {
            var notPossiblesSquare = new List<int>();
            var beginRow = (row / 3)*3;
            var beginColumn = (column / 3)*3;
            for (int i = beginRow; i < beginRow + 3; i++)
            {
                for (int j = beginColumn; j < beginColumn + 3; j++)
                {
                    if (table[i, j] != 0)
                        notPossiblesSquare.Add(table[i, j]);
                }
            }
            return notPossiblesSquare;
        }
    }
}