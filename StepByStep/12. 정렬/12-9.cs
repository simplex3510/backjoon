// using System;

// namespace baekjoon12_2
// {
//     class MainApp
//     {
//         struct Profile
//         {
//             public int age;
//             public string name;
//         }

//         static void Merge(Profile[] arr, Profile[] sorted, int left, int mid, int right)
//         {
//             int i = left, j = mid + 1, k = left, l = 0;
//             while (i <= mid && j <= right)
//             {
//                 if (arr[i].age <= arr[j].age)
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
//         static void MergeSort(Profile[] arr, Profile[] sorted, int left, int right)
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
//             int testCase = Convert.ToInt32(Console.ReadLine());
//             Profile[] arr = new Profile[testCase];
//             Profile[] sorted = new Profile[testCase];

//             for (int i = 0; i < testCase; i++)
//             {
//                 string[] str = Console.ReadLine().Split();
//                 arr[i].age = int.Parse(str[0]);
//                 arr[i].name = str[1];
//             }

//             MergeSort(arr, sorted, 0, arr.Length-1);

//             Console.WriteLine("--------");
//             // 출력
//             for (int i = 0; i < testCase; i++)
//             {
//                 Console.WriteLine($"{arr[i].age} {arr[i].name}");
//             }

//         }
//     }
// }