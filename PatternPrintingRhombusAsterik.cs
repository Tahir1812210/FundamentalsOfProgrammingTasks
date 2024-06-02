using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingTasks
{
    internal class PatternPrintingRhombusAsterik
    {
       
        public static void print(int size)
        {
           
            if(size < 0)
            {
                Console.WriteLine("Size cannot be negative, it should be positive");
                return;
            }

            for(int i =1; i <= size; i++)
            {
                for(int j = 1; j <= size - i; j++)
                {
                    Console.Write(" ");
                }

                for(int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            for(int i = size - 1; i >=1; i--)
            {
                for(int j = 1; j <= size - i; j++)
                {
                    Console.Write(" ");
                }

                for(int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }

    }
}
