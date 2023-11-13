using System;
using System.Text;
using System.Collections;

namespace baekjoon12_10
{
    class MainApp
    {

        static void Zip(int[] origin, int[] zip, int[] non_lap)
        {
            for (int i = 0; i < zip.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < non_lap.Length; j++)
                {
                    if (non_lap[j] < origin[i])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                zip[i] = count;
            }
        }

        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int testCase = Convert.ToInt32(Console.ReadLine());
            string[] str = Console.ReadLine().Split();
            int[] origin = new int[testCase];
            int[] non_lap = new int[testCase];
            int[] zip    = new int[testCase];

            for (int i = 0; i < origin.Length; i++)
            {
                origin[i] = Convert.ToInt32(str[i]);
            }

            for (int i = 0; i < non_lap.Length; i++)
            {
                non_lap[i] = Convert.ToInt32(str[i]);
                for (int j = 0; j < i; j++)
                {
                    if (non_lap[i] == non_lap[j])
                    {
                        non_lap[i] = int.MaxValue;
                        testCase--;
                        break;
                    }
                }
            }

            Array.Sort(non_lap);
            Array.Resize(ref non_lap, testCase);

            Zip(origin, zip, non_lap);

            // 출력
            for (int i = 0; i < zip.Length; i++)
            {
                sb.Append(zip[i] + " ");
            }
            Console.Write(sb);
        }
    }
}