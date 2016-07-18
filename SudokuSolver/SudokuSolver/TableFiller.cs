using System;

namespace SudokuSolver
{
    public class TableFiller
    {
        private Board Table= new Board();

        public Boolean FillTable(Board board)
        {
            foreach (var cell in board.Cell)
            {
                if (cell.Value == 0)
                    return TryPossibles(ref board, cell);
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
                tempTable.AssignValue(cell,possible);
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
            board.CopyTo(tempTable);
            return tempTable;
        }


        public Board GetTable()
        {
            return Table;
        }
    }
}