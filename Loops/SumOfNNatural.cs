using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingTasks.Loops
{
    internal class SumOfNNatural
    {
        public static void sum(int number)
        {
            var sum = 0;

            if(number < 0)
            {
                Console.WriteLine("Natural Numbers Can't Be Negative");
                return;
            }
           

            for(int i = 1; i <= number; i++) 
            {
                sum += i;
            }

            Console.WriteLine($"Sum of natural numbers are: {sum}");

        }
    }
}
