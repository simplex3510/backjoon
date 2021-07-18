using System;

namespace backjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string[] arr = s.Split(new string[] {" "}, StringSplitOptions.None);

            int a = Convert.ToInt32(arr[0]);
            int b = Convert.ToInt32(arr[1]);

            Console.WriteLine($"{a+b}");
        }
    }
}
