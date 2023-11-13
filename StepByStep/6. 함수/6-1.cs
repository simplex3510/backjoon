// using System;

// namespace bacckjook6_1
// {
//     class MainApp
//     {
//         static void SelfNumber()
//         {
//             int j = 0;
//             int[] arr = new int[10001];

//             for(int i=0; i<10001; i++) { arr[i] = i; }    // 초기화

//             for(int i=0; i<10; i++) { arr[j+j] = 0; }   // 일의 자리수 제거
            
//             for(int i=0; i<100; i++)
//             {
//                 int num0 = i;
//                 int num1 = i / 10;
//                 int num2 = i % 10;
//                 int idx = num0 + num1 + num2;
//                 if(idx < 10001)
//                     arr[idx] = 0;
//             }

//             for(int i=100; i<1000; i++)
//             {
//                 int num0 = i;
//                 int num1 = i / 100;
//                 int num1_1 = i % 100;
//                 int num2 = num1_1 / 10;
//                 int num3 = num1_1 % 10;
//                 int idx = num0 + num1 + num2 + num3;
//                 if(idx < 10001)
//                     arr[idx] = 0;
//             }

//             for(int i=1000; i<10001; i++)
//             {
//                 int num0 = i;               
//                 int num1 = i / 1000;       
//                 int num1_1 = i % 1000;
//                 int num2 = num1_1 / 100;   
//                 int num2_1 = num1_1 % 100;
//                 int num3 = num2_1 / 10;    
//                 int num4 = num2_1 % 10;   
//                 int idx = num0 + num1+num2+num3+num4;
//                 if(idx < 10001)
//                     arr[idx] = 0;
//             }

//             // 출력
//             for(int i=0; i<10001; i++)
//             { 
//                 if(arr[i] != 0)
//                     Console.WriteLine($"{arr[i]}");
//             }
            
//         }

//         static void Main()
//         {
//             SelfNumber();
//         }
//     }
// }