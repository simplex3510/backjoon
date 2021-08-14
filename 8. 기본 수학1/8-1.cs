// using System;

// namespace baekjoon8_1
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             string[] str = (Console.ReadLine()).Split(' ');
//             int cost_a = Convert.ToInt32(str[0]);
//             int cost_b = Convert.ToInt32(str[1]);
//             int price  = Convert.ToInt32(str[2]);
//             int revenue = 0;
//             int count = 0;

//             if(price <= cost_b) {
//                 Console.Write(-1);
//                 return;
//             }

//             while (revenue <= cost_a)
//             {
//                 count++;
//                 revenue += (price - cost_b);
//             }

//             Console.Write(count);
//         }
//     }
// }