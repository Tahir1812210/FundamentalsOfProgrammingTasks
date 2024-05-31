using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingTasks.Loops
{
    internal class PrintNumbers
    {
        public static void Print(double numbers)
        {

            for(int i = 1; i <= numbers; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
