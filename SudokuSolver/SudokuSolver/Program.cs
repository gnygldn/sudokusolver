using System;

namespace SudokuSolver
{
    public class Program
    {
        public static Board MyBoard;

        public static int[,] Table =
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

        public static void Main()
        {
            var board = new Board(Table);
            TableFiller tableFiller = new TableFiller();
            tableFiller.FillTable(board);
            MyBoard = tableFiller.GetTable();
            Console.WriteLine(MyBoard);
            Console.ReadKey();
        }
    }
}