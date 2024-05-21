using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundaAssignment
{
    internal class FindVowelOrConsonant
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an alphabet:");
            char alphabet = char.Parse(Console.ReadLine());


            char lowerCaseAlphabet = char.ToLower(alphabet);


            if (lowerCaseAlphabet == 'a' || lowerCaseAlphabet == 'e' || lowerCaseAlphabet == 'i' || lowerCaseAlphabet == 'o' || lowerCaseAlphabet == 'u')
            {
                Console.WriteLine("The alphabet is a vowel.");
            }
            else
            {
                Console.WriteLine("The alphabet is a consonant.");
            }
        }
    }
}


  
