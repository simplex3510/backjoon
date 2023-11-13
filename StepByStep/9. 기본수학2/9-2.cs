// using System;

// namespace baekjoon9_1
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             int m = Convert.ToInt32(Console.ReadLine());
//             int n = Convert.ToInt32(Console.ReadLine());
//             bool isCount = false;
//             int sum = 0;
//             bool isMin = true;
//             int min = 0;

//             for (int i = m; i <= n; i++)
//             {
//                 if (i == 0 || i == 1)
//                     continue;
//                 else if (i == 2)
//                 {
//                     isCount = true;
//                     sum += i;
//                     if (isMin == true)
//                     {
//                         min = i;
//                         isMin = false;
//                     }
//                 }
//                 else
//                 {
//                     for (int j = 2; j < i; j++)
//                     {
//                         if (i % j == 0)
//                             break;
//                         else if (j == i - 1 && i % j != 0)
//                         {
//                             isCount = true;
//                             sum += i;
//                             if (isMin == true)
//                             {
//                                 min = i;
//                                 isMin = false;
//                             }
//                         }
//                     }
//                 }
//             }

//             if (isCount == false)
//                 Console.WriteLine(-1);
//             else
//             {
//                 Console.WriteLine(sum);
//                 Console.WriteLine(min);

//             }
//         }
//     }
// }