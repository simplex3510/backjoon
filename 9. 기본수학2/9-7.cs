// using System;

// namespace baekjoon9_7
// {
//     public class MainApp
//     {
//         public static void Main()
//         {
//             string[] str = Console.ReadLine().Split();
//             int x = Convert.ToInt32(str[0]);
//             int y = Convert.ToInt32(str[1]);
//             int w = Convert.ToInt32(str[2]);
//             int h = Convert.ToInt32(str[3]);
//             int[] arr = new int[4];
//             int min = int.MaxValue;

//             arr[0] = h - y;
//             arr[1] = w - x;
//             arr[2] = y;
//             arr[3] = x;

//             foreach (int a in arr)
//             {
//                 if (a < min)
//                     min = a;
//             }

//             Console.WriteLine(min);

//         }
//     }
// }