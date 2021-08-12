

using System;

namespace baekjoon7_5
{
    class MainApp
    {
        static char frequency(string str)
        {
            int[] arr = new int[26];
            int most = 0;
            int idx = 0;
            int overlap = 0;

            for (int i = 0; i < str.Length; i++)    // 문자 출현 빈도 검사
            {
                if (65 <= str[i] && str[i] <= 90)
                {
                    arr[str[i] - 65]++;
                }
                else if (97 <= str[i] && str[i] <= 122)
                {
                    arr[str[i] - 97]++;
                }
            }

            for (int j = 0; j < arr.Length; j++)    // 최빈값 검사
            {
                if (most < arr[j])
                {
                    most = arr[j];
                    idx = j;
                }
            }

            for (int l = 0; l < arr.Length; l++)    // 중복 검사
            {
                if (most == arr[l])
                    overlap++;
            }

            if (1 < overlap)
                return '?';
            else
                return (char)(idx + 65);
        }

        static void Main()
        {
            string str = Console.ReadLine();
            Console.WriteLine(frequency(str));
        }
    }

}
