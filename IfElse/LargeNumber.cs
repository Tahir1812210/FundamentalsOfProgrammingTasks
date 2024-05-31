using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingTasks.IfElse
{
    internal class LargeNumber
    {
        public static void findlarge(double num1 , double num2 , double num3)
        {
            double largest = num1;

            if(num2 > largest)
            {
                largest = num2;
                Console.WriteLine($"The largest number is: {largest}");
            }
            else if(num3 > largest)
            {
                largest = num3;
                Console.WriteLine($"The largest number is: {largest}");
            }
            else 
            {
                Console.WriteLine("No largest number is found");
            }

            

        }
    }
}
