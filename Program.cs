using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string sNum1;
            string sNum2;
            string op;
            double fNum1;
            double fNum2;
            bool repeat;
            double result;
            string sRepeat;

            Console.WriteLine("Welcome to the calculator.");
            Console.WriteLine("");

            do {
                Console.WriteLine("Please enter the first number...");

                do {
                    sNum1 = Console.ReadLine();
                    repeat = !(double.TryParse(sNum1, out fNum1));
                    if (repeat)
                    {
                        Console.WriteLine("Your input was not a recognised number, please try again.");
                    }

                } while (repeat);

                Console.WriteLine("Please enter the second number...");

                do {
                    sNum2 = Console.ReadLine();
                    repeat = !(double.TryParse(sNum2, out fNum2));
                    if (repeat)
                    {
                        Console.WriteLine("Your input was not a recognised number, please try again.");
                    }

                } while (repeat);

                Console.WriteLine("Please enter the operation... (+, -, *, /)");

                do {
                    op = Console.ReadLine();
                    repeat = !(op.Equals("+") || op.Equals("-") || op.Equals("*") || op.Equals("/"));
                    if (repeat)
                    {
                        Console.WriteLine("Your input was not a recognised operation, please try again.");
                    }

                } while (repeat);

                if (op.Equals("+"))
                {
                    result = fNum1 + fNum2;
                    Console.WriteLine("{0} + {1} = {2}", sNum1, sNum2, result);
                }

                if (op.Equals("-"))
                {
                    result = fNum1 - fNum2;
                    Console.WriteLine("{0} - {1} = {2}", sNum1, sNum2, result);
                }

                if (op.Equals("*"))
                {
                    result = fNum1 * fNum2;
                    Console.WriteLine("{0} * {1} = {2}", sNum1, sNum2, result);
                }

                if (op.Equals("/"))
                {
                    result = fNum1 / fNum2;
                    Console.WriteLine("{0} / {1} = {2}", sNum1, sNum2, result);
                }

                Console.WriteLine("");
                Console.WriteLine("Would you like to use the calculator again? (y/n)");

                sRepeat = Console.ReadLine();
                repeat = (sRepeat.Equals("y") || sRepeat.Equals("Y"));

            } while (repeat);
        }
    }
}
