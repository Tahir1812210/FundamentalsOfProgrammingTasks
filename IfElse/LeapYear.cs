using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingTasks.IfElse
{
    internal class LeapYear
    {
        public static void checkyear(int number)
        {
            if(number % 4 == 0 && number % 100 != 0 || (number % 400 == 0))
            {
                Console.WriteLine("This is a Leap Year");
            }
            else
            {
                Console.WriteLine("This is not a Leap Year");
            }
        }
    }
}
