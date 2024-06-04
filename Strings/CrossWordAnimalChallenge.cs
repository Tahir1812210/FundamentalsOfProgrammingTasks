using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingTasks.Strings
{
    internal class CrossWordAnimalChallenge
    {
        public static readonly string[] animalNames =
        {
            "cat", "dog", "elephant", "tiger", "lion", "bear", "zebra", "giraffe", "hippo", "rhino"
        };


        public static bool isAnimal(string word)
        {
            foreach(var animal in animalNames)
            {
                if(animal.Equals(word , StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }

                
            }
            return false;
        }

    }
}
