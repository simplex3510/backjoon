using System;

namespace baekjoon8_5
{
    class MainApp
    {
        static void AllocateRoom(bool[,] rooms, int h, int w, int n, int client)
        {
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; )
                {
                    rooms[j, i] = true;
                    client++; j++;

                    if (client == n)
                    {
                        if (i < 9)
                            Console.WriteLine($"{j}0{i + 1}");
                        else
                            Console.WriteLine($"{j}{i + 1}");
                        return;
                    }
                }
            }
        }
        static void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            string[] str = new string[0];
            int h = 0;
            int w = 0;
            int n = 0;
            int client = 0;

            for (int i = 0; i < t; i++)
            {
                str = (Console.ReadLine()).Split(' ');
                h = Convert.ToInt32(str[0]);
                w = Convert.ToInt32(str[1]);
                n = Convert.ToInt32(str[2]);
                bool[,] rooms = new bool[h, w];
                client = 0;
                AllocateRoom(rooms, h, w, n, client);
            }
        }
    }
}