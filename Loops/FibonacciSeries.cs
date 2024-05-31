using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingTasks.Loops
{
    internal class FibonacciSeries
    {
        public static void fibonacci(int number)
        {
            if(number < 0)
            {
                Console.WriteLine("Negative number is not allowed");
                return;
            }


            int first = 0, second = 1, next;

            for(int i=0; i<number; i++)
            {
                if(i <= 0)
                {
                    next = i;
                }
                else
                {
                    next = first + second;
                    first = second;
                    second = next;
                }
                Console.WriteLine($"Feboncci: {next}");
            }

           
        }
    }
}
