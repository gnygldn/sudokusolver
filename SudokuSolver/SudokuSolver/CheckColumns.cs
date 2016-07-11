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
        private int[] allDigits = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
        public int[] notPossibles = new int[9];
        public int[] columnPossibles;

        public int[] GetPossibles(int[,] table, int coloumn)
        {
            for (int i = 0; i < 9; i++)
            {
                if (table[i, coloumn] != 0)
                {
                    notPossibles[0] = table[i, coloumn];
                }//((IList) notPossibles).Add(table[i,coloumn]);
            }
            //columnPossibles = (int[]) allDigits.Except(notPossibles);
            columnPossibles = new int[] {1, 3, 4, 5, 6, 7, 8, 9};
            return columnPossibles;
        }

        public int[] GetNotPossibles()
        {
            return notPossibles;
        }
    }
}