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

        public static void FindAnimals(char[,] grids)
        {
            int rows = grids.GetLength(0);

            int cols = grids.GetLength(1);


            for(int r = 0; r < rows; r++)
            {
                string rowWord = "";

                for(int c = 0; c < cols; c++)
                {
                    rowWord += grids[r, c];
                }
                CheckWord(rowWord);
            }

        }

        private static void CheckWord(string word)
        {
          string[] words = word.Split(new char[] {' '} , StringSplitOptions.RemoveEmptyEntries);

            foreach(var w in words)
            {
                if(isAnimal(w))
                {
                    Console.WriteLine("correct");
                }
                else
                {
                    Console.WriteLine("incorrect");
                }
            }

        }

    }
}
