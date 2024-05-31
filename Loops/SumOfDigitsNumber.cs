using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingTasks.Loops
{
    internal class SumOfDigitsNumber
    {
        public static void sum(int number)
        {
            if(number < 1)
            {
                Console.WriteLine("Number should be positive not negative");
            }

            int sum = 0;

            while(number != 0)
            {
                sum += number % 10;

                number /= 10;

            }

            Console.WriteLine($"Sum of digits is: {sum}");

        }
    }
}
