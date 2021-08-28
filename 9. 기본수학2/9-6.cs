// using System;

// namespace baekjoon9_6
// {
//     class MainApp
//     {
//         static void Goldbach(int gNumber)
//         {
//             int gPartition1 = 0, gPartition2 = 0;
//             bool[] arr = new bool[gNumber];
//             arr[0] = arr[1] = true;

//             for (int i = 2; i * i <= gNumber; i++)
//             {
//                 if (arr[i] == false)
//                 {
//                     for (int j = i * i; j < gNumber; j += i)
//                     {
//                         arr[j] = true;
//                     }
//                 }
//             }

//             // 첫 번째 소수인 i는 두번째 보다 작아야 하므로 골드바흐 수의 절반보다 커질 수 없음
//             for (int i = 2; i <= arr.Length/2; i++)
//             {
//                 // 파티션의 수는 모두 소수여야 함
//                 if (arr[i] == true || arr[gNumber-i] == true)
//                     continue;

//                 gPartition1 = i;
//                 gPartition2 = gNumber - i;

//             }
//             Console.WriteLine($"{gPartition1} {gPartition2}");
//         }

//         static void Main()
//         {
//             int testCase = Convert.ToInt32(Console.ReadLine());
//             int gNumber = 0;


//             for (int i = 0; i < testCase; i++)
//             {
//                 gNumber = Convert.ToInt32(Console.ReadLine());
//                 Goldbach(gNumber);

//             }
//         }
//     }
// }
