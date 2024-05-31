using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingTasks.IfElse
{
    internal class BMICalculator
    {
        public static void calculate(double height , double weight)
        {
            if(height < 0)
            {
                Console.WriteLine("Wrong Height, Can't be negative");
                return;
            }

            double BMI = weight / (height * height);

            //Console.WriteLine($"Your BMI is: {BMI}");

            string category = BMI < 18 ? "underweight" :
                BMI < 25 ? "good weight" :
                BMI < 30 ? "overweight" : "obese";

            Console.WriteLine($"Your BMI falls under category: {category}");

        }
    }
}
