using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class UC6
    {
        public static void maxRateInMonth()
        {
            int WagePerHr = 20;
            int maxHrsInMonth = 100;
            int numberofWorkingDays = 20;
            int FullTimeHr = 8;
            int PartTimeHr = 4;
            int AbsentTimeHr = 0;
            int totalWorkingDays = 0;
            int totalEmployeeHrs = 0;
            Random random = new Random();
            int number = random.Next(3);
            int DailyWages1 = WagePerHr *= FullTimeHr;
            int DailyWages2 = WagePerHr *= PartTimeHr;
            int DailyWages0 = WagePerHr *= AbsentTimeHr;
            int DailyWages4 = DailyWages1 *= numberofWorkingDays;
            int DailyWages5 = DailyWages2 *= numberofWorkingDays;
            int DailyWages6 = DailyWages0 *= numberofWorkingDays;

            switch (number)
            {

                case 1:
                    Console.WriteLine("Full Time Employee Wages are=" + DailyWages4);
                    break;
                case 2:
                    Console.WriteLine("Part Time Employee Wages are=" + DailyWages5);
                    break;
                default:
                    Console.WriteLine("Employee Is Absent Then Wages are=" + DailyWages6);
                    break;

            }
            while (totalEmployeeHrs <= maxHrsInMonth && totalWorkingDays < numberofWorkingDays);
            Console.WriteLine(maxHrsInMonth * WagePerHr);


        } 
    }

}
    
