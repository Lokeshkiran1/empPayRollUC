using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empPayRollUC
{
    internal class EmpWageMultipleCompanies
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public static int computeEmpWage(string company, int ratePerHour, int maxDaysPerMonth, int maxHoursPerMonth)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while(totalEmpHrs<=maxHoursPerMonth && totalWorkingDays<=maxDaysPerMonth)
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
                totalEmpHrs += empHrs;
                Console.WriteLine("day#:"+totalWorkingDays+"total hours:"+totalEmpHrs);
            }
            int totalEmpWage=totalEmpHrs*ratePerHour;
            Console.WriteLine("Total Monthly Salary of company: "+company+" is "+totalEmpWage);
            return totalEmpWage;
        }
        
    }
}
