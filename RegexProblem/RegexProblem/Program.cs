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
                Console.WriteLine("CHOOSE OPTION\n1.Validating Firstname\n2.Validate LastName\n3.Validate Email-Id\n4.Validate Mobile Number\n5.Validate Password Rule One\n6.Validate Password UpperCase\n7.Validating Password Number\n8.Validate Password Special Character\n9.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the Firstname");
                        string firstname = Console.ReadLine();
                        regex.ValidateName(firstname);
                        break;
                    case 2:
                        Console.WriteLine("Enter the Lastname");
                        string lastname= Console.ReadLine();
                        regex.ValidateName(lastname);
                        break;
                    case 3:
                        Console.WriteLine("Enter the Email-Id");
                        string email = Console.ReadLine();
                        regex.ValidateEmail(email);
                        break;
                    case 4:
                        Console.WriteLine("Enter the mobile Number");
                        string num = Console.ReadLine();
                        regex.ValidateNumber(num);
                        break;
                    case 5:
                        Console.WriteLine("Enter the Password");
                        string pass = Console.ReadLine();
                        regex.ValidatePasswordOne(pass);
                        break;
                    case 6:
                        Console.WriteLine("Enter the Password");
                        string upperpass = Console.ReadLine();
                        regex.ValidatePasswordupper(upperpass);
                        break;
                    case 7:
                        Console.WriteLine("Enter the Password");
                        string numberpass = Console.ReadLine();
                        regex.ValidatePasswordNumber(numberpass);
                        break;
                    case 8:
                        Console.WriteLine("Enter the Password");
                        string specialpass = Console.ReadLine();
                        regex.ValidatePasswordNumber(specialpass);
                        break;
                    case 9:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("your choice should be between 1 to 9");
                        break;
                }

            }
        }
    }
}
