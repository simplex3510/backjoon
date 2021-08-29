// using System;

// namespace baekjoon9_9
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             string[] str;
//             int a = 0, b = 0, c = 0;

//             while (true)
//             {
//                 str = Console.ReadLine().Split();

//                 a = Convert.ToInt32(str[0]);
//                 b = Convert.ToInt32(str[1]);
//                 c = Convert.ToInt32(str[2]);

//                 if (a == 0 && b == 0 && c == 0)
//                     break;

//                 if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
//                     Console.WriteLine("right");
//                 else if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))
//                     Console.WriteLine("right");
//                 else if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
//                     Console.WriteLine("right");
//                 else
//                     Console.WriteLine("wrong");
//             }
//         }
//     }
// }