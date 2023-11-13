// using System;

// namespace backjoon2_5
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             string str = Console.ReadLine();
//             string[] arr = str.Split(' ');

//             int hour = Convert.ToInt32(arr[0]);
//             int min  = Convert.ToInt32(arr[1]);

//             if ((min - 45) < 0) {
//                 min = (60+min)-45;
//                 hour -= 1;
//                 if (hour < 0)
//                    hour = 23;

//                 Console.WriteLine($"{hour} {min}");
//             }
//             else {
//                 min -= 45;
//                 Console.WriteLine($"{hour} {min}");
//             }
//         }
//     }
// }