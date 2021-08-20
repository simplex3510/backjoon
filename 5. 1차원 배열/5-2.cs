// using System;

// namespace baekjoon5_2
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             int[] arr= new int[9];
//             int max = int.MinValue;
//             int pos = 0;

//             for (int i = 0; i < 9; i++)
//             {
//                 arr[i] = Convert.ToInt32(Console.ReadLine());
//                 if(max < arr[i])
//                 {
//                     max = arr[i];
//                     pos = i;
//                 }
//             }

//             Console.WriteLine(max);
//             Console.WriteLine(pos+1);
//         }
//     }
// }