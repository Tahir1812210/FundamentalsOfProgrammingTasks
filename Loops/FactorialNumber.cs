using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingTasks.Loops
{
    internal class FactorialNumber
    {
        public static void factorial(int number)
        {
            if(number < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers");
                return;
            }

            int fact = 1;

            for(int i=1; i<=number; i++)
            {
                fact *= i;
            }

            Console.WriteLine(fact);

        }
    }
}
