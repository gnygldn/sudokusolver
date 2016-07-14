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
       

        public PossibleNumberProvider(Board table, Cell Cell)
        {
            var rowChecker = new RowChecker();
            notPossibleNumbersFromRow = rowChecker.GetNotPossiblesRow(table,Cell.row);
            var columnChecker = new ColumnChecker();
            notPossibleNumbersFromColumn = columnChecker.GetNotPossiblesColumn(table,Cell.column);
            var squareChecker = new SquareChecker();
            notPossibleNumbersFromSquare = squareChecker.GetNotPossiblesSquare(table,Cell.row,Cell.column);
                
        }

        public IEnumerable<int> GetCommonPossiblesList()
        {
            return allDigits.Except(notPossibleNumbersFromSquare.Concat(notPossibleNumbersFromColumn.Concat(notPossibleNumbersFromRow)));
        }
    }
}