using System;
using System.Reflection;

namespace SudokuSolver
{
    public class TableFiller
    {
        private Board Table= new Board();

        public Boolean FillTable(Board board)
        {
            foreach (var cell in board.Cell)
            {
                if (cell.value != 0)
                    return TryPossibles(ref board , cell);
            }

            Table = board;
            return true;
        }


        private Boolean TryPossibles(ref Board board, Cell cell)
        {
            var possibles = new PossibleNumberProvider(board,cell);

            foreach (var possible in possibles.GetCommonPossiblesList())
            {
                var tempTable = Clone(board);
                tempTable.AssignValue(cell);
                if (FillTable(tempTable))
                {
                    board = tempTable;
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