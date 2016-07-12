using System;

namespace SudokuSolver
{
    public class FillTable
    {
        private int[,] Table;

        public Boolean TableFiller(int[,] table)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    if (table[row, column] == 0)
                    {
                        TryPossibles(table,row,column);
                    }
                }
            }
            Table = table;
            return true;
        }

        private int[,] CloneAtoB(int[,] A,ref int[,] B)
        {
            for (int k = 0; k < 9; k++)
            {
                for (int l = 0; l < 9; l++)
                {
                    B[k, l] = A[k, l];
                }
            }
            return B;
        }

        private Boolean TryPossibles(int[,] table,int row,int column)
        {
            PossibleNumberProvider possibles = new PossibleNumberProvider(table, row, column);

            foreach (var possible in possibles.GetCommonPossiblesList())
            {
                var tempTable = new int[9, 9];
                CloneAtoB(table, ref tempTable);
                tempTable[row, column] = possible;

                if (TableFiller(tempTable))
                {
                    CloneAtoB(tempTable, ref table);
                    return true;
                }
            }
            return false;
        }


        public int[,] GetTable()
        {
            return Table;
        }
    }
}