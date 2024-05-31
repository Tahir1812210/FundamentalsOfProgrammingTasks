using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingTasks.Loops
{
    internal class ReverseNumber
    {
        public static void reversed(int number)
        {
            if(number % 10 == 0 || number == 0)
            {
                Console.WriteLine("Number cannot be reversed");
                return;
            }

            if(number >= 1 && number <=9)
            {
                Console.WriteLine("Single Number cannot be reversed");
                return;
            }

            if(number >= -9 && number <= -1)
            {
                Console.WriteLine("Single Number cannot be reversed");
                return;
            }

            if(isHavingSameDigit(number)) 
            {
                Console.WriteLine("All Digits can't be same");
                return;
            }



            bool isNegative = number < 0;

            if(isNegative) 
            {
                number = -number;
            }

            int reverse = 0;
            int remainder = 0;

            while(number != 0)
            {
                remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number /= 10;
            }

            if(isNegative)
            {
                reverse = -reverse;
            }

            Console.WriteLine(reverse);

        }



        public static bool isHavingSameDigit(int number)
        {
            number = Math.Abs(number);

            int lastDigit = number % 10;

            int count = 0;

            while(number != 0)
            {
                int currentDigit = number % 10;

                if(lastDigit != currentDigit)
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
