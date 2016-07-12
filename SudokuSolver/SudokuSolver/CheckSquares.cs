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
        List<int> allDigits = new List<int>(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

        public List<int> GetPossiblesSquare(int[,] table, int row, int column)
        {
            var squarePossibles = allDigits.Except(GetNotPossiblesSquare(table, row,column)).ToList();
            return squarePossibles;
        }

        public List<int> GetNotPossiblesSquare(int[,] table, int row, int column)

        {
            var notPossiblesSquare = new List<int>();
            for (int i = (row/3)*3; i < i + 3; i++)
            {
                for (int j = (column/3)*3; j < j + 3; j++)
                {
                    if(table[i,j]!=0)
                        notPossiblesSquare.Add(table[i,j]);
                }
            }
            return notPossiblesSquare;
        }
    }
}