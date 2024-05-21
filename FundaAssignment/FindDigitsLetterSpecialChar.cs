using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundaAssignment
{
    internal class FindDigitsLetterSpecialChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character:");
            char character = Console.ReadKey().KeyChar;

        
            if ((character >= 'a' && character <= 'z') || (character >= 'A' && character <= 'Z'))
            {
                Console.WriteLine("\nThe character is an alphabet.");
            }
         
            else if (character >= '0' && character <= '9')
            {
                Console.WriteLine("\nThe character is a digit.");
            }
         
            else
            {
                Console.WriteLine("\nThe character is a special character.");
            }
        }

    }

}
