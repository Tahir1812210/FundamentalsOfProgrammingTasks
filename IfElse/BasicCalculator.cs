using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingTasks.IfElse
{
    internal class BasicCalculator
    {
        public static double calculator(  double num1 , double num2 , char operators)
        {
            double calculate = double.MinValue;
             if(operators == '/')
            {
                 calculate = num1 / num2;
                return calculate;
            }
             else if(operators == '*')
            {
                calculate = num1 * num2;
                return calculate;
            }
             else if(operators == '+')
            {
                calculate = num1 + num2;
                return calculate;
            }
             else if(operators == '-')
            {
                calculate = num1 - num2;
                return calculate;
            }
             else
            {
                Console.WriteLine("Invalid Operator");
            }

            return 0;
        }
    }
}
