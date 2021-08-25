// using System;

// namespace baekjoon9_1
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             int time = Convert.ToInt32(Console.ReadLine());
//             string[] str = Console.ReadLine().Split(' ');
//             int testCase = 0;
//             int count = 0;

//             for (int i = 0; i < time; i++)
//             {
//                 testCase = Convert.ToInt32(str[i]);

//                 if (testCase == 1)
//                     continue;
//                 else if (testCase == 2)
//                 {
//                     count++;
//                     continue;
//                 }

//                 for (int j = 2; j < testCase; j++)
//                 {
//                     if (testCase % j == 0)
//                         break;
//                     else if (j == testCase - 1 && testCase % j != 0)
//                         count++;
//                 }
//             }

//             Console.WriteLine(count);

//         }
//     }
// }