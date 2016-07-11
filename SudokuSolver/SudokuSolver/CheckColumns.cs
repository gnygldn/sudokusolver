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
        readonly int[] allDigits = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
        public List<int> notPossibles = new List<int>();

        public CheckResult GetPossibles(int[,] table, int coloumn)
        {
            var result = new CheckResult();
            for (int i = 0; i < 9; i++)
            {
                if (table[i, coloumn] != 0)
                {
                    result.AddPossible(table[i, coloumn]);
                }
            }
            return  allDigits.Except(notPossibles).ToArray();
            
            
        }

        public int[] GetNotPossibles()
        {
            return notPossibles.ToArray();
        }
    }

    public class CheckResult
    {
        public void AddPossible(int i)
        {
            throw new NotImplementedException();
        }
    }
}