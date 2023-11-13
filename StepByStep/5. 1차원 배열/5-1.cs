// using System;

// namespace baekjoon5_1
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             int t = Convert.ToInt32(Console.ReadLine());
//             string[] str = (Console.ReadLine()).Split(' ');
//             int[] arr = new int[t];
//             int max = int.MinValue, min = int.MaxValue;

//             for (int i = 0; i < t; i++)
//             {
//                 arr[i] = Convert.ToInt32(str[i]);
                
//                 if(arr[i] < min)
//                     min = arr[i];
//                 if(max < arr[i])
//                     max = arr[i];
//             }

//             Console.Write($"{min} {max}");
//         }
//     }
// }