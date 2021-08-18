// using System;

// namespace baekjoon8_7
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             int input = Convert.ToInt32(Console.ReadLine());
//             int kg_3 = 0;
//             int kg_5 = 0;

//             while (true)
//             {
//                 if(input == 0)
//                     break;

//                 if(input%5 == 0)
//                 {
//                     kg_5++;
//                     input -= 5;
//                 }
//                 else if(input%3 == 0)
//                 {
//                     kg_3++;
//                     input -= 3;
//                 }
//                 else if (5 < input)
//                 {
//                     kg_5++;
//                     input -= 5;
//                 }
//                 else if (3 < input)
//                 {
//                     kg_3++;
//                     input -= 3;
//                 }
//                 else
//                 {
//                     Console.WriteLine("-1");
//                     return;
//                 }
//             }

//             Console.WriteLine(kg_3+kg_5);
//         }
//     }
// }