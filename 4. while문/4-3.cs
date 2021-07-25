using System;

namespace backjoon4_3
{
    class MainApp
    {
        static void Main()
        {
            int org_num =  Convert.ToInt32(Console.ReadLine());

            int? old_num   = org_num;
            int? old_R_num = null;
            int? old_L_num = null;

            int? new_num   = null;
            int? new_R_num = null;

            int count = 0;

            while(new_num != org_num)
            {
                old_L_num = old_num / 10;
                old_R_num = old_num % 10;
                new_R_num = old_L_num + old_R_num;

                if(new_R_num >= 10)
                    new_R_num = new_R_num%10;

                new_num = (old_R_num*10) + (new_R_num);
                old_num = new_num;
                count++;
            }

            Console.WriteLine($"{count}");
        }
    }
}