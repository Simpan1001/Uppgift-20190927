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
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter nr 2:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter operation '+' or '-'");
            string op = Console.ReadLine();

            Calculator.Component.Calculator myCalculator = new Component.Calculator();
            Console.WriteLine("{0} {1} {2} = {3}",x ,y ,result ,op );
        }
    }
}
