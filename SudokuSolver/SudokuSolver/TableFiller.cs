using System;
using System.Reflection;

namespace SudokuSolver
{
    public class TableFiller
    {
        private int[,] Table;

        public Boolean FillTable(Board table)
        {
            foreach (var cell in table.cell)
            {
                if (cell.value != 0)
                    return TryPossibles();
            }

            Table = table;
            return true;
        }


        private Boolean TryPossibles(int[,] table, int row, int column)
        {
            PossibleNumberProvider possibles = new PossibleNumberProvider(table, row, column);

            foreach (var possible in possibles.GetCommonPossiblesList())
            {
                var tempTable = new Board();
                tempTable = table.Clone();

                if (FillTable(tempTable))
                {
                    table = tempTable.Copy();
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