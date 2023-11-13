// using System;
// using System.Text;

// namespace baekjoon10_3
// {
//     class MainApp
//     {
//         static void star(char[,] matrix, int x, int y, int n)
//         {
//             if (n == 1)
//             {
//                 matrix[y, x] = '*';
//                 return;
//             }

//             for (int i = 0; i < 3; i++)
//             {
//                 for (int j = 0; j < 3; j++)
//                 {
//                     if ((i%3) == 1 && (j%3) == 1)
//                         continue;
//                     else
//                         star(matrix, x + (n/3 * j), y + (n/3 * i), n/3);
//                 }
//             }
//         } 

//         static void Main()
//         {
//             StringBuilder sb = new StringBuilder();
//             int n = Convert.ToInt32(Console.ReadLine());
//             char[,] matrix = new char[n, n];

//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     matrix[i, j] = ' ';
//                 }
//             }

//             star(matrix, 0, 0, n);

//             // 출력
//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     sb.Append(matrix[i, j]);
//                 }
//                 sb.Append('\n');
//             }
//             Console.Write(sb);
//         }
//     }
// }
