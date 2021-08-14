// using System;

// namespace baekjoon7_10
// {
//     class MainApp
//     {
//         static void GroupWordChecker(string str, ref int num)
//         {
//             bool[] alphabet = new bool[26];

//             for (int j = 0; j < str.Length; j++)
//             {
//                 if (alphabet[str[j] - 'a'] == false)
//                 {
//                     alphabet[str[j] - 'a'] = true;
//                 }
//                 else if (alphabet[str[j] - 'a'] == true)
//                 {
//                     if (str[j] == str[j - 1])
//                     {
//                         continue;
//                     }
//                     else
//                         return;
//                 }
//             }

//             num++;
//             return;
//         }

//         static void Main()
//         {
//             int time = Convert.ToInt32(Console.ReadLine());
//             int num = 0;

//             for (int i = 0; i < time; i++)
//             {
//                 GroupWordChecker(Console.ReadLine(), ref num);
//             }

//             Console.WriteLine(num);
//         }
//     }
// }