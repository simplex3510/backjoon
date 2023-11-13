// using System;
// using System.Text;

// namespace baekjoon12_6
// {
//     class MainApp
//     {
//         struct Position { public int x, y; }

//         static void Merge(Position[] arr, Position[] sorted, int left, int mid, int right)
//         {
//             int i = left, j = mid + 1, k = left, l = 0;

//             while (i <= mid && j <= right)
//             {
//                 if (arr[i].x == arr[j].x)
//                 {
//                     if (arr[i].y < arr[j].y)
//                     {
//                         sorted[k++] = arr[i++];
//                     }
//                     else
//                     {
//                         sorted[k++] = arr[j++];
//                     }
//                 }
//                 else if (arr[i].x < arr[j].x)
//                 {
//                     sorted[k++] = arr[i++];
//                 }
//                 else
//                 {
//                     sorted[k++] = arr[j++];
//                 }
//             }

//             // 오른쪽 부분 입력
//             if (i > mid)
//             {
//                 for (l = j; l <= right; l++)
//                     sorted[k++] = arr[l];
//             }
//             // 왼쪽 부분 입력
//             else
//             {
//                 for (l = i; l <= mid; l++)
//                     sorted[k++] = arr[l];
//             }

//             // 원복 배열로 복사
//             for (l = left; l <= right; l++)
//                 arr[l] = sorted[l];
//         }

//         static void MergeSort(Position[] arr, Position[] sorted, int left, int right)
//         {
//             if (left < right)
//             {
//                 int mid = (left + right) / 2;
//                 MergeSort(arr, sorted, left, mid);
//                 MergeSort(arr, sorted, mid + 1, right);
//                 Merge(arr, sorted, left, mid, right);
//             }
//         }

//         static void Main()
//         {
//             StringBuilder sb = new StringBuilder();
//             int testCase = Convert.ToInt32(Console.ReadLine());
//             Position[] arr = new Position[testCase];
//             Position[] srt = new Position[testCase];

//             for (int i = 0; i < testCase; i++)
//             {
//                 string[] str = Console.ReadLine().Split();
//                 arr[i].x = Convert.ToInt32(str[0]);    // x좌표
//                 arr[i].y = Convert.ToInt32(str[1]);    // y좌표
//             }

//             MergeSort(arr, srt, 0, arr.Length-1);

//             //Console.WriteLine("---------");
//             for (int i = 0; i < testCase; i++)
//             {
//                 sb.Append($"{arr[i].x} {arr[i].y}" + "\n");
//             }
//             Console.WriteLine(sb);
//         }
//     }
// }