using System;
using System.Collections.Generic;

namespace SudokuSolver
{
    public class Board
    {
        public Cell[,] Cell = new Cell[9, 9];

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

        public Board(int[,] data = null)
        {
            Traverse((row, column) => { CreateCell(row, column, data); });
        }

        private void CreateCell(int row, int column, int[,] data = null)
        {
            Cell[row, column] = new Cell
            {
                Row = row,
                Column = column,
            };

            if (data != null)
            {
                Cell[row, column].Value = data[row, column];
            }
        }

        public void Traverse(Action<int, int> action)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    action(row, column);
                }
            }
        }

        public void CopyTo(Board table)
        {
            Traverse((row, column) => { table.Cell[row, column].Value = Cell[row, column].Value; });
        }


        public void AssignValue(Cell cell, int possible)
        {
            Cell[cell.Row, cell.Column].Value = possible;
        }
    }
}