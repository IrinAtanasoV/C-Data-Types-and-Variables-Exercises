using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char character = char.Parse(Console.ReadLine());

            bool isVowel = "aeiouAEIOU".IndexOf(character) >= 0;
            bool isDidit = "1234567890".IndexOf(character) >= 0;


            if (isVowel == true)
            {
                Console.WriteLine("vowel");

            }
            else if (isDidit == true)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }


        }
    }
}
