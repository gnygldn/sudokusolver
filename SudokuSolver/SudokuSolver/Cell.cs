using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public class Cell
    {
        public int row { get; set; }
        public int column { get; set; }
        public int value { get; set; }
    }
}