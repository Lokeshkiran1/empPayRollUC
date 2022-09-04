﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empPayRollUC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to employee wage computation");
            Console.WriteLine("choose option\n 1. check Attendence\n 2. DailyWage\n 3. Part & Full Time wage\n 4. Monthly Wage\n 5. total employee salary with max days 20 and max hours 100\n6.Refactor method to compute employee wage ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                        EmpAttendenceCheck.EmpAtt();
                        break;
                case 2:
                        DailyWage.DailyWageCalculation();
                        break;
                case 3:
                    PartTimeFullTimeWage.CalculateFullPartTimeWage();
                    break;
                case 4:
                    MonthlyWage.CalculateWageForMonth();
                    break;
                case 5:
                    empWageMaxCondition.CalculateEmpWageWhile();
                    break;
                case 6:
                    int wage=RefactorMethodToComputeEmpWage.computeEmpWage();
                    Console.WriteLine("total monthly wage: "+wage);
                    break;

                default:
                        Console.WriteLine("entered wrong option");
                        break;           
            }

        }
    }
}
