using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingTasks.Loops
{
    internal class PrimeNumbers
    {
        public static void prime(int number)
        {
            bool isPrime = true;

            if(number <= 1)
            {
                Console.WriteLine("This is not a prime number");
                return;
            }
          
              for(int i = 2; i <= Math.Sqrt(number); i++)
            {
                if(number % i == 0)
                {
                    isPrime = false;
                    break;
                }

            }

            Console.WriteLine($"{number} is a " + (isPrime ? "prime number" : "not a prime number"));
        }
    }
}
