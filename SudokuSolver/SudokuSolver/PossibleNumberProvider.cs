using System.Collections.Generic;
using System.Linq;

namespace SudokuSolver
{
    public class PossibleNumberProvider
    {
        
        private List<int> notPossibleNumbersFromRow;
        private List<int> notPossibleNumbersFromColumn;
        private List<int> notPossibleNumbersFromSquare;
       

        public PossibleNumberProvider(Board table, Cell cell)
        {
            var rowChecker = new RowChecker();
            notPossibleNumbersFromRow = rowChecker.GetNotPossiblesRow(table,cell.Row);
            var columnChecker = new ColumnChecker();
            notPossibleNumbersFromColumn = columnChecker.GetNotPossiblesColumn(table,cell.Column);
            var squareChecker = new SquareChecker();
            notPossibleNumbersFromSquare = squareChecker.GetNotPossiblesSquare(table,cell.Row,cell.Column);
                
        }

        public IEnumerable<int> GetCommonPossiblesList()
        {
            return new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }.Except(notPossibleNumbersFromSquare.Concat(notPossibleNumbersFromColumn.Concat(notPossibleNumbersFromRow)));
        }
    }
}