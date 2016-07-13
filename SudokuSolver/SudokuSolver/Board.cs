using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public class Board
    {
        private Cell cell { get; set; }
        private int[,] data { get; set; }

        public int[,] Clone()
        {
            return data;
        }

        public int[,] Copy();
        {
            return this;
        }
    }
}