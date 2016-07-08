using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public class CheckSquares
    {
        private int[] allDigits = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
        private int[] notPossibles;
        private int[] squarePossibles;

        public int[] GetPossibles(int[][] table, int row, int column)
        {
            for (int i = (row / 3); i < i + 3; i++)
            {
                for (int j = (column / 3); j < j + 3; j++)
                {
                    if (table[i][j] != 0)
                        ((IList)notPossibles).Add(table[i][j]);
                }
            }
            squarePossibles = (int[]) allDigits.Except(notPossibles);
            return squarePossibles;
        }
        

    }
}
