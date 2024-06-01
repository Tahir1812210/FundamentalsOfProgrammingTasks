using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingTasks.Loops
{
    internal class PallindromeNumber
    {
        public static void pallindrome(int number)
        {
            if (number % 10 == 0 )
            {
                Console.WriteLine("number ending with 0 cannot be pallindrome");
               return ;
            }

            if(number == 0)
            {
                Console.WriteLine("0 is not pallindrome");
                return ;
            }

            if(number >= 2 && number <= 9) 
            {
                Console.WriteLine("Single digit cannot be pallindrome");
                return ;
            }

            if(number >= -9 && number <= -2)
            {
                Console.WriteLine("Negative Single digit cannot be pallindrome like positive");
                return ;
            }

            if(isSameDigit(number)) 
            {
                Console.WriteLine("Same digit number cannot be pallindrome");
                return ;
            }

            bool isNegative = number < 0;

            if (isNegative)
            {
                number = -number;
            }


            int reverse = 0;
            int remainder = 0;

            int pallindromevalue = number;
            int absoluteNumber = Math.Abs(number);

            while (absoluteNumber != 0)
            {
                remainder = absoluteNumber % 10;
                reverse = (reverse * 10) + remainder;
                absoluteNumber /= 10;
            }

            if (number < 0)
            {
                reverse = -reverse;
            }

            if (pallindromevalue == reverse)
            {
                Console.WriteLine($"It is a palindrome because the reverse is {reverse}, which is equivalent to the original number {pallindromevalue}.");
            }
            else
            {
                Console.WriteLine($"It is not a palindrome because the reverse is {reverse}, which is not equivalent to the original number {pallindromevalue}.");
            }
        }

        public static bool isSameDigit(int number)
        {
            number = Math.Abs(number);

            int lastdigit = number % 10;

            int count = 0;

            while(number != 0)
            {
                int currentdigit = number % 10;
                if(lastdigit != currentdigit)
                {
                    return false;
                }
                count++;
                number /= 10;

                
            }

            return count >= 2;
        }

    }

    

}
