// using System;

// namespace baekjoon8_8
// {
//     class MainApp
//     {
//         static void Equalize(ref string num1, ref string num2)
//         {
//             if (num1.Length < num2.Length)
//             {
//                 for (int i = 0; num1.Length != num2.Length; i++)
//                     num1 = num1.Insert(0, "0");
//             }
//             else if (num1.Length > num2.Length)
//             {
//                 for (int i = 0; num1.Length != num2.Length; i++)
//                     num2 = num2.Insert(0, "0");
//             }
//             else
//                 return;
//         }

//         static string Summary(string num1, string num2)
//         {
//             string sum = "";
//             int carry = 0;
//             int n1 = 0, n2 = 0, s = 0;

//             Equalize(ref num1, ref num2);

//             for (int i = num1.Length - 1; 0 <= i; i--)
//             {
//                 n1 = Convert.ToInt32(num1[i] - '0');
//                 n2 = Convert.ToInt32(num2[i] - '0');
//                 s = 0; s += n1 + n2 + carry;

//                 if (i == 0)
//                 {
//                     carry = s;
//                     sum = sum.Insert(0, $"{carry}");
//                     return sum;
//                 }

//                 if (0 < carry)
//                     carry = 0;

//                 if (9 < s)
//                 {
//                     carry = s / 10;
//                     s %= 10;
//                     sum = sum.Insert(0, $"{s}");
//                 }
//                 else
//                     sum = sum.Insert(0, $"{s}");
//             }

//             return sum;
//         }

//         static void Main()
//         {
//             string[] str = (Console.ReadLine()).Split(' ');
//             string sum;
//             sum = Summary(str[0], str[1]);
//             Console.WriteLine(sum);
//         }
//     }
// }