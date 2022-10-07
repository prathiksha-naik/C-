

using System;
using System.Drawing;

class GenericDelegate
{

    
    public delegate void circle(double rad);
    public delegate void cube(double side);
    public delegate void square(double side);

    public void circlearea(double rad)
    {
        double area = Math.PI * rad * rad;
        Console.WriteLine("Area of circle is: {0}",area);
    }
    public void cubearea(double side)
    {
        double Area = 6 * (side * side);
        Console.WriteLine("Area of cube is: {0}", Area);
    }
    public void squarearea(double side)
    {
        double Area = side * side;
        Console.WriteLine("Area of square is: {0}", Area);
    }


    

    public static void Main(String[] args)
    {
        GenericDelegate rect = new GenericDelegate();
        circle obj1 = new circle(rect.circlearea);
        obj1.Invoke(2);
        cube obj2 = new cube(rect.cubearea);
        obj2.Invoke(4);
        square obj3 = new square(rect.squarearea);
        obj3.Invoke(6);




    }
}

