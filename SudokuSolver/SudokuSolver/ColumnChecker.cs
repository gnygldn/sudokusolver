using System.Collections.Generic;
using System.Linq;

namespace SudokuSolver
{
    public class ColumnChecker
    {
        public List<int> GetPossiblesColumn(Board board, int column)
        {
            var columnPossibles =
                new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }.Except(GetNotPossiblesColumn(board, column)).ToList();
            return columnPossibles;
        }

        public List<int> GetNotPossiblesColumn(Board board, int column)
        {
            var notPossiblesColumn = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                if (board.Cell[i, column].Value != 0)
                    notPossiblesColumn.Add(board.Cell[i, column].Value);
            }
            return notPossiblesColumn;
        }
    }
}