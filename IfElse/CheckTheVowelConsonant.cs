using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingTasks.IfElse
{
    internal class CheckTheVowelConsonant
    {
        public static void check(char input)
        {
           if(char.IsLetter(input))
            {
                char lowerinput = char.ToLower(input);

                if("aeiou".IndexOf(lowerinput) >= 0 ) 
                {
                    Console.WriteLine("Vowel");
                }
                else
                {
                    Console.WriteLine("Consonant");
                }

            }
           else
            {
                Console.WriteLine("Invalid Character");
            }
        }
    }
}
