using System;

namespace QueenChess
{
    class Program
    {
        private const int LENGTH = 8;
        private static readonly char[,] board = new char[LENGTH, LENGTH];
        private const char TAKEN_FIELD = '*';
        private const char QUEEN = 'O';
        static void Main()
        {
            while (true)
            {
                Display();

                Console.Write("Enter position: ");
                string position = Console.ReadLine();

                int y = int.Parse(position[0].ToString());
                int x = int.Parse(position[1].ToString());

                if (board[y, x] == '\0')
                {
                    AddQueen(y, x);
                }
                else if (board[y, x] == QUEEN)
                {
                    string[] queens = new string[LENGTH];
                    int index = 0;

                    for (int i = 0; i < LENGTH; i++)
                    {
                        for (int j = 0; j < LENGTH; j++)
                        {
                            string tempIndex = $"{i}{j}";
                            if (board[i, j] == QUEEN && tempIndex != position)
                            {
                                queens[index] = tempIndex;
                                index++;
                            }
                            board[i, j] = '\0';
                        }
                    }

                    for (int i = 0; i < index; i++)
                    {
                        y = int.Parse(queens[i][0].ToString());
                        x = int.Parse(queens[i][1].ToString());
                        
                        AddQueen(y, x);
                    }
                }
                else
                {
                    Console.WriteLine("Taken position! Try another one");
                    continue;
                }
            }
        }

        static void AddQueen(int y, int x)
        {
            board[y, x] = 'O';

            int yTemp = y - 1;

            //sides
            while (yTemp >= 0)
            {
                board[yTemp, x] = TAKEN_FIELD;
                yTemp--;
            }
            yTemp = y + 1;

            while (yTemp < 8)
            {
                board[yTemp, x] = TAKEN_FIELD;
                yTemp++;
            }

            int xTemp = x - 1;
            while (xTemp >= 0)
            {
                board[y, xTemp] = TAKEN_FIELD;
                xTemp--;
            }
            xTemp = x + 1;
            while (xTemp < 8)
            {
                board[y, xTemp] = TAKEN_FIELD;
                xTemp++;
            }

            //diagonals
            xTemp = x - 1;
            yTemp = y - 1;
            while (xTemp >= 0 && yTemp >= 0)
            {
                board[yTemp, xTemp] = TAKEN_FIELD;
                yTemp--;
                xTemp--;
            }
            xTemp = x - 1;
            yTemp = y + 1;
            while (xTemp >= 0 && yTemp < 8)
            {
                board[yTemp, xTemp] = TAKEN_FIELD;
                yTemp++;
                xTemp--;
            }
            xTemp = x + 1;
            yTemp = y + 1;
            while (xTemp < 8 && yTemp < 8)
            {
                board[yTemp, xTemp] = TAKEN_FIELD;
                yTemp++;
                xTemp++;
            }
            xTemp = x + 1;
            yTemp = y - 1;
            while (xTemp < 8 && yTemp >= 0)
            {
                board[yTemp, xTemp] = TAKEN_FIELD;
                yTemp--;
                xTemp++;
            }
        }
        static void Display()
        {
            for (int i = 0; i < LENGTH; i++)
            {
                for (int j = 0; j < LENGTH; j++)
                {
                    if (board[i,j] == '\0')
                    {
                        Console.Write(" - ");
                        continue;
                    }
                    Console.Write($" {board[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            for (int i = 0; i < LENGTH; i++)
            {
                for (int j = 0; j < LENGTH; j++)
                {
                    Console.Write($"{i}{j} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
