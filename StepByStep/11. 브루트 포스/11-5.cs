// using System;

// namespace baekjoon11_5
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             int num = Convert.ToInt32(Console.ReadLine());
//             char[] ch;
//             int count = 0;
//             int n = 0;
            
//             for (int i = 666; count < num; i++)
//             {
//                 ch = Convert.ToString(i).ToCharArray();
//                 for (int j = ch.Length-1; 2 <= j; j--)
//                 {
//                     if(ch[j-2] == '6' && ch[j-1] == '6' && ch[j] == '6')
//                     {
//                         // 중복되는 값 처리
//                         if(n == i)
//                             continue;
//                         else
//                         {
//                             count++;
//                             n = i;
//                         }
//                     }
//                 }
//             }
//             Console.WriteLine(n);
//         }
//     }
// }