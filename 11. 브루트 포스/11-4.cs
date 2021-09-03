using System;

namespace baekjoon11_3
{
    class MainApp
    {
        static void Init(char[,] board, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                char[] temp = Console.ReadLine().ToCharArray();
                for (int j = 0; j < m; j++)
                {
                    board[i, j] = temp[j];
                }
            }
        }

        static int BlackFirstBoard(char[,] board, int x, int y)
        {
            int count = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (board[i + y, j + x] == 'B' && board[i + y, j + x + 1] == 'W')
                            j++;
                        else if (board[i + y, j + x] == 'W' && board[i + y, j + x + 1] == 'B')
                        {
                            count += 2;
                            j++;
                        }
                        else
                        {
                            count++;
                            j++;
                        }
                    }
                    else
                    {
                        if (board[i + y, j + x] == 'W' && board[i + y, j + x + 1] == 'B')
                            j++;
                        else if (board[i + y, j + x] == 'B' && board[i + y, j + x + 1] == 'W')
                        {
                            count += 2;
                            j++;
                        }
                        else
                        {
                            count++;
                            j++;
                        }
                    }
                }

                // for (int k = 0; k < 8; k++)
                // {
                //     Console.Write(board[i + y, k + x]);
                // }
                // Console.Write(" - " + count);
                // Console.WriteLine();
            }
            //Console.WriteLine($"B: {count}");
            return count;
        }

        static int WhiteFirstBoard(char[,] board, int x, int y)
        {
            int count = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (board[i + y, j + x] == 'W' && board[i + y, j + x + 1] == 'B')
                            j++;
                        else if (board[i + y, j + x] == 'B' && board[i + y, j + x + 1] == 'W')
                        {
                            count += 2;
                            j++;
                        }
                        else
                        {
                            count++;
                            j++;
                        }
                    }
                    else
                    {
                        if (board[i + y, j + x] == 'B' && board[i + y, j + x + 1] == 'W')
                            j++;
                        else if (board[i + y, j + x] == 'W' && board[i + y, j + x + 1] == 'B')
                        {
                            count += 2;
                            j++;
                        }
                        else
                        {
                            count++;
                            j++;
                        }
                    }
                }

                // for (int k = 0; k < 8; k++)
                // {
                //     Console.Write(board[i + y, k + x]);
                // }
                // Console.Write(" - " + count);
                // Console.WriteLine();
            }
            //Console.WriteLine($"W: {count}");

            return count;
        }

        static void Main()
        {
            string[] str = Console.ReadLine().Split();
            int n = Convert.ToInt32(str[0]), m = Convert.ToInt32(str[1]);
            char[,] board = new char[n, m];
            int min = int.MaxValue;
            int temp = 0;

            // 초기화
            Init(board, n, m);

            // 외부 연산(전체 크기)
            for (int y = 0; y < n - 7; y++)
            {
                for (int x = 0; x < m - 7; x++)
                {
                    temp = BlackFirstBoard(board, x, y);
                    min = temp < min ? temp : min;

                    temp = WhiteFirstBoard(board, x, y);
                    min = temp < min ? temp : min;
                }
            }
            Console.WriteLine(min);
        }
    }
}