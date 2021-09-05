// using System;
// using System.Text;

// namespace baekjoon12_1
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             StringBuilder sb = new StringBuilder();
//             int testCase = Convert.ToInt32(Console.ReadLine());
//             int [] arr = new int[testCase];

//             for (int i = 0; i < testCase; i++)
//                 arr[i] = Convert.ToInt32(Console.ReadLine());

//             Array.Sort(arr);

//             // 출력
//             for (int i = 0; i < arr.Length; i++)
//                 sb.Append(arr[i] + "\n");

//             Console.Write(sb);
//         }
//     }
// }