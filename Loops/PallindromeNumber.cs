using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingTasks.Loops
{
    internal class PallindromeNumber
    {
        public static bool pallindrome(int number)
        {
            if (number % 10 == 0 )
            {
                Console.WriteLine("number ending with 0 cannot be pallindrome");
               return false;
            }

            if(number == 0)
            {
                Console.WriteLine("number is pallindrome");
                return true;
            }

            int reverse = 0;
            int remainder = 0;

            int pallindromevalue = number;

            while (number != 0)
            {
                remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number /= 10;
            }

            return reverse == pallindromevalue;
        }
    }

    

}
