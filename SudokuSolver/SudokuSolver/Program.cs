namespace SudokuSolver
{
    public class Program
    {
        public static int[,] table;

        static void main(string[] args)
        {
            FillTable fillTable = new FillTable();
            fillTable.TableFiller(table);
            fillTable.GetTable();
        }
    }
}