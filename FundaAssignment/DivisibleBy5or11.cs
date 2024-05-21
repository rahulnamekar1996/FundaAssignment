using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundaAssignment
{
    internal class DivisibleBy5or11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            if (number % 5 == 0 && number % 11 == 0)
            {
                Console.WriteLine(number + " is divisible by both 5 and 11.");
            }
            else
            {
                Console.WriteLine(number + " is not divisible by both 5 and 11.");
            }

        }
    }
}
