using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingTasks.IfElse
{
    internal class PasswordValidator
    {
        public static void checkpassword(string password)
        {
            if(password.Length > 8 && password.Any(char.IsDigit))
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
        }
    }
}
