using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;
using SudokuSolver;

namespace SudokuSolverFixer
{
    [TestFixture]
    public class TestCheckColumns
    {
        private int[,] table=
        {
            {0,0,0,0,0,0,0,0,0,},
            {1,3,2,0,0,0,0,0,0,},
            {0,0,0,0,0,0,0,0,0,},
            {0,0,0,0,0,0,0,0,0,},
            {0,0,0,0,0,0,0,0,0,},
            {0,0,0,0,0,0,0,0,0,},
            {0,0,0,0,0,0,0,0,0,},
            {0,0,0,0,0,0,0,0,0,},
            {0,0,0,0,0,0,0,0,0,},
        };

        [Test]
        public void FixCheckColumns()
        {
            var response = new CheckColumns();
            var (possibles, notpossibles) = response.GetPossibles(table, 2);
            response.columnPossibles.Should().BeEquivalentTo(new[] {1, 3, 4, 5, 6, 7, 8, 9});
        }



    }
}
