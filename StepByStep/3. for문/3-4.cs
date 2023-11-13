// using System;
// using System.Text;

// namespace backjoon3_4
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             int time = Convert.ToInt32(Console.ReadLine());
//             StringBuilder strb = new StringBuilder();
//             string[] arr = null;
//             int num1 = 0;
//             int num2 = 0;

//             for (int i = 0; i < time; i++)
//             {
//                 arr = Console.ReadLine().Split(' ');
//                 num1 = Convert.ToInt32(arr[0]);
//                 num2 = Convert.ToInt32(arr[1]);
//                 strb.Append(num1 + num2 + "\n");
//             }

//             Console.WriteLine(strb.ToString());

//         }
//     }
// }