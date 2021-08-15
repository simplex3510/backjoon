// using System;

// namespace baekjoon8_2
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             int num = Convert.ToInt32(Console.ReadLine());
//             int count = 1;
//             int room  = 1;

//             for (int i = 1; i < num; i++)
//             {
//                 if( i == room )
//                 {
//                     room += (6*count);
//                     count++;
//                 }
//             }

//             Console.WriteLine(count);
//         }
//     }
// }