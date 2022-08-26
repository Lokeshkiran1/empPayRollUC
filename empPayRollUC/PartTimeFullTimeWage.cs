using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empPayRollUC
{
    internal class PartTimeFullTimeWage
    {
        public static void CalculateFullPartTimeWage()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            int empHrs = 0;
            const int EMP_RATE_PER_HOUR = 20;
            Random random = new Random();
            int empAtt = random.Next(1, 3);
            if(empAtt == IS_FULL_TIME)
            {
                empHrs = 8;
                Console.WriteLine("emp is present for full time");

            }
            else if(empAtt == IS_PART_TIME)
            {
                empHrs = 4;
                Console.WriteLine("emp is present part time");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("emp is absent");
            }
            int empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("emp daily wage including part time: "+empWage);

        }
    }
}
