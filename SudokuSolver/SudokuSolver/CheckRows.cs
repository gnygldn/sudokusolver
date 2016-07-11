using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public class CheckRows
    {
        private int[] allDigits = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
        private int[] notPossibles;
        private int[] rowPossibles;

        public int[] GetPossibles(int[][] table, int row)
        {
            for (int i = 0; i < 9; i++)
            {
                if (table[row][i] != 0)
                    ((IList) notPossibles).Add(table[row][i]);
            }
            rowPossibles = (int[]) allDigits.Except(notPossibles);
            return rowPossibles;
        }

        public int[] GetNotPossibles()
        {
            return notPossibles;
        }
    }
}