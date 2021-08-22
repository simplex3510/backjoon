// using System;

// namespace baekjoon5_3
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             int[] count = new int[10];
//             string str = "";
//             int num = 1;

//             for (int i = 0; i < 3; i++)
//                 num *= Convert.ToInt32(Console.ReadLine());

//             str = Convert.ToString(num);

//             for (int i = 0; i < str.Length; i++)
//                 count[str[i] - '0']++;

//             for (int i = 0; i < count.Length; i++)
//                 Console.WriteLine(count[i]);
//         }
//     }
// }