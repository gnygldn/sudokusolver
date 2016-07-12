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
    public class TestCheckRows
    {
        private int[,] table;

        [Test]
        public void FixCheckRows()
        {
            var response = new CheckRows();
            response.GetPossiblesRow(table, 3);
            response.rowPossibles.Should().BeEquivalentTo(new[] { 1, 3, 4, 5, 6, 7, 8, 9 }); 
        }

    }
}
