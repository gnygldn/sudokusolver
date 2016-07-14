using System;
using System.Reflection;

namespace SudokuSolver
{
    public class TableFiller
    {
        private Board Table= new Board();

        public Boolean FillTable(Board table)
        {
            foreach (var cell in table.Cell)
            {
                if (cell.value != 0)
                    return TryPossibles(table , cell);
            }

            Table = table;
            return true;
        }


        private Boolean TryPossibles(Board table, Cell cell)
        {
            var possibles = new PossibleNumberProvider(table,cell);

            foreach (var possible in possibles.GetCommonPossiblesList())
            {
                var tempTable = new Board();
                tempTable = Clone(table);
                tempTable.AssignValue(cell);
                

                if (FillTable(tempTable))
                {
                    table = tempTable;
                    return true;
                }
            }
            return false;
        }

        public Board Clone(Board board)
        {
            var tempTable = new Board();
            board.CloneTo(tempTable);
            return tempTable;
        }


        public Board GetTable()
        {
            return Table;
        }
    }
}