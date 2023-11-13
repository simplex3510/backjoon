// using System;
// using static System.Math;

// namespace baekjoon9_11
// {
//     class MainApp
//     {
//         static void MeetPoint(int[] t1, int[] t2)
//         {
//             // d = 두 원의 중심 사이의 길이
//             double d = Sqrt(Pow(t1[0] - t2[0], 2) + Pow(t1[1] - t2[1], 2));
//             int r1 = t1[2] > t2[2] ? t1[2] : t2[2];
//             int r2 = t1[2] < t2[2] ? t1[2] : t2[2];

//             // 두 원의 반지름의 합보다 d가 작은 경우 - 교점 2개
//             if (r1 - r2 < d && d < r1 + r2)
//                 Console.WriteLine("2");

//             // 두 원의 반지름의 합과 d가 일치하는 경우 - 교점 1개(외접)
//             else if (d == r1 + r2)
//                 Console.WriteLine("1");

//             // d와 |r1-r2|가 일치하는 경우 - 교점 1개(내접)
//             else if (r1 == d + r2 && r1 != r2)
//                 Console.WriteLine("1");

//             // 두 원의 반지름의 합보다 두 원의 중심 사이의 거리가 큰 경우 - 교점 0개(만나지 않는 경우)
//             else if (d > r1 + r2)
//                 Console.WriteLine("0");

//             // 동심원이고 두 원의 반지름이 다른 경우 - 교점 0개(포함된 경우1)
//             else if (d == 0 && r1 > r2)
//                 Console.WriteLine("0");

//             // 동심원이 아니고 두 원의 반지름이 다른 경우 - 교점 0개(포함된 경우2)
//             else if (r1 > d + r2)
//                 Console.WriteLine("0");

//             else if (d == 0 && r1 == r2)
//                 Console.WriteLine("-1");
//         }

//         static void Main()
//         {
//             int testCase = Convert.ToInt32(Console.ReadLine());
//             string[] str;
//             int[] turret1 = new int[3];
//             int[] turret2 = new int[3];

//             for (int i = 0; i < testCase; i++)
//             {
//                 str = Console.ReadLine().Split();
//                 turret1[0] = Convert.ToInt32(str[0]); turret1[1] = Convert.ToInt32(str[1]); turret1[2] = Convert.ToInt32(str[2]);
//                 turret2[0] = Convert.ToInt32(str[3]); turret2[1] = Convert.ToInt32(str[4]); turret2[2] = Convert.ToInt32(str[5]);
//                 MeetPoint(turret1, turret2);
//             }
//         }
//     }
// }