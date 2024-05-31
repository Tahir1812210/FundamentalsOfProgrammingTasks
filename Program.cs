using FundamentalsOfProgrammingTasks.IfElse;
using FundamentalsOfProgrammingTasks.Loops;
using System;
using System.Globalization;
using System.Numerics;

class Program
{
    static void Main()
    {
        //Topic if else



        //Calculate Positive Or Negative Number

        //Console.Write("Enter a number: ");
        //string input = Console.ReadLine();
        //if (double.TryParse(input, out double number))
        //{
        //    PositiveAndNegativeNumber.check(number);
        //}
        //else if (string.IsNullOrWhiteSpace(input))
        //{
        //    Console.WriteLine("Empty or null values are not excepted");
        //    return;
        //}
        //else
        //{
        //    Console.WriteLine("Invalid Entered");
        //}


        //Console.Write("Enter a number: ");





        //Calculate Even or Odd number

        //string input = Console.ReadLine();

        //if (BigInteger.TryParse(input, out BigInteger number))
        //{
        //    if (number == (long)number)
        //    {
        //        EvenAndOddNumber.number((long)number);
        //    }
        //    else if (number != (long)number)
        //    {
        //        Console.WriteLine("Out Of Range");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Decimal Number");
        //    }
        //}
        //else if(string.IsNullOrWhiteSpace(input))
        //{
        //    Console.WriteLine("Null or White Space entered which is exception");
        //}
        //else
        //{
        //    Console.WriteLine("Invalid Entered");
        //}


        //Calculate Grades

        //Console.Write("Enter Marks: ");

        //string input = Console.ReadLine(); 

        //if (double.TryParse(input, out double number))
        //{
        //    CalculateGrade.grade(number);
        //}
        //else if(string.IsNullOrWhiteSpace(input))
        //{
        //    Console.WriteLine("Null Or Exceptions are not expected");

        //}
        //else
        //{
        //    Console.WriteLine("Invalid Value");
        //}



        //leap year

        //Console.Write("Enter the year: ");

        //string input = Console.ReadLine();
        //if (int.TryParse(input, out int year))
        //{
        //    LeapYear.checkyear(year);

        //}
        //else if (string.IsNullOrEmpty(input))
        //{
        //    Console.WriteLine("Null or Empty Values are not excepted");

        //}
        //else 
        //{
        //    Console.WriteLine("year cannot be in decimal");

        //}

        //Console.Write("Enter first number: ");

        //string input1 = Console.ReadLine() ;

        //Console.Write("Enter second number: ");

        //string input2 = Console.ReadLine();

        //Console.Write("Enter third number: ");
        //string input3 = Console.ReadLine();

        //if (double.TryParse(input1 , out double number1) && double.TryParse(input2, out double number2) && double.TryParse(input3, out double number3))
        //{
        //    LargeNumber.findlarge(number1 , number2 , number3);
        //}
        //else if(string.IsNullOrWhiteSpace(input1) && string.IsNullOrWhiteSpace(input2) && string.IsNullOrWhiteSpace(input3))
        //{
        //    Console.WriteLine("Null or white space is not allowed");
        //}
        //else
        //{
        //    Console.WriteLine("Invalid Character");
        //}


        //basic calculator
        //Console.Write("Enter first number: ");
        //string input1 = Console.ReadLine();

        //Console.Write("Enter second number: ");
        //string input2 = Console.ReadLine();

        //Console.Write("Enter operand * (multiply) or + (add) or / (divide) or - (subtract): ");
        //string input3 = Console.ReadLine();

        //char operator3 = char.MinValue;

        //if(double.TryParse(input1, out double num1) && double.TryParse(input2, out double num2) && char.TryParse(input3,  out operator3))
        //{
        //   double output = BasicCalculator.calculator(num1 , num2 , operator3);
        //    Console.WriteLine(output);
        //}
        //else if(string.IsNullOrWhiteSpace(input3))
        //{
        //    Console.WriteLine("Null or Exception Value");
        //}
        //else
        //{
        //    Console.WriteLine("invalid");
        //}


        // bmi calculator
        //Console.Write("Enter Height in Metres: ");
        //string input1 = Console.ReadLine();

        //Console.Write("Enter Weight in KG: ");
        //string input2 = Console.ReadLine();

        //if(double.TryParse(input1, out double height) && double.TryParse(input2 , out double weight))
        //{
        //    BMICalculator.calculate(height , weight);
        //}
        //else if(string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2))
        //{
        //    Console.WriteLine("Null value is not allowed");
        //}
        //else
        //{
        //    Console.WriteLine("Invalid");
        //}

        //Password Checker
        //Console.Write("Enter Password: ");
        //string password = Console.ReadLine();

        //PasswordValidator.checkpassword(password);


        //Vowel Consont

        //Console.WriteLine("Enter a character");

        //char input = Console.ReadKey().KeyChar;

        //Console.WriteLine();

        //CheckTheVowelConsonant.check(input);





        //Topic loops

        //Console.Write("Enter the range: ");

        //string input1 = Console.ReadLine();


        //if(int.TryParse(input1 , out int number))
        //{
        //    PrintNumbers.Print(number);
        //}
        //else if(string.IsNullOrWhiteSpace(input1))
        //{
        //    Console.WriteLine("Null is not allowed");
        //}
        //else
        //{
        //    Console.WriteLine("Invalid Entered");
        //}


        //Console.Write("Enter the range: ");

        //string input1 = Console.ReadLine();


        //if (int.TryParse(input1, out int number))
        //{
        //    SumOfNNatural.sum(number);
        //}
        //else if (string.IsNullOrWhiteSpace(input1))
        //{
        //    Console.WriteLine("Null is not allowed");
        //}
        //else
        //{
        //    Console.WriteLine("Invalid Entered");
        //}


        // reverse the string
        // Console.Write("Enter the word: ");

        // string input1 = Console.ReadLine();


        //if (string.IsNullOrWhiteSpace(input1))
        // {
        //     Console.WriteLine("Null is not allowed");
        // }
        // else if (int.TryParse(input1, out _) || double.TryParse(input1, out _))
        // {
        //     Console.WriteLine("Invalid Entered");

        // }
        // else
        // {
        //     ReverseString.reverse(input1);
        // }

        // count vowels in string

        //Console.Write("Enter Word: ");

        //string input1 = Console.ReadLine();

        //if(string.IsNullOrEmpty(input1))
        //{
        //    Console.WriteLine("Null or Exception Value");
        //}
        //else if(int.TryParse(input1, out _) || double.TryParse(input1, out _))
        //{
        //    Console.WriteLine("Invalid Entered");
        //}
        //else
        //{
        //   CountVowelsInString.checkVowels(input1);
        //}


        //multiplication table

        //Console.Write("Enter Number: ");

        //string input1 = Console.ReadLine();

        //if (string.IsNullOrEmpty(input1))
        //{
        //    Console.WriteLine("Null or Exception Value");
        //}
        //else if (int.TryParse(input1, out int number1)  )
        //{
        //    MultiplicationTable.multiply(number1);
        //}
        //else if(double.TryParse(input1, out double number2))
        //{
        //    MultiplicationTable.multiply(number2);
        //}
        //else
        //{
        //    Console.WriteLine("Invalid Entered");
        //}



        //factorial number

        Console.Write("Enter Number: ");

        string input1 = Console.ReadLine();

        if (string.IsNullOrEmpty(input1))
        {
            Console.WriteLine("Null or Exception Value");
        }
        else if (int.TryParse(input1, out int number1))
        {
            FactorialNumber.factorial(number1);
        }
        else
        {
            Console.WriteLine("Invalid Entered");
        }

    }
}
