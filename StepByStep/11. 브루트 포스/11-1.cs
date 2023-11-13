// using System;

// namespace baekjoon11_1
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             string[] str = Console.ReadLine().Split();
//             int n = Convert.ToInt32(str[0]);
//             int m = Convert.ToInt32(str[1]);

//             string[] arrCard = Console.ReadLine().Split();
//             int[] card = new int[n];
//             for (int i = 0; i < n; i++)
//                 card[i] = Convert.ToInt32(arrCard[i]);

//             int sum = 0;
//             int diff = int.MaxValue;
//             int[] num = new int[3];
            


//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     if(j == i)
//                         continue;

//                     for (int k = 0; k < n; k++)
//                     {
//                         if (k == j || k == i)
//                             continue;
                        
//                         sum = card[i] + card[j] + card[k];
                        
//                         if(Math.Abs(m-sum) < diff && sum <= m)
//                         {
//                             diff = Math.Abs(m-sum);
//                             num[0] = card[i]; num[1] = card[j]; num[2] = card[k];
                            
//                             //Console.WriteLine($"sum: {sum}, {card[i]} {card[j]} {card[k]}");
//                             //Console.WriteLine($"{sum}");
//                         }
//                     }
//                 }
                
//             }
//             Console.WriteLine($"{num[0] + num[1] + num[2]}");
//         }
//     }
// }