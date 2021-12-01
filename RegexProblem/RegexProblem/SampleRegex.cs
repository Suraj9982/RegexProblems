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
        public void ValidateName(string Firstname)
        {
            Regex regex = new Regex(NamePattern);
            bool result = regex.IsMatch(Firstname);
            if (result)
            {
                Console.WriteLine("firstname is valid");
            }
            else
            {
                Console.WriteLine("please enter valid firstname or firstname must have starts with capital letter");
            }
        }
    }
}
