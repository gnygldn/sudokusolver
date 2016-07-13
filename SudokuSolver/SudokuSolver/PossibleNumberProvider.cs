using System.Collections.Generic;
using System.Linq;

namespace SudokuSolver
{
    public class PossibleNumberProvider
    {
        List<int> allDigits = new List<int>(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        private List<int> notPossibleNumbersFromRow;
        private List<int> notPossibleNumbersFromColumn;
        private List<int> notPossibleNumbersFromSquare;
       

        public PossibleNumberProvider(int[,] table, int row, int column)
        {
            RowChecker rowChecker = new RowChecker();
            notPossibleNumbersFromRow = rowChecker.GetNotPossiblesRow(table,row);
            ColumnChecker columnChecker = new ColumnChecker();
            notPossibleNumbersFromColumn = columnChecker.GetNotPossiblesColumn(table,column);
            SquareChecker squareChecker = new SquareChecker();
            notPossibleNumbersFromSquare = squareChecker.GetNotPossiblesSquare(table,row,column);
                
        }

        public IEnumerable<int> GetCommonPossiblesList()
        {
            return allDigits.Except(notPossibleNumbersFromSquare.Concat(notPossibleNumbersFromColumn.Concat(notPossibleNumbersFromRow)));
        }
    }
}