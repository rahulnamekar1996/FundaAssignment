using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundaAssignment
{
    internal class AreaOfeQuilateralTringle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the side length of the equilateral triangle:");
            double sideLength = double.Parse(Console.ReadLine());

          
            double area = (Math.Sqrt(3) / 4) * Math.Pow(sideLength, 2);

            Console.WriteLine("The area of the equilateral triangle is: " + area);
        }



    }
}

