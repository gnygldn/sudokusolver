using System.Collections.Generic;

namespace SudokuSolver
{
    public class Board
    {
        public Cell[,] Cell = new Cell[9,9];

        public IEnumerable<int> Values
        {
            get
            {
                foreach (var cell in Cell)
                {
                    yield return cell.Value;
                }
            }
        }

        public Board(int[,] data)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    Cell[row, column] = new Cell
                    {
                        Row = row,
                        Column = column,
                        Value = data[row, column]
                    };
                }
            }
        }

        public Board()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    Cell[row, column] = new Cell
                    {
                        Row = row,
                        Column = column
                    };
                }
            }
        }

        public void CloneTo(Board table)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    table.Cell[row, column].Value = Cell[row, column].Value;
                }
            }

        }

        public void AssignValue(Cell cell,int possible)
        {
            Cell[cell.Row, cell.Column].Value = possible;
        }
    }
}