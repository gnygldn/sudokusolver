using System.Linq;
using NUnit.Framework;
using FluentAssertions;
using SudokuSolver;

namespace SudokuSolverFixer
{
    class TestCheckFillTable
    {
        private static int[,] table =
        {
            {0, 4, 5, 8, 0, 3, 7, 1, 0},
            {8, 1, 0, 0, 0, 0, 0, 2, 4},
            {7, 0, 9, 0, 0, 0, 5, 0, 8},
            {0, 0, 0, 9, 0, 7, 0, 0, 0},
            {0, 0, 0, 0, 6, 0, 0, 0, 0},
            {0, 0, 0, 4, 0, 2, 0, 0, 0},
            {6, 0, 4, 0, 0, 0, 3, 0, 5},
            {3, 2, 0, 0, 0, 0, 0, 8, 7},
            {0, 5, 7, 3, 0, 8, 2, 6, 0},
        };

        private static int[,] table2 =
        {
            {2, 4, 5, 8, 9, 3, 7, 1, 6},
            {8, 1, 3, 5, 7, 6, 9, 2, 4},
            {7, 6, 9, 2, 1, 4, 5, 3, 8},
            {5, 3, 6, 9, 8, 7, 1, 4, 2},
            {4, 9, 2, 1, 6, 5, 8, 7, 3},
            {1, 7, 8, 4, 3, 2, 6, 5, 9},
            {6, 8, 4, 7, 2, 1, 3, 9, 5},
            {3, 2, 1, 6, 5, 9, 4, 8, 7},
            {9, 5, 7, 3, 4, 8, 2, 6, 1},
        };

        Board board = new Board(table);
        Board board2 = new Board(table2);

        [Test]
        public void FixCheckFillTable()
        {
            var response = new TableFiller();
            response.FillTable(board);
            response.GetTable().Values.ShouldBeEquivalentTo(board2.Values);
        }
    }
}