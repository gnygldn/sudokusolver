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
            {0, 0, 0, 0, 0, 0, 0, 0, 0,},
            {1, 3, 2, 0, 0, 0, 0, 0, 0,},
            {0, 2, 0, 9, 0, 0, 0, 0, 0,},
            {0, 0, 0, 8, 4, 0, 5, 0, 0,},
            {0, 0, 0, 0, 0, 7, 0, 0, 0,},
            {0, 0, 0, 0, 0, 0, 0, 0, 0,},
            {0, 0, 0, 6, 0, 0, 0, 0, 0,},
            {0, 0, 0, 0, 0, 0, 0, 0, 0,},
            {0, 0, 0, 0, 0, 0, 0, 0, 0,},
        };
        Board board = new Board(table);

        [Test]
        public void FixCheckPossibleNumberProvider()
        {
            var response = new PossibleNumberProvider(board,board.Cell[3,3]);
            response.GetCommonPossiblesList().Should().BeEquivalentTo(new[] { 1, 2, 3});
        }
    }
}
