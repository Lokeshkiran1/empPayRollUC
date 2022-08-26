using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empPayRollUC
{
    internal class EmpWageFullPartTimeSwitch
    {
        public static void CalculateFullPartTimeWageSwitch()
        {
            int empHrs = 0;
            const int EMP_RATE_PER_HOUR = 20;
            Random random = new Random();
            int empAtt = random.Next(1, 3);
            switch (empAtt)
            {
                case 1:
                    empHrs = 8;
                    Console.WriteLine("emp is present for full time");
                    break;
                case 2:
                    empHrs = 4;
                    Console.WriteLine("emp is present part time");
                    break;
                default:
                    empHrs = 0;
                    Console.WriteLine("emp is absent");
                    break;
            }
            int empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("emp daily wage including part time: " + empWage);
        
        }
    }
}
