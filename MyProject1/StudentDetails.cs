using System;

public class StudentDetails
{
    public static void Main()
    {
        int sid;
        string sname;
        string sdep;

        OutParamExample(out sid, out sname, out sdep);

        Console.Write("Student ID: " + sid + "\n");
        Console.Write("Student name: " + sname + "\n");
        Console.Write("Student department:" + sdep + "\n");


    }

    public static void OutParamExample(out int sid, out string sname, out string sdep)
    {
        Console.WriteLine("Enter the Student ID");
        sid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Student name");
        sname = Console.ReadLine();
        Console.WriteLine("Enter the Student department");
        sdep = Console.ReadLine();
    }
}