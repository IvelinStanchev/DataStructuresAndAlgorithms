using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_LargestConnectedAreaOfAdjacentEmptyCells
{
    class LargestConnectedAreaOfAdjacentEmptyCells
    {
        public const char TAKEN_POSITION = 'X';
        public const char UNPASABLE_BLOCK = '*';
        public const char PASSABLE_BLOCK = ' ';
        private static char[,] field =        
        {
            {' ',' ', '*',' ','*'},
            {' ','*', ' ','*','*'},
            {' ','*', ' ',' ',' '},
            {' ','*', ' ','*','*'},
            {'*',' ', ' ',' ','*'}
        };

        private static List<Tuple<int, int>> paths = new List<Tuple<int, int>>();
        private static List<Tuple<int, int>> maxPath = new List<Tuple<int, int>>();

        static void Main()
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] == ' ')
                    {
                        paths = new List<Tuple<int, int>>();
                        FindThePath(row, col);
                        if (paths.Count > maxPath.Count)
                        {
                            maxPath = paths;
                        }
                    }
                }
            }
            PrintPath();
        }

        private static void FindThePath(int row, int col)
        {
            if (!IsInRange(row, col))
            {
                return;
            }

            if (field[row, col] != PASSABLE_BLOCK)
            {
                return;
            }

            field[row, col] = TAKEN_POSITION;
            paths.Add(new Tuple<int, int>(row, col));

            FindThePath(row, col - 1);
            FindThePath(row - 1, col);
            FindThePath(row, col + 1);
            FindThePath(row + 1, col);
        }

        private static void PrintPath()
        {
            foreach (var path in maxPath)
            {
                Console.Write("(" + string.Join(",", path) + ") -->");
            }
            Console.Write("That's the max connected path");
            Console.WriteLine();
        }

        private static bool IsInRange(int row, int col)
        {
            if (row >= 0 && row < field.GetLength(0) && col >= 0 && col < field.GetLength(1))
            {
                return true;
            }

            return false;
        }
    }
}
