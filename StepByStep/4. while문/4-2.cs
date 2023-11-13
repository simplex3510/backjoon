// using System;

// namespace backjoon4_2
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             string str = null;
//             string[] arr = null;
//             int num1 = 0;
//             int num2 = 0;

//             while(true) {
//                 str = Console.ReadLine();
//                 if (str == null)
//                     break;

//                 arr = str.Split(' ');
//                 num1 = Convert.ToInt32(arr[0]);
//                 num2 = Convert.ToInt32(arr[1]);
//                 Console.WriteLine($"{num1+num2}");
//             }
//         }
//     }
// }