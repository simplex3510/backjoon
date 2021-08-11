// using System;

// namespace bacckjook6_2
// {
//     class MainApp
//     {
//         static void HanSu(int num)
//         {
//             int count = 0;

//             if(num < 100) { count=num; }

//             if (100 <= num)
//             {
//                 count=99;
//                 for (int j = 100; j <= num; j++)
//                 {
//                     int num0 = j;
//                     int num1 = num0 / 100;
//                     int num1_1 = num0 % 100;
//                     int num2 = num1_1 / 10;
//                     int num3 = num1_1 % 10;

//                     if ((num1 - num2) == (num2 - num3))
//                         count++;
//                 }
//             }

//             Console.WriteLine($"{count}");
//         }

//         static void Main()
//         {
//             string str = Console.ReadLine();
//             int num = Convert.ToInt32(str);
//             HanSu(num);
//         }
//     }
// }