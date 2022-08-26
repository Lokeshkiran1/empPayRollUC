using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empPayRollUC
{
    internal class MonthlyWage
    {
        public static void CalculateWageForMonth()
        {
            int empHour = 0;
            int empWage = 0;
            int totalMonthlywage = 0;
            const int EMP_RATE_PER_HOUR = 20;
            for (int day = 1; day <= 20; day++)
            {
                Random random = new Random();
                int empAtt = random.Next(1, 3);
                switch (empAtt)
                {
                    case 1: empHour = 8; break;
                    case 2: empHour = 4; break;
                    default: empHour = 0; break;
                }
                empWage = empHour * EMP_RATE_PER_HOUR;
                totalMonthlywage += empWage;
                Console.WriteLine("daily employee wage: {0} total wage on daily basis: {1}", empWage, totalMonthlywage);
            }
            Console.WriteLine("totalMonthlywage" + totalMonthlywage);
        }
    }
}
