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

            //Този string се използва за да няма повторение на числата. Когато едно число не може да се постави, няма смисъл да го проверяваме пак
            string str = string.Empty;
            int a = 0;

            for (int i = 0; i < LENGTH + 5; i++)
            //while (LENGTH > str.Length)
            {
                //генериране на рандом число
                int row = rnd.Next(0, LENGTH);
                a = row;

                //проверяваме дали сме използвали това число
                //if (str.Contains(row.ToString()))
                {
                    //ако числото е използвано се връщаме в началото на цикъла за да генерираме ново
                   // continue;      
                }
                //добавяме числото към използваните числа
                str += row.ToString();

                //проверяваме дали може да се постави кралица и я добавяме
                if (IsSafe(col, row))
                {
                    board[row, col] = QUEEN;

                    str = string.Empty;
                    Find(col + 1);
                }

            }
            //ако в никоя позиция не може да се постави царица нулираме полетата
            for (int i = 0; i < LENGTH; i++)
            {
                board[i, col - 1] = '\0';
                board[i, col - 2] = '\0';
            }
            str = string.Empty;
            Console.WriteLine("Remove " + a);
            Find(col - 2);
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
