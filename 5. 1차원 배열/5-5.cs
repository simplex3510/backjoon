// using System;

// namespace baekjoon5_5
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             int test = Convert.ToInt32(Console.ReadLine());
//             double high = int.MinValue;
//             string[] str = (Console.ReadLine()).Split(' ');
//             double[] score = new double[str.Length];
//             double sum = 0.0;

//             for (int i = 0; i < test; i++)
//             {
//                 score[i] = Convert.ToDouble(str[i]);
//                 if( high < score[i] )
//                     high = score[i];
//             }
            
//             for (int j = 0; j < test; j++)
//             {
//                 score[j] = score[j]/high*100;
//                 sum += score[j];
//             }

//             Console.WriteLine(sum/test);
//         }
//     }
// }