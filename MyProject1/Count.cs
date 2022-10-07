using System;
using System.IO;
using System.Text;

class Count
{
    public static void Main()
    {
        string fileName = @"details.txt";
      
            // Create the file.
            using (StreamWriter fileStr = File.CreateText(fileName))
            {
                fileStr.WriteLine(" Name : Prathiksha");
                fileStr.WriteLine(" EmpID : EI13144");
                fileStr.WriteLine(" Qualification : BE in ComputerScience");
                fileStr.WriteLine(" Age : 22");
                fileStr.WriteLine(" Salary : 4.5LPA ");

                
               
            }
        int count = File.ReadAllLines(fileName).Length;
        Console.WriteLine("Number of lines: " + count);
    }
        
    }
