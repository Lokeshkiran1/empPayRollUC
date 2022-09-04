using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empPayRollUC
{
    internal class RefactorMethodToComputeEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int MAX_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        public static int computeEmpWage()
        {
            //Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //computation
            while(totalEmpHrs<=MAX_HRS_IN_MONTH && totalWorkingDays<=MAX_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empAtt = random.Next(0, 3);
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
                totalEmpHrs+=empHrs;
                Console.WriteLine("Day#:"+totalWorkingDays+" employee hours "+empHrs);
            }
            int totalEmpWage=totalEmpHrs*EMP_RATE_PER_HOUR;
            //Console.WriteLine("Total employee wage: "+totalEmpWage);
            return totalEmpWage;
        }
    }
}
