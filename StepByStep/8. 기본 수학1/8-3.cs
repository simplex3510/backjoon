// using System;

// namespace baekjoon8_3
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             int num = Convert.ToInt32(Console.ReadLine());

//             int level = 1;
//             int count = 0;
//             int up = 0;
//             int down = 0;

//             for (int i = 0; count != num; i++)
//             {
//                 if (level % 2 == 0)
//                 {
//                     up = 1;
//                     down = level;
//                     for (int j = 0; j < level; j++)
//                     {
//                         count++;
//                         if (count == num)
//                             break;
//                         else
//                         {
//                             up++;
//                             down--;
//                         }

//                     }
//                 }
//                 else
//                 {
//                     up = level;
//                     down = 1;
//                     for (int j = 0; j < level; j++)
//                     {
//                         count++;
//                         if (count == num)
//                             break;
//                         else
//                         {
//                             up--;
//                             down++;
//                         }
//                     }
//                 }
//                 level++;
//             }
//             Console.WriteLine($"{up}/{down}");
//         }
//     }
// }