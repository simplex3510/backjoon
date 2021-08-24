using System;

namespace baekjoon8_9
{
    class MainApp
    {
        static uint Move(uint curr, uint goal)
        {
            uint distance = goal - curr;
            uint max = (uint)(Math.Sqrt(distance));

            if (max == Math.Sqrt(distance))
                return (2 * max - 1);

            else if ((max * max) < distance && distance <= (max * max) + max)
                return (2 * max - 1) + 1;

            else if ((max * max) + max < distance && distance <= (max * max) + max + max)
                return (2 * max - 1) + 2;
            
            else
                return 0;
        }

        static void Main()
        {
            int test = Convert.ToInt32(Console.ReadLine());
            string[] str;
            uint curr = 0;
            uint goal = 0;

            for (int i = 0; i < test; i++)
            {
                str = Console.ReadLine().Split(' ');
                curr = Convert.ToUInt32(str[0]);
                goal = Convert.ToUInt32(str[1]);

                Console.WriteLine(Move(curr, goal));
            }
        }
    }
}