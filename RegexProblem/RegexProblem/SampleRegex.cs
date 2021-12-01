using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    class SampleRegex
    {
        string NamePattern = "^[A-Z][a-z]{2,}$";
        string Emailpattern = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";
        string NumberPattern = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
        public void ValidateName(string Firstname)
        {
            Regex regex = new Regex(NamePattern);
            bool result = regex.IsMatch(Firstname);
            if (result)
            {
                Console.WriteLine("name is valid");
            }
            else
            {
                Console.WriteLine("please enter valid name or name must have starts with capital letter");
            }
        }
        public void ValidateEmail(string Email)
        {
            Regex regex = new Regex(Emailpattern);
            bool email = regex.IsMatch(Email);
            if (email)
            {
                Console.WriteLine("valid email");
            }
            else
            {
                Console.WriteLine("please Enter Valid Email");
            }
        }
        public void ValidateNumber(string number)
        {
            Regex regex = new Regex(NumberPattern);
            bool num = regex.IsMatch(number);
            if (num)
            {
                Console.WriteLine("Number is Valid");
            }
            else
            {
                Console.WriteLine("Please enter valid number");
            }
        }
    }
}
