// using System;

// namespace baekjoon9_5
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             while (true)
//             {
//                 int count = 0;
//                 int n = Convert.ToInt32(Console.ReadLine());
//                 if (n == 0)
//                     break;

//                 bool[] arr = new bool[2 * n + 1];
//                 arr[0] = arr[1] = true;

//                 for (int i = 2; i <= 2 * n; i++)
//                 {
//                     if (arr[i] == false)
//                     {
//                         for (int j = 2; i*j <= 2 * n; j++)
//                             arr[i*j] = true;
//                     }
//                 }

//                 for (int k = n+1; k <= 2*n; k++)
//                 {
//                     if(arr[k] == false)
//                         count++;
//                 }
//                 Console.WriteLine(count);
//             }
//         }
//     }

// }