using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;





   

        public class InvalidAgeException : Exception

        {

            public InvalidAgeException(String message) : base(message)

            {

            }

        }

        public class AgeExample

        {

            static void validate(int age)

            {

                if (age < 22)

                {

                    throw new InvalidAgeException("NOT ELIGIBLE - Your VALID age must be atleast 22 years old.");



                }

                else

                {

                    Console.WriteLine("YES YOUR AGE IS ELIGIBLE FOR VALIDATION!!");

                }

            }

            public static void Main(string[] args)

            {

                try

                {

                    Console.WriteLine("Enter the your age");

                    var age = Convert.ToInt32(Console.ReadLine());

                    validate(age);

                }

                catch (InvalidAgeException e)

                {

                    Console.WriteLine(e);



                }

            }

        }



    


