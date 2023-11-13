// using System;

// namespace backjoon3_11
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             string[] str = Console.ReadLine().Split();
//             int time = Convert.ToInt32(str[0]);
//             int num  = Convert.ToInt32(str[1]);
//             string[] input = Console.ReadLine().Split();

//             for (int i = 0; i < time; i++)
//             {
//                 if (Convert.ToInt32(input[i]) < num)
//                     Console.Write($"{input[i]} ");
//             }

//         }
//     }
// }