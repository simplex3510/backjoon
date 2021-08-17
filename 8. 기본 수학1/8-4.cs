// using System;

// namespace baekjoon8_4
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             string str = Console.ReadLine();
//             string[] arr = str.Split(' ');
//             int go = Convert.ToInt32(arr[0]);
//             int back = Convert.ToInt32(arr[1]);
//             int goal = Convert.ToInt32(arr[2]);

//             if((goal-back)%(go-back) == 0)
//                 Console.WriteLine((goal-back)/(go-back));
//             else
//                 Console.WriteLine((goal-back)/(go-back) + 1);
//         }
//     }
// }