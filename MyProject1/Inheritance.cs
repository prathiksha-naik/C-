using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccessSpecifiers
{
    public class Bonus
    {

        protected int bonus;
        protected string empname = "";
        protected int empid;
        protected int salary;
    }
    public class staff : Bonus
    {
        public void staff_salarybonus()
        {
            Console.WriteLine("Enter the Employee Name");
            empname = Console.ReadLine();
            Console.WriteLine("Enter the Employee ID");
            empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Salary");
            salary = Convert.ToInt32(Console.ReadLine());
            bonus = 3 * salary;
            Console.WriteLine($"bonus{bonus}");
        }
        public class Nonstaff : staff
        {
            public void nonstaff_bonus()
            {
                Console.WriteLine("Enter the Employee Name");
                empname = Console.ReadLine();
                Console.WriteLine("Enter the Employee ID");
                empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Employee Salary");
                salary = Convert.ToInt32(Console.ReadLine());
                bonus = 2 * salary;
                Console.WriteLine($"bonus{bonus}");
            }
        }
        internal class Inheritance
        {
            public static void Main()
            {
                staff s = new staff();
                s.staff_salarybonus();
                Nonstaff n1 = new Nonstaff();
                Nonstaff n = new Nonstaff();
                n.nonstaff_bonus();
            }
        }
    }
}
   