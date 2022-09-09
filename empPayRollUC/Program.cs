using System;
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
            Console.WriteLine("choose option\n1.check Attendence\n2.DailyWage\n3.Part & Full Time wage\n4.Monthly Wage\n5.total employee salary with max days 20 and max hours 100\n6.Refactor method to compute employee wage\n7.Refactor method to compute empWage\n8.Employee Wage for multiple companies\n9.Ability to save wage for each company");
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
                    EmpWageFullPartTimeSwitch.CalculateFullPartTimeWageSwitch();                    
                    break;
                case 6:
                    empWageMaxCondition.CalculateEmpWageWhile();
                    break;
                case 7:
                    int wage = RefactorMethodToComputeEmpWage.computeEmpWage();
                    Console.WriteLine("total monthly wage" + wage);
                    break;
                case 8:
                    EmpWageMultipleCompanies.computeEmpWage("Bell", 20, 20, 100);
                    EmpWageMultipleCompanies.computeEmpWage("Infosis", 20, 22, 110);
                    break;
                case 9:
                    AbilityToSaveWageforEachCompany bell=new AbilityToSaveWageforEachCompany("Bell",20,20,100);
                    AbilityToSaveWageforEachCompany infosis = new AbilityToSaveWageforEachCompany("Infosis",20,30,100);
                    bell.computeEmpWage();
                    Console.WriteLine(bell.ToString());
                    infosis.computeEmpWage();
                    Console.WriteLine(infosis.ToString());

                    break;




                default:
                        Console.WriteLine("entered wrong option");
                        break;           
            }

        }
    }
}
