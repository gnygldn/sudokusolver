using System.Collections;
using System.Globalization;
using System.Linq;

namespace SudokuSolver
{
    class PossibleNumberProvider
    {
        private int[] possibleNumbersFromRow;
        private int[] possibleNumbersFromColumn;
        private int[] possibleNumbersFromSquare;
        private int[] commonPossibleList;

        public PossibleNumberProvider(int[][] table, int row, int column)
        {
            Rows rows = new Rows();
            possibleNumbersFromRow = rows.GetPossibles(table, row);
            Columns columns = new Columns();
            possibleNumbersFromColumn = columns.GetPossibles(table, column);
            Squares squares = new Squares();
            possibleNumbersFromSquare = squares.GetPossibles(table, row, column);
            FindCommonPossiblesList();
        }

        private int[] FindCommonPossiblesList()
        {
            return commonPossibleList;
        }
    }
}
