using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingTasks.Loops
{
    internal class ReverseString
    {
        public static void reverse(string input)
        {
            string reversed = string.Empty;

            for(int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }
            
            Console.WriteLine($"there are total {reversed} characters");

        }
    }
}
