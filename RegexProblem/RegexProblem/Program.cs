using System;

namespace RegexProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleRegex regex = new SampleRegex();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("CHOOSE OPTION\n1.Validating Firstname\n2.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the firstname");
                        string firstname = Console.ReadLine();
                        regex.ValidateName(firstname);
                        break;
                    case 2:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("your choice should be between 1 to 2 ");
                        break;
                }

            }
        }
    }
}
