using System;


namespace SpecialValue
{
    class SpecialValue
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[][] board = new int[n][];

            for (int i = 0; i < board.GetLength(0); i++)
            {
                string[] boardLine = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                board[i] = new int[boardLine.Length];

                for (int j = 0; j < boardLine.Length; j++)
                {
                    board[i][j] = int.Parse(boardLine[j]);
                }
            }

            bool[][] visited = new bool[n][];

            for (int i = 0; i < n; i++)
            {
                visited[i] = new bool[board[i].Length];
            }

            long maxSpecialValue = 0;

            for (int i = 0; i < board[0].Length; i++)
            {
                long currentSpecialValue = CalculateSpecialValue(board, visited, i);
                if (currentSpecialValue > maxSpecialValue)
                {
                    maxSpecialValue = currentSpecialValue;
                }
            }

            Console.WriteLine(maxSpecialValue);
        }

        static long CalculateSpecialValue(int[][] board, bool[][] visited, int column)
        {
            long currentSpecialValue = 0;
            int currentRow = 0;

            while (true)
            {
                currentSpecialValue++;

                if (visited[currentRow][column])
                {
                    return 0;
                }

                if (board[currentRow][column] < 0)
                {
                    currentSpecialValue -= board[currentRow][column];
                    return currentSpecialValue;
                }

                visited[currentRow][column] = true;
                int nextColumn = board[currentRow][column];
                column = nextColumn;

                currentRow++;
                if (currentRow == board.GetLength(0))
                {
                    currentRow = 0;
                }

            }
        }
    }
}