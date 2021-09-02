using System;

namespace baekjoon11_1
{
    class MainApp
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;
            int diff = int.MinValue;

            for (int i = 0; i < n; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(j == i)
                        continue;

                    for (int k = 0; k < n; k++)
                    {
                        if(k == i || k == j)
                            continue;
                        
                    }
                }
            }
        }
    }
}