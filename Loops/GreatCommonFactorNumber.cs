using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingTasks.Loops
{
    internal class GreatCommonFactorNumber
    {
        public static void find(int a , int b)
        {
            if(a <= 0 || b <= 0)
            {
                Console.WriteLine("Number should be positive not negative");
                return;
            }

            int remainder = 0;

            while(b != 0)
            {
                remainder = a % b;
                a = b;
                b = remainder;
            }

            Console.WriteLine($"Great Common Factor is: {a}");

        }
    }
}
