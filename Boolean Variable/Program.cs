using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            bool text2 = Convert.ToBoolean(text);
            if (text2 == true)
            {
                Console.WriteLine("Yes");
            }
            else if (text2 == false)
            {
                Console.WriteLine("No");

            }

        }
    }
}
