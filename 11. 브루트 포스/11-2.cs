// using System;

// namespace baekjoon11_2
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             string num = Console.ReadLine();    // 수를 입력받음
//             int n = Convert.ToInt32(num);       // 수를 int형으로 변환
//             int sum = 0;                        // 합 변수 선언

//             // 해당 자릿수의 숫자부터 시작 -> 3자리수 = 100부터 시작
//             for (int i = (int)Math.Pow(10, num.Length-1); i <= n; i++)
//             {
//                 string str = Convert.ToString(i);   // i를 기준으로
//                 int temp = i;                       // i의 각 자리 합 연산을 위한 임시 변수
//                 sum = i;                            // 합 연산

//                 // i의 자리수를 j로 계산하여 연산
//                 for (int j = (int)Math.Pow(10, str.Length-1); 0 < j; j/=10)
//                 {
//                     sum += temp/j;                  // 각 자리수를 더함
//                     temp %= j;                      // 남은 자리수 연산
//                 }

//                 if (n == sum)                       // 입력값과 합이 같다면 생성자가 있는 것
//                 {
//                     Console.WriteLine(i);
//                     return;
//                 }
//             }
//             Console.WriteLine(0);
//             return;
//         }
//     }
// }