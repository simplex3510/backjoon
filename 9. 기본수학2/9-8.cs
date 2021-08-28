// using System;

// namespace baekjoon9_8
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             int[] x = new int[3];
//             int[] y = new int[3];
//             int coordinate_x = 0, coordinate_y = 0;

//             for (int i = 0; i < x.Length; i++)
//             {
//                 string[] str = Console.ReadLine().Split();
//                 x[i] = Convert.ToInt32(str[0]);
//                 y[i] = Convert.ToInt32(str[1]);
//             }

//             if (x[0] == x[1])
//                 coordinate_x = x[2];
//             else if (x[0] == x[2])
//                 coordinate_x = x[1];
//             else
//                 coordinate_x = x[0];

//             if (y[0] == y[1])
//                 coordinate_y = y[2];
//             else if (y[0] == y[2])
//                 coordinate_y = y[1];
//             else
//                 coordinate_y = y[0];

//             Console.WriteLine("{0} {1}", coordinate_x, coordinate_y);
//         }
//     }
// }