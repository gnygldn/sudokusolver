using System.Collections;
using System.Globalization;
using System.Linq;

namespace SudokuSolver
{
    class PossibleNumberProvider
    {
        private int[] allDigits = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private int[] possibleNumbersFromRow;
        private int[] possibleNumbersFromColumn;
        private int[] possibleNumbersFromSquare;
        public int[] commonPossiblesList;

        public PossibleNumberProvider(int[][] table, int row, int column)
        {
            CheckRows checkRows = new CheckRows();
            possibleNumbersFromRow = checkRows.GetPossibles(table, row);
            CheckColumns checkColumns = new CheckColumns();
            possibleNumbersFromColumn = checkColumns.GetPossibles(table, column);
            CheckSquares checkSquares = new CheckSquares();
            possibleNumbersFromSquare = checkSquares.GetPossibles(table, row, column);
            FindCommonPossiblesList();
        }

        private int[] FindCommonPossiblesList()
        {
            foreach (var number in possibleNumbersFromRow)
            {
                if(number in commonPossiblesList)
            }
            return commonPossiblesList;
        }
    }
}
