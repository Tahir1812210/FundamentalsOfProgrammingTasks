using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingTasks.Loops
{
    internal class AmstrongNumber
    {
        public static void checkAmstrong(int number)
        {
            if(number < 0)
            {
                Console.WriteLine("Number cannot be negative");
            }

            

            int numDigits = number.ToString().Length;

            int originalNumber = number;

            int sum = 0;

            int digit = 0;

            while(number != 0)
            {
                digit = number % 10;

                sum += (int)Math.Pow(digit, numDigits);

                number /= 10;
            }

            if(sum == originalNumber)
            {
                Console.WriteLine($"Its amstrong because the original number is {originalNumber} and its amstrong is also {sum}");
            }
            else
            {
                Console.WriteLine($"Its not amstrong because the original number is {originalNumber} which is not equivalent to it amstrong {sum}");
            }
        }
    }
}
