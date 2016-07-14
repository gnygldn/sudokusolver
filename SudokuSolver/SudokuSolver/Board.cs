using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public class Board
    {
        public Cell[,] Cell = new Cell[9,9];

        public Board(int[,] data)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    Cell[row, column].row = row;
                    Cell[row, column].column = column;
                    Cell[row, column].value = data[row, column];
                }
            }
        }

        public Board()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    Cell[row, column].row = row;
                    Cell[row, column].column = column;
                }
            }
        }

        public void CloneTo(Board table)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    table.Cell[row, column].value = Cell[row, column].value;
                }
            }

        }
    }
}