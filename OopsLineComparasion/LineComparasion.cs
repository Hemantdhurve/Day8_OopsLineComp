using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsLineComparasion
{
    public class LineComparasion
    {
        public double LineLength()
        {
            //double X1,X2, Y1, Y2;
            Console.WriteLine("Please enter the value of X1 and X2 as :");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X1 :" + X1);

            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X2 :" + X2);

            Console.WriteLine("Please enter the value of Y1 and Y2 as :");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y1 :" + Y1);

            int Y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y2 :" + Y2);

            //To calculate length of line using Math class

            double length = Math.Sqrt((Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2)));

            return length;
            Console.WriteLine("Length of the line is :" + length);
        }
    }
}
