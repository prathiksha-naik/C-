class File1

{
    static void Main(string[] args)
    {
        Console.WriteLine("Multiplication Table");
       
        const int END = 11;
        for (int x = 1; x < END; x++)
        {
            for (int y = 1; y < END; y++)
            {
                int value = x * y;
                Console.Write("{0} * {1} = {2}\t", y, x, value);
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}