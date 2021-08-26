// using System;
// using System.Text;

// namespace baejoon9_4
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             StringBuilder sb = new StringBuilder();
//             string[] str = Console.ReadLine().Split(' ');
//             int m = Convert.ToInt32(str[0]);
//             int n = Convert.ToInt32(str[1]);
//             bool[] arr = new bool[n + 1];

//             arr[0] = arr[1] = true;

//             for (int i = 2; i <= n; i++)
//             {
//                 if (arr[i] == false)
//                 {
//                     for (int j = 2; j * i <= n; j++)
//                         arr[j * i] = true;
//                 }
//             }

//             for (int i = m; i <= n; i++)
//             {
//                 if (arr[i] == false)
//                     sb.Append(i + "\n");
//             }

//             Console.WriteLine(sb);
//         }
//     }
// }