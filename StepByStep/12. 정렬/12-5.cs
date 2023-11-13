// using System;

// namespace baekjoon12_5
// {
//     class MainApp
//     {
//         static int[] counting = new int[10_001];

//         static int[] CountingSort(int[] arr, int max)
//         {
//             int[] result = new int[arr.Length];

//             for (int i = 0; i < arr.Length; i++)    // 카운팅
//                 counting[arr[i]]++;

//             for (int i = 1; i <= max; i++)          // 누적합 연산
//                 counting[i] += counting[i - 1];

//             for (int i = 0; i < result.Length; i++) // 정렬
//                 result[--counting[arr[i]]] = arr[i];

//             return result;
//         }

//         static void Main()
//         {
//             char[] ch = Console.ReadLine().ToCharArray();
//             int[] arr = new int[ch.Length];
//             int max = int.MinValue;

//             for (int i = 0; i < ch.Length; i++)
//             {
//                 arr[i] = Convert.ToInt32(ch[i] - '0');
//                 if (max < arr[i])
//                     max = arr[i];
//             }

//             arr = CountingSort(arr, max);
//             Array.Reverse(arr);

//             for (int i = 0; i < arr.Length; i++)
//                 Console.Write(arr[i]);
//         }
//     }
// }