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
            string sNum1;       //string version of number (required for input)
            string sNum2;       //as above
            string op;          //operation
            double fNum1;       //floating point of number
            double fNum2;       //as above
            bool repeat;        //bool to decide whether various loops should repeat
            double result;      //floating point answer
            string sRepeat;     //string of input to decide whether calculator will be used again

            Console.WriteLine("Welcome to the calculator.");
            Console.WriteLine("");

            do {
                Console.WriteLine("Please enter the first number...");

                do {
                    sNum1 = Console.ReadLine();
                    repeat = !(double.TryParse(sNum1, out fNum1)); // if input is a number, it will continue, if not then it will ask to re-input data
                    if (repeat)
                    {
                        Console.WriteLine("Your input was not a recognised number, please try again."); //Basic user feedback
                    }

                } while (repeat);

                Console.WriteLine("Please enter the second number...");

                do {
                    sNum2 = Console.ReadLine();
                    repeat = !(double.TryParse(sNum2, out fNum2)); // if input is a number, it will continue, if not then it will ask to re-input data
                    if (repeat)
                    {
                        Console.WriteLine("Your input was not a recognised number, please try again."); //Basic user feedback
                    }

                } while (repeat);

                Console.WriteLine("Please enter the operation... (+, -, *, /)");

                do {
                    op = Console.ReadLine();
                    repeat = !(op.Equals("+") || op.Equals("-") || op.Equals("*") || op.Equals("/")); // if input is an operator, it will continue, if not then it will ask to re-input data
                    if (repeat)
                    {
                        Console.WriteLine("Your input was not a recognised operation, please try again."); //Basic user feedback
                    }

                } while (repeat);

                if (op.Equals("+")) 
                {
                    result = fNum1 + fNum2;
                    Console.WriteLine("{0} + {1} = {2}", sNum1, sNum2, result); // Tells the user the result of their calculation
                }

                if (op.Equals("-"))
                {
                    result = fNum1 - fNum2;
                    Console.WriteLine("{0} - {1} = {2}", sNum1, sNum2, result); // As above
                }

                if (op.Equals("*"))
                {
                    result = fNum1 * fNum2;
                    Console.WriteLine("{0} * {1} = {2}", sNum1, sNum2, result); // As above
                }

                if (op.Equals("/"))
                {
                    result = fNum1 / fNum2;
                    Console.WriteLine("{0} / {1} = {2}", sNum1, sNum2, result); // As above
                }

                Console.WriteLine("");
                Console.WriteLine("Would you like to use the calculator again? (y/n)"); // Allows the user to repeat the calculator

                sRepeat = Console.ReadLine();
                repeat = (sRepeat.Equals("y") || sRepeat.Equals("Y"));

            } while (repeat);
        }
    }
}
