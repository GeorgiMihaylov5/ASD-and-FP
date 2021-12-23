using System;
using System.Threading;

namespace AutomaticSolution
{
    class Program
    {
        private const int LENGTH = 8;
        private static readonly char[,] board = new char[LENGTH, LENGTH];
        private const char QUEEN = 'O';
        private static Random rnd = new Random();
        static void Main()
        {
            Find(0);
        }
        static void Find(int col)
        {
            Display();

            //Дъно на рекурсията
            for (int i = 0; i < LENGTH; i++)
            {
                if (board[i, LENGTH - 1] == QUEEN)
                {
                    Console.WriteLine("FINISH!");
                    Environment.Exit(-1);
                }
            }

            for (int i = 0; i < LENGTH + 5; i++)
            {
                //генериране на рандом число
                int row = rnd.Next(0, LENGTH);

                //проверяваме дали може да се постави кралица и я добавяме
                if (IsSafe(col, row))
                {
                    board[row, col] = QUEEN;

                    Find(col + 1);
                }

            }
            
            int n = col - 2 < 0 ? 1 : 2;

            //ако в никоя позиция не може да се постави царица нулираме полетата в колоната
            for (int i = 0; i < LENGTH; i++)
            {
                board[i, col - 1] = '\0';
                board[i, col - n] = '\0';
            }
            Console.WriteLine("Remove");
            Find(col - n);
        }
        
        static bool IsSafe(int col, int row)
        {
            //проверка на ред
            for (int i = 0; i < LENGTH; i++)
            {
                if (board[row,i] == QUEEN)
                {
                    return false;
                }
            }
            //проверка на диагонали

            for (int i = row, j = col; i >= 0 && j >= 0; i--,j--)
            {
                if (board[i, j] == QUEEN)
                {
                    return false;
                }
            }

            for (int i = row, j = col; i < LENGTH && j >= 0; i++, j--)
            {
                if (board[i, j] == QUEEN)
                {
                    return false;
                }
            }
            return true;
        }
        //принтиране на масива
        static void Display()
        {
            for (int i = 0; i < LENGTH; i++)
            {
                for (int j = 0; j < LENGTH; j++)
                {
                    if (board[i, j] == '\0')
                    {
                        Console.Write(" - ");
                        continue;
                    }
                    Console.Write($" {board[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
