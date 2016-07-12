using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SudokuSolver
{
    class PossibleNumberProvider
    {
        List<int> allDigits = new List<int>(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        private List<int> notPossibleNumbersFromRow;
        private List<int> notPossibleNumbersFromColumn;
        private List<int> notPossibleNumbersFromSquare;
       

        public PossibleNumberProvider(int[,] table, int row, int column)
        {
            CheckRows checkRows = new CheckRows();
            notPossibleNumbersFromRow = checkRows.GetNotPossiblesRow(table,row);
            CheckColumns checkColumns = new CheckColumns();
            notPossibleNumbersFromColumn = checkColumns.GetNotPossiblesColumn(table,column);
            CheckSquares checkSquares = new CheckSquares();
            notPossibleNumbersFromSquare = checkSquares.GetNotPossiblesSquare(table,row,column);
                
        }

        public int[] GetCommonPossiblesList()
        {
            return (int[])
                    allDigits.Except(
                        notPossibleNumbersFromSquare.Concat(
                            notPossibleNumbersFromColumn.Concat(notPossibleNumbersFromRow)));
        }
    }
}