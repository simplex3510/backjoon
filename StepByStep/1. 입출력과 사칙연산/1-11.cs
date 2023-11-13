// using System;

// namespace Backjoon1_11
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             int x = Convert.ToInt32(Console.ReadLine());
//             int y = Convert.ToInt32(Console.ReadLine());
//             int result = x * y;
            
//             int a = y/100; y -= a*100;
//             int b = y/10;  y -= b*10;
//             int c = y;

//             Console.WriteLine("{0}", x*c);
//             Console.WriteLine("{0}", x*b);
//             Console.WriteLine("{0}", x*a);
//             Console.WriteLine("{0}", result);     
//         }
//     }
// }