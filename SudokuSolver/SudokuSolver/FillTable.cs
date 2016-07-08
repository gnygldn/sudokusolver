using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public class FillTable
    {
        private int row;
        private int column;

        public Boolean TableFiller(int[][] table)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    if (table[row][column] == 0)
                    {
                        PossibleNumberProvider possibles = new PossibleNumberProvider(table, row, column);
                        foreach (var possible in possibles.commonPossiblesList)
                        {
                            var tempTable = new int[][];
                            for (int k = 0; k < 9; k++)
                            {
                                for (int l = 0; l < 9; l++)
                                {
                                    tempTable[k][l] = table[k][l];
                                }
                            }
                            tempTable[row][column] = possible;
                            if (TableFiller(tempTable))
                            {
                                for (int k = 0; k < 9; k++)
                                {
                                    for (int l = 0; l < 9; l++)
                                    {
                                        table[k][l] = tempTable[k][l];
                                    }
                                }
                                return true;
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }
    }
}