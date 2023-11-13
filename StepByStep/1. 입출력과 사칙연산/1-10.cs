// using System;

// namespace backjoon1_10
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             string str = Console.ReadLine();
//             string[] arr = str.Split(' ');
//             int a = Convert.ToInt32(arr[0]);
//             int b = Convert.ToInt32(arr[1]);
//             int c = Convert.ToInt32(arr[2]);

//             Console.WriteLine("{0}", (a + b) % c);
//             Console.WriteLine("{0}", ((a%c) + (b%c)) %c);
//             Console.WriteLine("{0}", (a * b) % c);
//             Console.WriteLine("{0}", ((a%c) * (b%c)) %c);
//         }
//     }
// }