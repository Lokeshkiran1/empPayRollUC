using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empPayRollUC
{
    internal class empWageMaxCondition
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int MAX_HOURS_PER_MONTH = 100;
        public const int MAX_DAYS_PER_MONTH = 20;
        public const int RATE_PER_HOUR = 20;
        public static void CalculateEmpWageWhile()
        {
            int empHrs = 0, totalHrs = 0,totalDays = 0;
            while(totalDays<=MAX_DAYS_PER_MONTH && totalHrs<=MAX_HOURS_PER_MONTH)
            {
                totalDays++;
                Random random = new Random();
                int empAtt=random.Next(0,3);
                switch(empAtt)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                        case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalHrs+=empHrs;
            }
            int totalSalary=totalHrs*RATE_PER_HOUR;
            Console.WriteLine("Days {0} and totalEmpHrs {1}",totalDays,totalHrs);
            Console.WriteLine("total salary{0}",totalSalary);
        }
    }
}
