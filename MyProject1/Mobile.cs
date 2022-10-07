using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Text.RegularExpressions;

using System.Threading.Tasks;



namespace regularexpression

{

    internal class Mobile

    {

        public static void Main()

        {

            number();

        }

        public static void number()

        {

            Console.WriteLine("Enter the 10 digit mobile number");

            var number = Console.ReadLine();

            var validate_number = Regex.IsMatch(number, @"^[987]\d{9}$");

            Console.WriteLine(validate_number);



        }

    }

}