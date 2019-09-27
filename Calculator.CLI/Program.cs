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
            //Mata in två tal
            //Addera och visa svaret
            Console.WriteLine("Enter nr 1:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter nr 2:");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter operation '+' or '-'");
            string op = Console.ReadLine();

            CAlculator.Component.Calculator myCalculator = new CAlculator.Component.Calculator();

            double result = 0;
            if (op == "+")
            {
                result = myCalculator.Add(x, y);
            }
            else if (op == "-")
            {
                result = myCalculator.Sub(x, y);
            }

            Console.WriteLine("{0} {2} {1} = {3}",x ,y ,op ,result);
        }
    }
}
