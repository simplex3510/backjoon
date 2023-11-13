// using System;

// namespace baekjoon7_8
// {
//     class MainApp
//     {
//         static void init(int[] num)
//         {
//             int dial = 3;
//             int count = 0;

//             for (int i = 0; i < num.Length; i++)
//             {

//                 if (3 <= count)
//                 {
//                     count = 0;
//                     dial++;
//                 }

//                 if (16-1 <= i && i <= 19-1 ||
//                     23-1 <= i && i <= 26-1)
//                 {
//                     num[i] = dial;
//                     continue;
//                 }
//                 else if (i==20-1 || i==27-1)
//                     dial++;

//                 num[i] = dial;
//                 count++;
//             }
//         }
//         static void Main()
//         {
//             int[] num = new int[26];
//             int result = 0;

//             init(num);
//             string str = Console.ReadLine();

//             for (int i = 0; i < str.Length; i++)
//             {
//                 result += num[str[i] - 65];
//             }
//             Console.WriteLine(result);
//         }
//     }
// }