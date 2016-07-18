using System;
using System.Collections.Generic;

namespace SudokuSolver
{
    public class TableFiller
    {
        private Board _table = new Board();

        public Boolean FillTable(Board board)
        {
            foreach (var cell in board.Cell)
            {
                if (cell.Value == 0)
                    return TryPossibles(board, cell);
            }

            _table = board;
            return true;
        }


        private Boolean TryPossibles(Board board, Cell cell)
        {
            var possibles = new PossibleNumberProvider(board, cell);

            foreach (var possible in possibles.GetCommonPossiblesList())
            {
                var tempTable = Clone(board);
                tempTable.AssignValue(cell, possible);
                if (FillTable(tempTable))
                {
                    return true;
                }
            }
            return false;
        }

        public Board Clone(Board board)
        {
            var tempTable = new Board();
            board.CopyTo(tempTable);
            return tempTable;
        }


        public Board GetTable()
        {
            return _table;
        }
    }
}