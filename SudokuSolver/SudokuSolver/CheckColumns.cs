using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public class CheckColumns
    {
        List<int> allDigits = new List<int>(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9});

        public List<int> GetPossiblesColumn(int[,] table, int column)
        {
            var columnPossibles = allDigits.Except(GetNotPossiblesColumn(table, column)).ToList();
            return columnPossibles;
        }

        public List<int> GetNotPossiblesColumn(int[,] table, int column)
        {
            var notPossiblesColumn = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                if (table[i, column] != 0)
                    notPossiblesColumn.Add(table[i, column]);
            }
            return notPossiblesColumn;
        }
    }
}

}