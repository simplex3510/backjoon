// using System;
// using System.Text;

// namespace baekjoon12_6
// {
//     class MainApp
//     {

//         static void Merge(string[] arr, string[] sorted, int left, int mid, int right)
//         {
//             int i = left, j = mid + 1, k = left, l = 0;

//             while (i <= mid && j <= right)
//             {
//                 if (arr[i].Length == arr[j].Length)
//                 {
//                     char[] str_i = arr[i].ToCharArray();
//                     char[] str_j = arr[j].ToCharArray();
//                     for (int m = 0; m < str_i.Length; m++)
//                     {
//                         if (str_i[m] == str_j[m])
//                         {
//                             continue;
//                         }
//                         else if (str_i[m] < str_j[m])
//                         {
//                             sorted[k++] = arr[i++];
//                             break;
//                         }
//                         else
//                         {
//                             sorted[k++] = arr[j++];
//                             break;
//                         }
//                     }
//                 }
//                 else if (arr[i].Length <= arr[j].Length)
//                     sorted[k++] = arr[i++];
//                 else
//                     sorted[k++] = arr[j++];
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

//             for (l = left; l <= right; l++)
//                 arr[l] = sorted[l];
//         }

//         // O(nlog n) 시간 복잡도
//         static void MergeSort(string[] arr, string[] sorted, int left, int right)
//         {
//             if (left < right)
//             {
//                 int mid = (left + right) / 2;
//                 MergeSort(arr, sorted, left, mid);
//                 MergeSort(arr, sorted, mid + 1, right);
//                 Merge(arr, sorted, left, mid, right);
//             }
//         }

//         static void SortString(string[] str)
//         {
//             string[] sorted = new string[str.Length];

//             MergeSort(str, sorted, 0, str.Length - 1);

//             str = sorted;
//         }

//         static void Main()
//         {
//             StringBuilder sb = new StringBuilder();
//             int testCase = Convert.ToInt32(Console.ReadLine());

//             string[] str = new string[testCase];

//             // 입력
//             for (int i = 0; i < testCase; i++)
//             {
//                 str[i] = Console.ReadLine();

//                 for (int j = 0; j < i; j++)
//                 {
//                     if (str[i] == str[j])
//                     {
//                         str[i] = null;
//                         i--;
//                         testCase--;
//                         break;
//                     }
//                 }
//             }

//             Array.Resize(ref str, testCase);
//             SortString(str);

//             // 출력
//             for (int i = 0; i < testCase; i++)
//             {
//                 sb.Append(str[i] + "\n");
//             }
//             Console.WriteLine(sb);
//         }
//     }
// }