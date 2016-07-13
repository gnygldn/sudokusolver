﻿using System.Collections.Generic;
using System.Linq;

namespace SudokuSolver
{
    public class RowChecker
    {
        List<int> allDigits = new List<int>(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

        public List<int> GetPossiblesRow(int[,] table, int row)
        {
            var rowPossibles = allDigits.Except(GetNotPossiblesRow(table, row)).ToList();
            return rowPossibles;
        }

        public List<int> GetNotPossiblesRow(int[,] table, int row)
        {
            var notPossiblesRow = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                if (table[row, i] != 0)
                    notPossiblesRow.Add(table[row, i]);
            }
            return notPossiblesRow;
        }

        
    }
}