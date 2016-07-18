using NUnit.Framework;
using FluentAssertions;
using SudokuSolver;

namespace SudokuSolverFixer
{
    class TestCheckFillTable
    {
        private static readonly int[,] Table =
        {
            {0, 0, 3, 9, 0, 0, 0, 5, 1},
            {5, 4, 6, 0, 1, 8, 3, 0, 0},
            {0, 0, 0, 0, 0, 7, 4, 2, 0},
            {0, 0, 9, 0, 5, 0, 0, 3, 0},
            {2, 0, 0, 6, 0, 3, 0, 0, 4},
            {0, 8, 0, 0, 7, 0, 2, 0, 0},
            {0, 9, 7, 3, 0, 0, 0, 0, 0},
            {0, 0, 1, 8, 2, 0, 9, 4, 7},
            {8, 5, 0, 0, 0, 4, 6, 0, 0},
        };

        private static readonly int[,] Table2 =
        {
            {7, 2, 3, 9, 4, 6, 8, 5, 1},
            {5, 4, 6, 2, 1, 8, 3, 7, 9},
            {9, 1, 8, 5, 3, 7, 4, 2, 6},
            {1, 6, 9, 4, 5, 2, 7, 3, 8},
            {2, 7, 5, 6, 8, 3, 1, 9, 4},
            {3, 8, 4, 1, 7, 9, 2, 6, 5},
            {4, 9, 7, 3, 6, 1, 5, 8, 2},
            {6, 3, 1, 8, 2, 5, 9, 4, 7},
            {8, 5, 2, 7, 9, 4, 6, 1, 3},
        };

        private readonly Board _board = new Board(Table);
        public readonly Board Board2 = new Board(Table2);

        [Test]
        public void FixCheckFillTable()
        {
            var response = new TableFiller();
            response.FillTable(_board);
            response.GetTable().Values.ShouldBeEquivalentTo(Board2.Values);
        }
    }
}