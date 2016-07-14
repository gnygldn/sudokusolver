using System.Collections.Generic;
using System.Linq;

namespace SudokuSolver
{
    public class SquareChecker
    {
        List<int> allDigits = new List<int>(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

        public List<int> GetPossiblesSquare(Board board, int row, int column)
        {
            var squarePossibles = allDigits.Except(GetNotPossiblesSquare(board, row, column)).ToList();
            return squarePossibles;
        }

        public List<int> GetNotPossiblesSquare(Board board, int row, int column)
        {
            var notPossiblesSquare = new List<int>();
            var beginRow = (row / 3)*3;
            var beginColumn = (column / 3)*3;
            for (int i = beginRow; i < beginRow + 3; i++)
            {
                for (int j = beginColumn; j < beginColumn + 3; j++)
                {
                    if (board.Cell[i, j].value != 0)
                        notPossiblesSquare.Add(board.Cell[i, j].value);
                }
            }
            return notPossiblesSquare;
        }
    }
}