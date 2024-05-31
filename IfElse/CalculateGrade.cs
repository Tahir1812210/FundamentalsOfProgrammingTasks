using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingTasks.IfElse
{
    internal class CalculateGrade
    {
        public static void grade(double number)
        {
            if(number < 0 || number > 100)
            {
                Console.WriteLine("Invalid Score");
            }

            char grade =
                number > 90 ? 'A' :
                number > 80 ? 'B' :
                number > 70 ? 'C' :
                number > 60 ? 'D' :
                number > 50 ? 'E' : 'F';

            Console.WriteLine(grade);

        }
    }
}
