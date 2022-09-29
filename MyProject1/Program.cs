enum holidays
{
    january,
    october = january + 2,
    september = january + 3,
    april = september + 1,
    december
}



class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("On month of Jan " + (int)holidays.january);
        Console.WriteLine("On month of Oct " + (int)holidays.october);
        Console.WriteLine("On month of Sept " + (int)holidays.september);
        Console.WriteLine("On month of April " + (int)holidays.april);
        Console.WriteLine("On month of Dec " + (int)holidays.december);


    }
}