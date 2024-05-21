using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundaAssignment
{
    internal class CalculatePerAvgTot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter marks of five subjects:");

            Console.Write("Subject 1: ");
            double subject1 = double.Parse(Console.ReadLine());

            Console.Write("Subject 2: ");
            double subject2 = double.Parse(Console.ReadLine());

            Console.Write("Subject 3: ");
            double subject3 = double.Parse(Console.ReadLine());

            Console.Write("Subject 4: ");
            double subject4 = double.Parse(Console.ReadLine());

            Console.Write("Subject 5: ");
            double subject5 = double.Parse(Console.ReadLine());

            
            double total = subject1 + subject2 + subject3 + subject4 + subject5;

         
            double average = total / 5;

        
            double percentage = (total / (5 * 100)) * 100;

            Console.WriteLine("\nTotal marks: " + total);
            Console.WriteLine("Average marks: " + average);
            Console.WriteLine("Percentage: " + percentage + "%");


        }
    }
}
