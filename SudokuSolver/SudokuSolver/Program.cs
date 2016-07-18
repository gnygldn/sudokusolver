using System;

namespace SudokuSolver
{
    public class Program
    {
        public static Board MyBoard;

        public static int[,] Table =
        {
            {0,8,0,0,0,6,0,0,3},
            {0,6,0,0,7,0,2,0,0},
            {0,0,4,0,1,0,0,9,0},
            {0,5,0,0,0,0,8,0,1},
            {0,0,0,0,0,0,0,0,0},
            {0,1,3,0,0,0,0,6,0},
            {0,0,5,0,0,9,0,0,8},
            {0,0,0,0,2,0,0,0,0},
            {0,0,6,7,0,0,3,0,2},
        };

        public static void Main()
        {
            var board = new Board(Table);
            TableFiller tableFiller = new TableFiller();
            tableFiller.FillTable(board);
            MyBoard = tableFiller.GetTable();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(MyBoard.Cell[i, j].Value);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}