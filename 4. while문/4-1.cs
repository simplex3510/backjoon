using System;

namespace backjoon4_1
{
    class MainApp
    {
        static void Main()
        {
            string str = "";
            string[] arr = null;

            int? a = null;
            int? b = null;

            while (true)
            {
                str = Console.ReadLine();
                arr = str.Split(' ');

                a = Convert.ToInt32(arr[0]);
                b = Convert.ToInt32(arr[1]);

                if ((a==0) && (b==0))
                    break;
                else
                    Console.WriteLine($"{a+b}");
            }
        }
    }
}