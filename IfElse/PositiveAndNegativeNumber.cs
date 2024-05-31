using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingTasks.IfElse
{
    public class PositiveAndNegativeNumber
    {
        public static void check(double number)
        {
            if(number > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if(number < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else
            {
                Console.WriteLine("Number is 0");
            }
        }
    }
}
