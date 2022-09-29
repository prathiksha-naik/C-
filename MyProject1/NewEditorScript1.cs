


/*
Example 1     
    public class total
 {
     public static int sum = 0;


     public total()
     {
         total.sum++;
     }
 }

 class Program
 {
     static void Main(string[] args)
     {
         total s1 = new total();
         total s2 = new total();
         Console.WriteLine($"Total count is: {total.sum}"); 

         total s3 = new total();
         total s4 = new total();
         Console.WriteLine($"Total count is: { total.sum}"); 
     }
 }*/
//Example 2
/*class hello{
    public static void Hey() {
        Console.WriteLine("I am static method");
    }

}
class HI {
public void hoi(){
        Console.WriteLine("I am instance method");
    }
 }
class Program
{
    static void Main(string[] args)
    {
        //Call static method by class name 

        hello.Hey();

        //Call non-static method. call method by object
        HI hi = new HI();
        hi.hoi();
    }
}
*/
/*class stat
{
    public static string value = "odd";
    public static string value1 = "even";
    public void even_odd(int num)
    {
        if (num%2== 0)
        {
            Console.WriteLine(value1);
        } 
        else if (num % 2 != 0)
        {
            Console.WriteLine(value);
        }
        
    }
}
class Program
{
    static void Main(string[] args)
    {
        stat stat = new stat();
        stat.even_odd(10);
       
    }
}
*/
/*class employee
{
    public static string firstname;
    public static string lastname;
    public static int age;
    public static int salary;
    public void employeedetails()
    {
        Console.WriteLine(firstname);
        Console.WriteLine(lastname);
        Console.WriteLine(age);
        Console.WriteLine(salary);
        
        
        double bonus = (Convert.ToDouble(salary) * 25) / 100;
        double totalsalry = Convert.ToDouble(salary) + bonus;
        Console.WriteLine("Total Salary with bonus{0}", totalsalry);
        Console.ReadLine();
    }
}
class Program
{
    static void Main(string[] args)
    {
        employee.firstname = "Prathiksha";
        employee.lastname = "naik";
        employee.age = 22;
        employee.salary = 35000;
        employee em=new employee();
        em.employeedetails();
    }
}*/