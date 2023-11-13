// using System;

// namespace baekjoon9_1
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             int n = Convert.ToInt32(Console.ReadLine());
//             int i = 0;
            
//             if (n == 1)
//                 return;

//             for (i = 2; i < n; i++)
//             {
//                 if(1 <= n/i && n%i==0)
//                 {
//                     n = n/i;
//                     Console.WriteLine(i);
//                     i--;
//                     continue;
//                 }
//             }

//             Console.WriteLine(i);
//         }
//     }
// }