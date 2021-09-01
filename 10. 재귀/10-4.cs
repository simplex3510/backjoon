using System;
using System.Text;

namespace baekjoon10_2
{
    class MainApp
    {
        static StringBuilder sb = new StringBuilder();
        static int count = 0;
        static void hanoi(int n, char from, char temp, char to)
        {
            count++;

            if (n == 1)
            {
                sb.Append($"{from} {to}\n");
            }
            else
            {
                hanoi(n-1, from, to, temp);
                sb.Append($"{from} {to}\n");
                hanoi(n-1, temp, from, to);
            }
        }


        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            hanoi(n, '1', '2', '3');
            Console.WriteLine(count);
            Console.WriteLine(sb);

        }
    }
}