using System;

namespace baekjoon5_6
{
    class MainApp
    {
        static void Main()
        {
            int test = Convert.ToInt32(Console.ReadLine());
            string str = "";
            double avg = 0;
            int student = 0;
            double count = 0;

            for (int i = 0; i < test; i++)
            {
                str = Console.ReadLine();
                string[] arr = str.Split(' ');

                count = 0;
                avg = 0;
                count = 0;
                student = Convert.ToInt32(arr[0]);

                for (int j = 1; j <= student; j++)
                    avg += Convert.ToInt32(arr[j]);

                avg = avg / student;

                for (int k = 1; k <= student; k++)
                {
                    if( avg < Convert.ToInt32(arr[k]) )
                        count++;
                }

                Console.WriteLine("{0:0.000}%", (count/student)*100);
            }
        }
    }
}