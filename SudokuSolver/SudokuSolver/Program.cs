using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public class Program
    {
        private static int[][] table;

        static void main(string[] args)
        {
            FillTable fillTable = new FillTable();
            fillTable.TableFiller(table);
        }
    }
}
