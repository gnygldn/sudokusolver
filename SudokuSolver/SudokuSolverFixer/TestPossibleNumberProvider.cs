using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;
using SudokuSolver;

namespace SudokuSolverFixer
{
    class TestPossibleNumberProvider
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
        Board board = new Board(table);

        [Test]
        public void FixCheckPossibleNumberProvider()
        {
            var response = new PossibleNumberProvider(board,board.Cell[0,0]);
            response.GetCommonPossiblesList().Should().BeEquivalentTo(new[] { 2});
        }
    }
}
