// using System;

// namespace baekjoon7_9
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             string str = Console.ReadLine();
//             int count = 0;

//             for (int i = 0; i < str.Length; i++)
//             {   
//                 // 마지막 인덱스에서 OutOfRange 에러 처리
//                 if (i == str.Length-1) {    
//                     count++;
//                     break;
//                 }

//                 if (str[i] == 'c'){
//                     if (str[i + 1] == '='){
//                         count++;
//                         i++;
//                     }
//                     else if (str[i + 1] == '-'){
//                         count++;
//                         i++;
//                     }
//                     else
//                         count++;

//                 }

//                 else if (str[i] == 'd'){
//                     if (str[i + 1] == 'z'){
//                         if (i+1 == str.Length-1) {    
//                             count += 2;
//                             i++;
//                         }
//                         else if (str[i + 2] == '='){
//                             count++;;
//                             i += 2;
//                         }
//                         else {
//                             count += 2;
//                             i++;
//                         }
//                     }
//                     else if (str[i + 1] == '-'){
//                         count++;
//                         i++;
//                     }
//                     else
//                         count++;
//                 }

//                 else if (str[i] == 'l'){
//                     if (str[i + 1] == 'j'){
//                         count++;
//                         i++;
//                     }
//                     else
//                         count++;
//                 }

//                 else if (str[i] == 'n'){
//                     if (str[i + 1] == 'j'){
//                         count++;
//                         i++;
//                     }
//                     else
//                         count++;
//                 }

//                 else if (str[i] == 's'){
//                     if (str[i + 1] == '='){
//                         count++;
//                         i++;
//                     }
//                     else
//                         count++;
//                 }

//                 else if (str[i] == 'z'){
//                     if (str[i + 1] == '='){
//                         count++;
//                         i++;
//                     }
//                     else
//                         count++;
//                 }
                
//                 else
//                     count++;


//             }
//             Console.WriteLine(count);
//         }
//     }
// }