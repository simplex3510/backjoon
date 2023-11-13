// using System;

// namespace baekjoon5_4
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             bool[] remainder = new bool[42];
//             int num = 0;
//             int count = 0;

//             for (int i = 0; i < 10; i++)
//             {
//                 num = Convert.ToInt32(Console.ReadLine());
//                 remainder[num % 42] = true;
//             }

//             for (int i = 0; i < remainder.Length; i++)
//             {
//                 if(remainder[i] == false)
//                     continue;
//                 else
//                     count++;
//             }

//             Console.WriteLine(count);

            
//         }
//     }
// }