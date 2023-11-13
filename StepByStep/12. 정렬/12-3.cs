// using System;
// using System.Text;
// using System.IO;

// namespace baekjoon12_3
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             int[] counting = new int[10_001];

//             //var sr = new StreamReader(Console.OpenStandardInput());
//             var sw = new StreamWriter(Console.OpenStandardOutput());
//             StringBuilder sb = new StringBuilder();
//             int testCase = int.Parse(Console.ReadLine());
//             int max = int.MinValue;
//             int num = 0;

//             for (int i = 0; i < testCase; i++)    // 카운팅
//             {
//                 num = int.Parse(Console.ReadLine());
//                 counting[num]++;
//                 if (max < num)
//                     max = num;
//             }


//             for (int i = 0; i <= max;)             // 정렬해서 출력
//             {
//                 if (counting[i] == 0)
//                 {
//                     i++;
//                     continue;
//                 }

//                 sb.Append(i + "\n");
//                 counting[i]--;
//                 if (600 <= sb.Length)
//                 {
//                     sw.Write(sb);
//                     sb.Clear();
//                 }
//             }
//             sw.Write(sb);
//             sw.Close();
//         }
//     }
// }