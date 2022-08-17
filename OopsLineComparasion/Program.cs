using System;

namespace OopsLineComparasion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Oops Based Line Comparasion Problem");

            bool check = true;

            //start : is used to repeat again using goto
            start:
            while (check)
            {
                Console.WriteLine("Select option  :\n" + 
                    "1)To Calculate Length of Line\n" + 
                    "2)To Check Equality Of Line\n" + 
                    "3)To Check Length of Line is greater or less\n");

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

                    case 2:
                        Console.WriteLine("Enter co-ordinates of Line No.1 : ");
                        LineComparasion line1= new LineComparasion();
                        double result1 = line1.LineLength();
                        Console.WriteLine("length of Line no.1 is :" + result1);
                        Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");


                        Console.WriteLine("Enter co-ordinates of Line No.2 : ");
                        LineComparasion line2 = new LineComparasion();
                        double result2 = line2.LineLength();
                        Console.WriteLine("length of Line no.2 is :" + result2);
                        Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");


                        Console.WriteLine("Now checking Equality of Line");
                        Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                        if (result1.Equals(result2))
                        {
                            Console.WriteLine("Both Line lengths are Equal");
                        }
                        else
                        {
                            Console.WriteLine("Both Line Lengths are Not Equal");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter co-ordinates of Line No.1 : ");
                        LineComparasion line3 = new LineComparasion();
                        double result3 = line3.LineLength();
                        Console.WriteLine("length of Line no.1 is :" + result3);
                        Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");


                        Console.WriteLine("Enter co-ordinates of Line No.2 : ");
                        LineComparasion line4 = new LineComparasion();
                        double result4 = line4.LineLength();
                        Console.WriteLine("length of Line no.2 is :" + result4);
                        Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");


                        Console.WriteLine("Now Comparing Length of Lines as :");

                        Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                        if (result3.Equals(result4))
                        {
                            Console.WriteLine("Length of Line No. 1 is Equal to Line No. 2");
                        }
                        else if (result3.CompareTo(result4) > 0)
                        {
                            Console.WriteLine("Length of Line No. 1 is greater than Line No. 2");
                        }
                        else
                        {
                            Console.WriteLine("Length of Line No. 1 is less than Line No. 2");
                        }
                       break ;

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