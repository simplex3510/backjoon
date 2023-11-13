// using System;

// namespace baekjoon11_3
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             int testCase = Convert.ToInt32(Console.ReadLine());
//             int[,] person = new int[testCase, 3];
//             string[] str;
//             int level = 0;

//             // 초기화
//             for (int i = 0; i < testCase; i++)
//             {
//                 str = Console.ReadLine().Split();
//                 person[i, 0] = Convert.ToInt32(str[0]);
//                 person[i, 1] = Convert.ToInt32(str[1]); 
//             }

//             // 연산
//             for (int i = 0; i < testCase; i++)
//             {
//                 level = 1;
//                 for (int j = 0; j < testCase; j++)
//                 {
//                     if (j == i)
//                         continue;

//                     if (person[i, 0] < person[j, 0] && person[i, 1] < person[j,1])
//                         level++;
//                 }
//                 person[i, 2] = level;
//             }

//             // 출력
//             for (int i = 0; i < testCase; i++)
//             {
//                 Console.Write("{0} ", person[i, 2]);
//             }
//         }
//     }
// }