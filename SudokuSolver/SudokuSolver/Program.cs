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