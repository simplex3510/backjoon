// using System;

// namespace baekjoon7_4
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             int testCase = Convert.ToInt32(Console.ReadLine());
//             int time = 0, idx = 0;

//             for (int i = 0; i < testCase; i++)
//             {
//                 string input = Console.ReadLine();
//                 string[] str = input.Split(' ');
//                 idx = 0;
//                 time = Convert.ToInt32(str[0]);
//                 for (int j = 0; j < str[1].Length; j++)
//                 {
//                     for (int k = 0; k < time; k++)
//                     {
//                         Console.Write($"{str[1][idx]}");
//                     }
//                     idx++;
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }