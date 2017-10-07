using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double rectaglePerimeter = 2 * width + 2 * height;
            double rectangleArea = width * height;
            double rectangleDiagonal = Math.Sqrt(width * width + height * height);

            Console.WriteLine(rectaglePerimeter);
            Console.WriteLine(rectangleArea);
            Console.WriteLine(rectangleDiagonal);
        }
    }
}
