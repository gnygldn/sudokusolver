using System.Collections;
using System.Globalization;
using System.Linq;

namespace SudokuSolver
{
    class PossibleNumberProvider
    {
        private int[] allDigits = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
        private int[] notPossibleNumbersFromRow;
        private int[] notPossibleNumbersFromColumn;
        private int[] notPossibleNumbersFromSquare;
        public int[] commonPossiblesList;

        public PossibleNumberProvider(int[,] table, int row, int column)
        {
            CheckRows checkRows = new CheckRows();
            notPossibleNumbersFromRow = checkRows.GetNotPossibles();
            CheckColumns checkColumns = new CheckColumns();
            notPossibleNumbersFromColumn = checkColumns.GetNotPossibles();
            CheckSquares checkSquares = new CheckSquares();
            notPossibleNumbersFromSquare = checkSquares.GetNotPossibles();
            commonPossiblesList =
                (int[])
                    allDigits.Except(
                        notPossibleNumbersFromSquare.Concat(
                            notPossibleNumbersFromColumn.Concat(notPossibleNumbersFromRow)));
        }

        private int[] GetCommonPossiblesList()
        {
            return commonPossiblesList;
        }
    }
}