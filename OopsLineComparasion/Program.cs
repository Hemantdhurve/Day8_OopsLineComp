using System;

namespace OopsLineComparasion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Oops Based Line Comparasion Problem");

            bool check = true;

            int resilt = 0;

            //start : is used to repeat again using goto
            start:
            while (check)
            {
                Console.WriteLine("Select option  :\n" + 
                    "1)To Calculate Length of Line");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        LineComparasion line = new LineComparasion();
                        double result = line.LineLength();
                        Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("Length of the line is :" + result );
                        Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                        break;

                    default:
                        Console.WriteLine("Please enter proper option");
                        break;

                }
                Console.WriteLine("Do you want to check another program ");
                goto start;
            }
        }
    }
}