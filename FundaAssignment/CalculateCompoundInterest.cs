using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundaAssignment
{
    internal class CalculateCompoundInterest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter principal amount (P):");
            double principal = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter time period in years (T):");
            double timePeriod = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter rate of interest per annum (R) in percentage:");
            double rateOfInterest = double.Parse(Console.ReadLine());

         
            rateOfInterest = rateOfInterest / 100;

         
          
            double compoundInterest = principal * Math.Pow((1 + rateOfInterest), timePeriod) - principal;

            Console.WriteLine("Compound Interest: " + compoundInterest);
        }
    }


}
    

