// using System;
// using System.Text;
// using System.IO;

// namespace baekjoon12_3
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             // var sw = new StreamWriter(Console.OpenStandardOutput());
//             StringBuilder sb = new StringBuilder();

//             int testCase = int.Parse(Console.ReadLine());
//             int[] arr = new int[testCase];
//             int[] count = new int[8001];

//             double avg = 0, sum = 0;                 // 평균, 총합
//             int median = 0, mode = 0, range = 0;    // 중앙값, 최빈값, 범위
//             int max = int.MinValue, min = int.MaxValue;

//             for (int i = 0; i < testCase; i++)      // 입력
//             {
//                 int num = int.Parse(Console.ReadLine());
//                 arr[i] = num;
//                 count[4000 + num]++;                  // 4000을 0으로 간주
//                 sum += num;                           // 평균 계산을 위한 누적합
//                 if (max < num) max = num;
//                 if (num < min) min = num;
//             }

//             Array.Sort(arr);

//             avg = sum / testCase;           // 산술평균
//             median = arr[testCase / 2];     // 중앙값
//             mode = Mode(count, max, min);   // 최빈값
//             range = max - min;              // 범위

//             Console.WriteLine("{0}", (int)Math.Round(avg));
//             Console.WriteLine(median);
//             Console.WriteLine(mode);
//             Console.WriteLine(range);

//         }

//         // 최빈값 함수
//         static int Mode(int[] count, int max, int min)
//         {
//             bool overlap = false;
//             int freq = 0;
//             int num = 0;

//             for (int i = min + 4000; i <= max + 4000; i++)
//             {
//                 if (freq < count[i])
//                 {
//                     freq = count[i];
//                     num = i;
//                 }
//             }

//             for (int i = min + 4000; i <= max + 4000; i++)
//             {
//                 if (freq == count[i] && overlap == true)
//                 {
//                     num = i;
//                     return num - 4000;
//                 }
//                 else if(freq == count[i])
//                 {
//                     overlap = true;
//                 }
//             }

//             return num - 4000;
//         }
//     }
// }