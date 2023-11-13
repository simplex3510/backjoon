// using System;

// namespace baekjoon12_1
// {
//     class MainApp
//     {
//         // O(n^2) 시간 복잡도
//         static void BubbleSort(int[] arr)
//         {
//             int temp = 0;

//             for (int i = arr.Length-1; 0 <= i; i--)
//             {
//                 for (int j = 0; j < i; j++)
//                 {
//                     if(arr[j] > arr[j+1])
//                     {
//                         temp = arr[j];
//                         arr[j] = arr[j+1];
//                         arr[j+1] = temp;
//                     }
//                 }
//             }

//         }

//         static void Main()
//         {
//             int testCase = Convert.ToInt32(Console.ReadLine());
//             int [] arr = new int[testCase];

//             for (int i = 0; i < testCase; i++)
//             {
//                 arr[i] = Convert.ToInt32(Console.ReadLine());
//             }

//             BubbleSort(arr);

//             // 출력
//             for (int i = 0; i < arr.Length; i++)
//                 Console.WriteLine(arr[i]);

//         }
//     }
// }