using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundaAssignment
{
    internal class ConvertCelciusToFernite
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature in Fahrenheit:");
            double fahrenheit = double.Parse(Console.ReadLine());

        
            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("Temperature in Celsius: " + celsius);
        }

    }
}

