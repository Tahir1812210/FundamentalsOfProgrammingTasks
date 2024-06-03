using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingTasks.Strings
{
    internal class QoutationAfterEveryName
    {
        public static void Add(string input)
        {
            string result = string.Empty;

            for(int i=0; i<input.Length; i++) 
            {
                result += input[i];

                if(i < input.Length - 1)
                {
                    result += "'";
                }

            }

            Console.WriteLine(result);

        }
    }
}
