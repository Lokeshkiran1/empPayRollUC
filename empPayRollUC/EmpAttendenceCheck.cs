using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empPayRollUC
{
    internal class EmpAttendenceCheck
    {
        public static void EmpAtt()
        {
            Random random = new Random();
            int empAtt = random.Next(2);
            if(empAtt == 0)
                Console.WriteLine("employee is absent");
            else
                Console.WriteLine("employee is present");
        }
    }
}
