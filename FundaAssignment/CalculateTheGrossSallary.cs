using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundaAssignment
{
    internal class CalculateTheGrossSallary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter basic salary of the employee:");
            double basicSalary = double.Parse(Console.ReadLine());

            double hra, da;

            if (basicSalary <= 10000)
            {
                hra = 0.2 * basicSalary;
                da = 0.8 * basicSalary;
            }
            else if (basicSalary <= 20000)
            {
                hra = 0.25 * basicSalary;
                da = 0.9 * basicSalary;
            }
            else
            {
                hra = 0.3 * basicSalary;
                da = 0.95 * basicSalary;
            }

           
            double grossSalary = basicSalary + hra + da;

            Console.WriteLine("HRA: " + hra);
            Console.WriteLine("DA: " + da);
            Console.WriteLine("Gross Salary: " + grossSalary);
        }

    }
}

