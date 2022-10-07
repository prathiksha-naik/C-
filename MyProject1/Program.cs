using System;
class matrixAdd
{
public static void Main()
{
    int [,] mat1 = new int[3,3];
    int [,] mat2 = new int[3,3];
    int [,] addition = new int[3,3];
    int i, j;
    Console.WriteLine("Enter the elements of the matrix1: ");
    for(i=0; i<3; i++)
    {
        for(j=0; j<3; j++)
        {
            mat1[i,j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    Console.WriteLine("matrix1: ");
    for(i=0; i<3; i++)
    {
        for(j=0; j<3; j++)
        {
            Console.Write("{0} ", mat1[i,j]);
        }
        Console.Write("\n");
    }

    Console.WriteLine("matrix2: ");
    for(i=0; i<3; i++)
    {
        for(j=0; j<3; j++)
        {
            mat2[i,j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    Console.WriteLine("elements of the matrix2: ");
    for(i=0; i<3; i++)
    {
        for(j=0; j<3; j++)
        {
            Console.Write("{0} ", mat2[i,j]);
        }
        Console.Write("\n");
    }

    for(i=0; i<3; i++)
    {
        for(j=0; j<3; j++)
        {
            addition[i,j] = mat1[i,j] + mat2[i,j];
        }
    }

    Console.WriteLine("Addition of the matrix1 and matrix2: ");
    for(i=0; i<3; i++)
    {
        for(j=0; j<3; j++)
        {
            Console.Write("{0} ", addition[i,j]);
        }
        Console.Write("\n");
    }   
    }
}