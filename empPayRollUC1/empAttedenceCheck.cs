using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empPayRollUC1
{
    internal class empAttedenceCheck
    {
        public static void EmpAtt()
        {
            int empHrs;
            const int EMP_RATE_PER_HOUR = 20;
            Random random = new Random();
            int empAtt = random.Next(2);
            if (empAtt == 0) 
                Console.WriteLine("employee is absent");
            else
                Console.WriteLine("employee is present");
        } 
    }
}
