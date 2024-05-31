using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingTasks.Loops
{
    internal class CountVowelsInString
    {
        public static void checkVowels(string input)
        {
            int count = 0;

           for(int i = 0; i < input.Length; i++)
            {
                char lowerInput = char.ToLower(input[i]);

                if("aeiou".IndexOf(lowerInput) >= 0 ) 
                {
                    count++;
                }

            }

           Console.WriteLine($"there are {count} vowels in this word");

        }


    
    }
}
