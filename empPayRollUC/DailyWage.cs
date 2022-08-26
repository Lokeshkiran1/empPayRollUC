using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empPayRollUC
{
    internal class DailyWage
    {
        public static void DailyWageCalculation()
        {
            int empHrs;
            const int RATE_PER_HOUR = 20;
            Random random = new Random();
            int empAtt = random.Next(2);
            if (empAtt == 0)
            {
                empHrs = 0;
            }
            else
            {
                empHrs = 8;
            }
            int DailyWage = empHrs * RATE_PER_HOUR;
            Console.WriteLine(DailyWage);
;
        }
    }
}
