using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundaAssignment
{
    internal class CalculateElectricityBill
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter electricity consumption unit:");
            int units = int.Parse(Console.ReadLine());

            double billAmount = 0;

            if (units <= 50)
            {
                billAmount = units * 0.50;
            }
            else if (units <= 150)
            {
                billAmount = 50 * 0.50 + (units - 50) * 0.75;
            }
            else if (units <= 250)
            {
                billAmount = 50 * 0.50 + 100 * 0.75 + (units - 150) * 1.20;
            }
            else
            {
                billAmount = 50 * 0.50 + 100 * 0.75 + 100 * 1.20 + (units - 250) * 1.50;
            }

          
            billAmount += billAmount * 0.20;

            Console.WriteLine("Total electricity bill: Rs. " + billAmount);

        }
    }
}
