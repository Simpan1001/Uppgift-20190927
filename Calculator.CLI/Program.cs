using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            CAlculator.Component.Calculator myCalculator = new CAlculator.Component.Calculator();
            bool keepGoin = true;
            double x, y = 0;
            string test = "";

            while (keepGoin == true)
            {
                Console.WriteLine("Enter nr 1:");
                x = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter nr 2:");
                y = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter operation '+', '-', '*' or '/'");
                string op = Console.ReadLine();
                double result = 0;

                if (op == "+")
                {
                    result = myCalculator.Add(x, y);
                }else if (op == "-")
                {
                    result = myCalculator.Sub(x, y);
                }else if (op == "*")
                {
                    result = myCalculator.Mult(x, y);
                }else if (op == "/")
                {
                    result = myCalculator.Div(x, y);
                }
                Console.WriteLine("{0} {2} {1} = {3}", x, y, op, result);
                

                Console.WriteLine("Press 'X' to stop program. Press 'C' to continue.");
                test = Console.ReadLine();
                if (test.ToLower() == "x")
                {
                    keepGoin = false;
                }

            }
        }
    }
}
