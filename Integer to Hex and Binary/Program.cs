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
            int number = int.Parse(Console.ReadLine());

            string numberToHex = number.ToString("X1");


            Console.WriteLine(numberToHex);
            Console.WriteLine(Convert.ToString(number, 2));


        }
    }
}
