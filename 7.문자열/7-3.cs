// using System;

// namespace baekjoon7_3
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             int[] arr = new int[26];
//             string str = Console.ReadLine();
//             int location = 0;
//             int ascii = 0;

//             for (int i = 0; i < 26; i++)
//                 arr[i] = -1;

//             for (int i = 0; i < str.Length; i++)
//             {
//                 ascii = (int)str[i];
//                 if (97 <= ascii && ascii <= 122)
//                 {
//                     if (arr[ascii-97] == -1)
//                         arr[ascii - 97] = location;
//                     location++;
//                 }
//             }

//             for (int i = 0; i < 26; i++)
//             {
//                 Console.Write($"{arr[i]} ");
//             }


//         }
//     }
// }