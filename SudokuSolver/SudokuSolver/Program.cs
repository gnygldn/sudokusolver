﻿using System;

namespace SudokuSolver
{
    public class Program
    {
        public static int[,] table =
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

        static void main(string[] args)
        {
            TableFiller tableFiller = new TableFiller();
            tableFiller.FillTable(table);
            Console.WriteLine(tableFiller.GetTable());
            Console.ReadKey();
        }
    }
}