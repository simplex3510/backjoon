// using System;

// namespace baekjoon7_6
// {
//     class MainApp
//     {
//         static int ReverseAndInt(string _str)
//         {
//             string str = "";
//             int idx = _str.Length - 1;

//             for (int i = 0; i < _str.Length; i++)
//             {
//                 str += _str[idx];
//                 idx--;
//             }

//             return Convert.ToInt32(str);
//         }
//         static void Main()
//         {
//             string str0 = Console.ReadLine();
//             string[] arr = str0.Split(' ');
//             string str1 = arr[0];
//             int num1 = ReverseAndInt(str1);
//             string str2 = arr[1];
//             int num2 = ReverseAndInt(str2);

//             if(num1 < num2)
//                 Console.Write(num2);
//             else
//                 Console.Write(num1);

//         }
//     }
// }