using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundaAssignment
{
    internal class FindDaysInMonth
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the month (1-12):");
            int month = int.Parse(Console.ReadLine());

            int daysInMonth;

            switch (month)
            {
                case 1:  // January
                case 3:  // March
                case 5:  // May
                case 7:  // July
                case 8:  // August
                case 10: // October
                case 12: // December
                    daysInMonth = 31;
                    break;
                case 4:  // April
                case 6:  // June
                case 9:  // September
                case 11: // November
                    daysInMonth = 30;
                    break;
                case 2:  // February
                    Console.WriteLine("Enter the year:");
                    int year = int.Parse(Console.ReadLine());
                    daysInMonth = IsLeapYear(year) ? 29 : 28;
                    break;
                default:
                    Console.WriteLine("Invalid month number.");
                    return;
            }
            Console.WriteLine("Total number of days in the month: " + daysInMonth);
        }

        static bool IsLeapYear(int year)
        {
         
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

        }
    }
}
