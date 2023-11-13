// using System;

// namespace backjoon3_7
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             int time = Convert.ToInt32(Console.ReadLine());

//             string[] str = null;
//             int num1 = 0, num2 = 0;
//             int sum = 0;

//             for (int i = 0; i < time; i++)
//             {
//                 str = Console.ReadLine().Split(' ');
//                 num1 = Convert.ToInt32(str[0]);
//                 num2 = Convert.ToInt32(str[1]);
//                 sum = num1 + num2;
//                 Console.WriteLine("Case #{0}: {1}", i+1, sum);
//             }
//         }
//     }
// }