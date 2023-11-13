// using System;

// namespace baekjoon8_6
// {
//     class MainApp
//     {
//         static int apart(int k, int n)
//         {
//             int[,] apart = new int[k, n];
//             int man = 1;
//             int sum = 0;

//             for (int i = 0; i < k; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     if(i==0)
//                     {
//                         apart[i, j] = man;
//                         man++;
//                     }
//                     else
//                     {
//                         sum = 0;
//                         for (int l = 0; l <= j; l++)
//                         {
//                             sum += apart[i-1, l];
//                         }
//                         apart[i, j] = sum;
//                     }
//                 }
//             }

//             return apart[k-1, n-1];
//         }

//         static void Main()
//         {
//             int t = Convert.ToInt32(Console.ReadLine());
//             int k = 0, n = 0;

//             for (int i = 0; i < t; i++)
//             {
//                 k = Convert.ToInt32(Console.ReadLine());
//                 n = Convert.ToInt32(Console.ReadLine());

//                 Console.WriteLine(apart(k+1, n));
//             }
//         }
//     }
// }