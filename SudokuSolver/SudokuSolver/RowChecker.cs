using System.Collections.Generic;
using System.Linq;

namespace SudokuSolver
{
    public class RowChecker
    {
        List<int> allDigits = new List<int>(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

        public List<int> GetPossiblesRow(Board table, int row)
        {
            var rowPossibles = allDigits.Except(GetNotPossiblesRow(table, row)).ToList();
            return rowPossibles;
        }

        public List<int> GetNotPossiblesRow(Board table, int row)
        {
            var notPossiblesRow = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                if (table.Cell[row, i].value != 0)
                    notPossiblesRow.Add(table.Cell[row, i].value);
            }
            return notPossiblesRow;
        }



        
    }
}